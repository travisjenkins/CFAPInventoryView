using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Services;
using Microsoft.AspNetCore.Authorization;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole},{HelperMethods.MemberRole}")]
    public class SuppliesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<SuppliesController> _logger;

        public SuppliesController(ApplicationDbContext context, ILogger<SuppliesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Supplies
        public async Task<IActionResult> Index()
        {
            return _context.Supplies != null ?
                        View(await _context.Supplies.AsNoTracking()
                                                    .Include(p => p.Category)
                                                    .Include(p => p.OptionalCategory)
                                                    .Include(p => p.ExcludeCategory)
                                                    .OrderBy(p => p.PurchaseDate)
                                                    .ThenByDescending(p => p.Price)
                                                    .ToListAsync()) :
                        Problem("Entity set 'Supplies' is null.");
        }

        // GET: Supplies/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Supplies == null)
            {
                return NotFound();
            }

            var supply = await _context.Supplies.AsNoTracking()
                                                 .Include(p => p.Category)
                                                 .Include(p => p.OptionalCategory)
                                                 .Include(p => p.ExcludeCategory)
                                                 .FirstOrDefaultAsync(m => m.SupplyId == id);
            if (supply == null)
            {
                return NotFound();
            }

            return View(supply);
        }

        // GET: Supplies/Create
        public async Task<IActionResult> Create()
        {
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context);
            return View();
        }

        // POST: Supplies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description,Expires,ExpirationDate,PurchaseDate,Quantity,Price,Barcode,CategoryId,OptionalCategoryId,ExcludeCategoryId")] Supply supply)
        {
            if (ModelState.IsValid)
            {
                if (supply.CategoryId is not null || supply.OptionalCategoryId is not null || supply.ExcludeCategoryId is not null)
                {
                    try
                    {
                        supply.SupplyId = Guid.NewGuid();
                        supply.LastUpdateId = User.Identity?.Name;
                        supply.LastUpdateDateTime = DateTime.Now;
                        _context.Add(supply);
                        await HelperMethods.IncreaseAssignedCategoryQuantity(_context, supply);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch (DbUpdateException ex)
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue creating the supply.  If the issue persists, please contact an administrator.");
                    }
                }
                ModelState.AddModelError(string.Empty, "A supply must be assigned to a category.");
            }
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context, supply.CategoryId);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context, supply.OptionalCategoryId);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context, supply.ExcludeCategoryId);
            return View(supply);
        }

        // GET: Supplies/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Supplies == null)
            {
                return NotFound();
            }

            var supply = await _context.Supplies.FindAsync(id);
            if (supply == null)
            {
                return NotFound();
            }
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context, supply.CategoryId);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context, supply.OptionalCategoryId);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context, supply.ExcludeCategoryId);
            return View(supply);
        }

        // POST: Supplies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("SupplyId,Name,Description,Expires,ExpirationDate,PurchaseDate,Quantity,Price,Barcode,CategoryId,OptionalCategoryId,ExcludeCategoryId")] Supply supply)
        {
            if (id != supply.SupplyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (supply.CategoryId is not null || supply.OptionalCategoryId is not null || supply.ExcludeCategoryId is not null)
                {
                    try
                    {
                        await HelperMethods.UpdateAssignedCategoryQuantity(_context, supply);
                        supply.LastUpdateId = User.Identity?.Name;
                        supply.LastUpdateDateTime = DateTime.Now;
                        _context.Update(supply);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateException ex)
                    {
                        if (!SupplyExists(supply.SupplyId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                            ModelState.AddModelError(string.Empty, "There was an issue updating the product.  If the issue persists, please contact an administrator.");
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError(string.Empty, "A product must be assigned to a category.");
            }
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context, supply.CategoryId);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context, supply.OptionalCategoryId);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context, supply.ExcludeCategoryId);
            return View(supply);
        }

        // GET: Supplies/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Supplies == null)
            {
                return NotFound();
            }

            var supply = await _context.Supplies.AsNoTracking()
                                                 .Include(p => p.Category)
                                                 .Include(p => p.OptionalCategory)
                                                 .Include(p => p.ExcludeCategory)
                                                 .FirstOrDefaultAsync(m => m.SupplyId == id);
            if (supply == null)
            {
                return NotFound();
            }

            return View(supply);
        }

        // POST: Supplies/Delete/5
        [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Supplies == null)
            {
                return Problem("Entity set 'Supplies' is null.");
            }
            var supply = await _context.Supplies.FindAsync(id);
            if (supply != null)
            {
                try
                {
                    await HelperMethods.DecreaseAssignedCategoryQuantity(_context, supply);
                    _context.Supplies.Remove(supply);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                    ModelState.AddModelError(string.Empty, "There was an issue encountered while deleting the supply.  Please contact an administrator.");
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool SupplyExists(Guid id)
        {
          return (_context.Supplies?.Any(e => e.SupplyId == id)).GetValueOrDefault();
        }
    }
}
