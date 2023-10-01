using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
    public class AppRolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public AppRolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        // List all created roles
        public IActionResult Index()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [Authorize(Roles = HelperMethods.AdministratorRole)]
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [Authorize(Roles = HelperMethods.AdministratorRole)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            if (role is null)
            {
                ModelState.AddModelError(string.Empty, "Your role information was blank. Please fill in the form to create a new role.");
                return View(role);
            }
            IdentityRole newIdentityRole = new();
            if (await TryUpdateModelAsync<IdentityRole>(newIdentityRole, "", ir => ir.Name))
            {
                if (!string.IsNullOrWhiteSpace(newIdentityRole.Name))
                {
                    // Avoid duplicate roles
                    if (!await _roleManager.RoleExistsAsync(newIdentityRole.Name))
                    {
                        await _roleManager.CreateAsync(new IdentityRole { Name = newIdentityRole.Name });
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, $"The role {role.Name} alread exists in the database.");
                    }
                }
            }
            return View(role);
        }
    }
}
