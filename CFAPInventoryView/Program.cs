using CFAPInventoryView;
using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Net;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("CFAPInventory") ?? throw new InvalidOperationException("Connection string 'CFAPInventory' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews(options =>
{
    // Automatically validate all requests other than GET, HEAD, OPTIONS, and TRACE
    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
});

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8; // default is 6
    options.Password.RequiredUniqueChars = 6; // default is 1

    // Lockout settings
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30); // default is 5
    options.Lockout.MaxFailedAccessAttempts = 3; // default is 5

    // User settings
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true; // default is false

    // Sign In settings
    options.SignIn.RequireConfirmedEmail = true; // default is false
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromHours(1); // default is 14 days
    options.LoginPath = "/Identity/Account/Login";
    options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
    options.SlidingExpiration = false; // default is true
});

builder.Services.Configure<DataProtectionTokenProviderOptions>(options =>
{
    options.TokenLifespan = TimeSpan.FromHours(3); // default is 1 day, this is how long the emailed tokens will be valid
});

// Password hasher uses the PBKDF2 hashing function and generates a random salt per user
builder.Services.Configure<PasswordHasherOptions>(options =>
{
    options.IterationCount = 12000; // default is 10000
});

/*
 * Force users to be logged in to access pages by default
 * https://learn.microsoft.com/en-us/aspnet/core/security/authorization/secure-data?view=aspnetcore-7.0#rau
 * Adding the data annotation [AllowAnonymous] to the page class or a specific page method overrides this requirement (i.e. HomeController, Login, and Register pages)
 */
builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
                                    .RequireAuthenticatedUser()
                                    .Build();
});

/*
 * Add custom emailer configuration
 * https://learn.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-7.0&tabs=visual-studio
 */
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);

/*
 * Add rate limiting
 * Set to allow no more than 3 requests every 60 seconds
 * https://learn.microsoft.com/en-us/aspnet/core/performance/rate-limit?view=aspnetcore-7.0
 * Helps prevent DoS attacks (this needs to be tested thoroughly before release)
 * This policy is applied to the Login, Register, and ResetPassword pages
 */
var myOptions = builder.Configuration.GetSection("RateLimitOptions").Get<RateLimitOptions>();
if (myOptions is not null)
{
    builder.Services.AddRateLimiter(rateLimiterOptions => {
        rateLimiterOptions.OnRejected = (context, cancellationToken) =>
        {
            if (context.Lease.TryGetMetadata(MetadataName.RetryAfter, out var retryAfter))
            {
                context.HttpContext.Response.Headers.RetryAfter =
                    ((int)retryAfter.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo);
            }
            context.HttpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
            context.HttpContext.Response.WriteAsync("Too many requests. Please try again later.", cancellationToken: cancellationToken);

            return new ValueTask();
        };
        rateLimiterOptions.AddFixedWindowLimiter(policyName: myOptions.PolicyName ?? "fixed", options =>
            {
                options.PermitLimit = myOptions.PermitLimit;
                options.Window = TimeSpan.FromSeconds(myOptions.Window);
                options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                options.QueueLimit = myOptions.QueueLimit;
            });
        });
}

if (!builder.Environment.IsDevelopment())
{
    builder.Services.AddHttpsRedirection(options =>
    {
        options.RedirectStatusCode = (int)HttpStatusCode.PermanentRedirect; // defaults to temporary redirect (http status code 307)
        options.HttpsPort = 443;
    });
    /*
     * The default HSTS value is 30 days.
     * https://aka.ms/aspnetcore-hsts
     * 
     * Add the preload parameter to the Strict-Transport-Security header
     * Add the includeSubDomains parameter to the Strict-Transport-Security header (Applies HSTS policy to all host subdomains)
     * Explicity set the max-age parameter of the Strict-Transport-Security header to 12 hours (Recommend changing to 365 days after initial roll-out)
     * https://cheatsheetseries.owasp.org/cheatsheets/HTTP_Strict_Transport_Security_Cheat_Sheet.html
     * These settings help protect against Clickjacking and Man-in-the-Middle attacks
     */
    builder.Services.AddHsts(options =>
    {
        options.Preload = true;
        options.IncludeSubDomains = true;
        options.MaxAge = TimeSpan.FromHours(12);
    });
    builder.Services.AddWebOptimizer();
}
else
{
    // Disable bundling and minification during Development to simplify debugging
    builder.Services.AddWebOptimizer(minifyJavaScript: false, minifyCss: false);
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
    app.UseRateLimiter();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

/* Add the authorization roles if they are not already in the database
 * These are the roles available to control access to restricted resources
 * Admin: full control (can promote members to new roles)
 * Manager: Can approve/deny member access
 * Member: Can add items to inventory
 */
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var roles = new[] { HelperMethods.AdministratorRole, HelperMethods.ManagerRole, HelperMethods.MemberRole };
    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
            await roleManager.CreateAsync(new IdentityRole(role));
    }
}

app.Run();
