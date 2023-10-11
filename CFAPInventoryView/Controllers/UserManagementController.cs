using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = HelperMethods.AdministratorRole)]
    public class UserManagementController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        
        public UserManagementController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        
        // GET: UserManagement
        public async Task<IActionResult> Index()
        {
            var viewModel = new List<UserManagementViewModel>();
            var users = await _userManager.Users.ToListAsync();

            foreach (var user in users)
            {
                if (user.UserName == User.Identity?.Name)
                {
                    continue; // Don't add the admin accessing the page
                }
                viewModel.Add(new UserManagementViewModel
                {
                    ApplicationUser = user,
                    IsLockedOut = await _userManager.IsLockedOutAsync(user),
                    LockoutEndDate = user.LockoutEnd?.Date
                });
            }

            if (TempData["ModelState"] is not null)
            {
                HelperMethods.RetrieveTransferredErrors(ModelState, TempData);
            }
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> LockUserAccount(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError(string.Empty, "The user email was null");
            }
            else
            {
                var user = await _userManager.FindByEmailAsync(email);
                if (user is null)
                {
                    ModelState.AddModelError(string.Empty, $"Cannot find a user who's email is {email}");
                }
                else
                {
                    var lockUserResult = await _userManager.SetLockoutEnabledAsync(user, true);
                    if (lockUserResult.Succeeded)
                    {
                        var lockDateResult = await _userManager.SetLockoutEndDateAsync(user, DateTimeOffset.MaxValue);
                        if (!lockDateResult.Succeeded)
                        {
                            foreach (var error in lockDateResult.Errors)
                            {
                                ModelState.AddModelError(error.Code, error.Description);
                            }
                        }
                    }
                    else
                    {
                        foreach (var error in lockUserResult.Errors)
                        {
                            ModelState.AddModelError(error.Code, error.Description);
                        }
                    }
                }
            }

            if (ModelState.ErrorCount > 0)
            {
                await HelperMethods.PrepareErrorsForTransfer(ModelState, TempData);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> UnlockUserAccount(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError(string.Empty, "The user email was null");
            }
            else
            {
                var user = await _userManager.FindByEmailAsync(email);
                if (user is null)
                {
                    ModelState.AddModelError(string.Empty, $"Cannot find a user who's email is {email}");
                }
                else
                {
                    var unlockDateResult = await _userManager.SetLockoutEndDateAsync(user, null);
                    if (unlockDateResult.Succeeded)
                    {
                        var unlockUserResult = await _userManager.SetLockoutEnabledAsync(user, false);
                        if (!unlockUserResult.Succeeded)
                        {
                            foreach (var error in unlockUserResult.Errors)
                            {
                                ModelState.AddModelError(error.Code, error.Description);
                            }
                        }
                    }
                    else
                    {
                        foreach (var error in unlockDateResult.Errors)
                        {
                            ModelState.AddModelError(error.Code, error.Description);
                        }
                    }
                }
            }

            if (ModelState.ErrorCount > 0)
            {
                await HelperMethods.PrepareErrorsForTransfer(ModelState, TempData);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: UserManagement/Delete/5
        public async Task<IActionResult> Delete(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return NotFound("You must supply the email of the user you are trying to delete.");
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user is null)
            {
                return NotFound($"Could not find a user with email {email}.");
            }
            return View(user);
        }

        // POST: UserManagement/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return RedirectToAction(nameof(Delete), new { email });
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user is null)
            {
                return RedirectToAction(nameof(Delete), new { email });
            }
            var deleteResult = await _userManager.DeleteAsync(user);
            if (deleteResult.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                foreach (var error in deleteResult.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return View();
            }
        }
    }
}
