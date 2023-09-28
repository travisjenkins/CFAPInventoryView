using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CFAPInventoryView.Controllers
{
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

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            IdentityRole newIdentityRole = new();
            if (await TryUpdateModelAsync<IdentityRole>(newIdentityRole, "", ir => ir.Name))
            {
                // Avoid duplicate roles
                if (!await _roleManager.RoleExistsAsync(role.Name))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = role.Name });
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"The role {role.Name} alread exists in the database.");
                }
            }
            return View(role);
        }
    }
}
