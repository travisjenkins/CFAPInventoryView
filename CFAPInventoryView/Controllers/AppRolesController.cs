using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
    public class AppRolesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AppRolesController(UserManager<ApplicationUser> usermanager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = usermanager;
            _roleManager = roleManager;
        }

        // List all users and their assigned roles
        public async Task<IActionResult> Index()
        {
            List<AppRolesViewModel> userRoles = new();
            var users = _userManager.Users;
            if (users is not null)
            {
                foreach (var user in users)
                {
                    AppRolesViewModel viewModel = new()
                    {
                        ApplicationUser = user,
                        AssignedRoles = await _userManager.GetRolesAsync(user),
                    };
                    userRoles.Add(viewModel);
                }
            }
            if (TempData["ModelState"] is not null)
            {
                RetrieveTransferredErrors();
            }
            return View(userRoles);
        }

        private void RetrieveTransferredErrors()
        {
#pragma warning disable CS8602 // Defreference of a possibly null reference
            var modelStateString = TempData["ModelState"].ToString();
#pragma warning restore CS8602 // Defreference of a possibly null reference
            if (!string.IsNullOrEmpty(modelStateString))
            {
                var dictionaryOfErrors = JsonSerializer.Deserialize<Dictionary<string, string?>>(modelStateString);
                if (dictionaryOfErrors is not null)
                {
                    foreach (var item in dictionaryOfErrors)
                    {
                        ModelState.AddModelError(item.Key, item.Value ?? "");
                    }
                }
            }
        }

        [Authorize(Roles = HelperMethods.AdministratorRole)]
        [HttpPost]
        public async Task<IActionResult> Promote(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
            {
                ModelState.AddModelError(string.Empty, $"A user with Id ({userId}) could not be located in the database.");
            }
            else
            {
                // Do not allow self-promoting
                if (User.Identity?.Name is not null && User.Identity.Name != user.UserName)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles is null || roles.Count == 0)
                    {
                        ModelState.AddModelError(string.Empty, $"The user {user.UserName} has no roles assigned to promote from.");
                    }
                    else
                    {
                        // There should only ever be one role assigned
                        foreach (var role in roles)
                        {
                            if (role == HelperMethods.MemberRole)
                            {
                                await PromoteTo(user, role, HelperMethods.ManagerRole);
                            }
                            else if (role == HelperMethods.ManagerRole)
                            {
                                await PromoteTo(user, role, HelperMethods.AdministratorRole);
                            }
                            else
                            {
                                ModelState.AddModelError(string.Empty, $"The user {user.UserName} is already an Administrator.");
                            }
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid operation:  You cannot promote yourself.");
                }
            }
            if (ModelState.ErrorCount > 0)
            {
                await PrepareErrorsForTransfer();
            }
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = HelperMethods.AdministratorRole)]
        [HttpPost]
        public async Task<IActionResult> Demote(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
            {
                ModelState.AddModelError(string.Empty, $"A user with Id ({userId}) could not be located in the database.");
            }
            else
            {
                // Do not allow self-demoting
                if (User.Identity?.Name is not null && User.Identity.Name != user.UserName)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    if (roles is null || roles.Count == 0)
                    {
                        ModelState.AddModelError(string.Empty, $"The user {user.UserName} has no roles assigned to demote from.");
                    }
                    else
                    {
                        foreach (var role in roles)
                        {
                            if (role == HelperMethods.AdministratorRole)
                            {
                                await DemoteTo(user, role, HelperMethods.ManagerRole);
                            }
                            else if (role == HelperMethods.ManagerRole)
                            {
                                await DemoteTo(user, role, HelperMethods.MemberRole);
                            }
                            else
                            {
                                ModelState.AddModelError(string.Empty, $"The user {user.UserName} cannot be demoted further than Member.");
                            }
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid operation:  You cannot demote yourself.");
                }
            }
            if (ModelState.ErrorCount > 0)
            {
                await PrepareErrorsForTransfer();
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task PromoteTo(ApplicationUser user, string promoteFrom, string promoteTo)
        {
            var addResult = await _userManager.AddToRoleAsync(user, promoteTo);
            if (addResult.Succeeded)
            {
                var removeResult = await _userManager.RemoveFromRoleAsync(user, promoteFrom);
                if (!removeResult.Succeeded)
                {
                    foreach (var error in removeResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, $"{error.Code}: {error.Description}");
                    }
                }
            }
            else
            {
                foreach (var error in addResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, $"{error.Code}: {error.Description}");
                }

            }
        }

        private async Task DemoteTo(ApplicationUser user, string demoteFrom, string demoteTo)
        {
            var removeResult = await _userManager.RemoveFromRoleAsync(user, demoteFrom);
            if (removeResult.Succeeded)
            {
                var addResult = await _userManager.AddToRoleAsync(user, demoteTo);
                if (!addResult.Succeeded)
                {
                    foreach (var error in addResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, $"{error.Code}: {error.Description}");
                    }
                }
            }
            else
            {
                foreach (var error in removeResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, $"{error.Code}: {error.Description}");
                }
            }
        }

        private async Task PrepareErrorsForTransfer()
        {
#pragma warning disable CS8602 // Defreference of a possibly null reference
            var dictionaryOfErrors = ModelState.Where(s => s.Value.Errors.Any()).ToDictionary(m => m.Key, m => m.Value.Errors.Select(s => s.ErrorMessage).FirstOrDefault(s => s is not null));
#pragma warning restore CS8602 // Defreference of a possibly null reference

            using var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, dictionaryOfErrors);
            stream.Position = 0;

            using var reader = new StreamReader(stream);
            var json = await reader.ReadToEndAsync();

            TempData["ModelState"] = json;
        }
    }
}
