using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using Microsoft.AspNetCore.Authorization;
using CFAPInventoryView.Models;
using Microsoft.EntityFrameworkCore.Design;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ApplicationDbContext context, ILogger<CategoriesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return _context.Categories != null ?
                        View(await _context.Categories.AsNoTracking()
                                                      .Include(c => c.AgeGroups)
                                                        .ThenInclude(agc => agc.AgeGroup)
                                                      .OrderBy(c => c.Name)
                                                      .ToListAsync()) :
                        Problem("Entity set 'Categories' is null.");
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.AsNoTracking()
                                                    .Include(c => c.AgeGroups)
                                                      .ThenInclude(agc => agc.AgeGroup)
                                                    .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Categories/Create
        public async Task<IActionResult> Create()
        {
            Category category = new();
            ViewData["AssignedAgeGroupsList"] = await HelperMethods.PopulateAssignedAgeGroups(_context, category);
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Quantity,SafeStockLevel")] Category category, List<Guid>? selectedAgeGroupIds)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!await _context.Categories.AnyAsync(c => c.Name == category.Name))
                    {
                        category.CategoryId = Guid.NewGuid();
                        category.LastUpdateId = User.Identity?.Name;
                        category.LastUpdateDateTime = DateTime.Now;
                        _context.Add(category);
                        await _context.SaveChangesAsync();
                        await HelperMethods.AddAgeGroupsToCategory(_context, category.CategoryId, selectedAgeGroupIds, nameof(Category));
                        return RedirectToAction(nameof(Index));
                    }
                    ModelState.AddModelError(nameof(category.Name), $"The category ({category.Name}) already exists in the database.");
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "There was an issue creating the category. If the issue continues please contact an administrator.");
            }
            ViewData["AssignedAgeGroupsList"] = await HelperMethods.PopulateAssignedAgeGroups(_context, category);
            return View(category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.Include(c => c.AgeGroups)
                                                        .ThenInclude(agc => agc.AgeGroup)
                                                    .FirstOrDefaultAsync(c => c.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }
            ViewData["AssignedAgeGroupsList"] = await HelperMethods.PopulateAssignedAgeGroups(_context, category);
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("CategoryId,Name,Quantity,SafeStockLevel")] Category category, List<Guid>? selectedAgeGroupIds)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    category.LastUpdateId = User.Identity?.Name;
                    category.LastUpdateDateTime = DateTime.Now;
                    _context.Update(category);
                    await HelperMethods.EditAgeGroupsForCategory(_context, id, selectedAgeGroupIds, nameof(Category));
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex)
                {
                    if (!CategoryExists(category.CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue updating the category. If the issue continues please contact an administrator.");
                    }
                }
            }
            ViewData["AssignedAgeGroupsList"] = await HelperMethods.PopulateAssignedAgeGroups(_context, category);
            return View(category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.AsNoTracking()
                                                    .Include(c => c.AgeGroups)
                                                      .ThenInclude(agc => agc.AgeGroup)
                                                    .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'Categories' is null.");
            }
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                try
                {
                    _context.Categories.Remove(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(Guid id)
        {
          return (_context.Categories?.Any(e => e.CategoryId == id)).GetValueOrDefault();
        }
    }
}
