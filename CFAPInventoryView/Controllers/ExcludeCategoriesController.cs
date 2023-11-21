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

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
    public class ExcludeCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ExcludeCategoriesController> _logger;

        public ExcludeCategoriesController(ApplicationDbContext context, ILogger<ExcludeCategoriesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: ExcludeCategories
        public async Task<IActionResult> Index()
        {
            return _context.ExcludeCategories != null ?
                        View(await _context.ExcludeCategories.AsNoTracking()
                                                             .Include(ec => ec.AgeGroups)
                                                               .ThenInclude(agc => agc.AgeGroup)
                                                             .OrderBy(ec => ec.Name)
                                                             .ToListAsync()) :
                        Problem("Entity set 'ExcludeCategories' is null.");
        }

        // GET: ExcludeCategories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.ExcludeCategories == null)
            {
                return NotFound();
            }

            var excludeCategory = await _context.ExcludeCategories.AsNoTracking()
                                                                  .Include(ec => ec.AgeGroups)
                                                                    .ThenInclude(agc => agc.AgeGroup)
                                                                  .FirstOrDefaultAsync(ec => ec.ExcludeCategoryId == id);
            if (excludeCategory == null)
            {
                return NotFound();
            }

            return View(excludeCategory);
        }

        // GET: ExcludeCategories/Create
        public async Task<IActionResult> Create()
        {
            ExcludeCategory category = new();
            ViewData["AssignedAgeGroupsList"] = await HelperMethods.PopulateAssignedAgeGroups(_context, category);
            return View();
        }

        // POST: ExcludeCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name")] ExcludeCategory excludeCategory, List<Guid>? selectedAgeGroupIds)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!await _context.ExcludeCategories.AnyAsync(c => c.Name == excludeCategory.Name))
                    {
                        excludeCategory.ExcludeCategoryId = Guid.NewGuid();
                        excludeCategory.LastUpdateId = User.Identity?.Name;
                        excludeCategory.LastUpdateDateTime = DateTime.Now;
                        _context.Add(excludeCategory);
                        await _context.SaveChangesAsync();
                        await HelperMethods.AddAgeGroupsToCategory(_context, excludeCategory.ExcludeCategoryId, selectedAgeGroupIds, nameof(ExcludeCategory));
                        return RedirectToAction(nameof(Index));
                    }
                    ModelState.AddModelError(nameof(excludeCategory.Name), $"The exclude category ({excludeCategory.Name}) already exists in the database.");
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "There was an issue creating the exclude category. If the issue continues please contact an administrator.");
            }
            ViewData["AssignedAgeGroupsList"] = await HelperMethods.PopulateAssignedAgeGroups(_context, excludeCategory);
            return View(excludeCategory);
        }

        // GET: ExcludeCategories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ExcludeCategories == null)
            {
                return NotFound();
            }

            var excludeCategory = await _context.ExcludeCategories.Include(c => c.AgeGroups)
                                                                     .ThenInclude(agc => agc.AgeGroup)
                                                                  .FirstOrDefaultAsync(c => c.ExcludeCategoryId == id);
            if (excludeCategory == null)
            {
                return NotFound();
            }
            ViewData["AssignedAgeGroupsList"] = await HelperMethods.PopulateAssignedAgeGroups(_context, excludeCategory);
            return View(excludeCategory);
        }

        // POST: ExcludeCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("ExcludeCategoryId,Name")] ExcludeCategory excludeCategory, List<Guid>? selectedAgeGroupIds)
        {
            if (id != excludeCategory.ExcludeCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                try
                {
                    excludeCategory.LastUpdateId = User.Identity?.Name;
                    excludeCategory.LastUpdateDateTime = DateTime.Now;
                    _context.Update(excludeCategory);
                    await HelperMethods.EditAgeGroupsForCategory(_context, id, selectedAgeGroupIds, nameof(ExcludeCategory));
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex)
                {
                    if (!ExcludeCategoryExists(excludeCategory.ExcludeCategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue updating the exclude category. If the issue continues please contact an administrator.");
                    }
                }
            }
            ViewData["AssignedAgeGroupsList"] = await HelperMethods.PopulateAssignedAgeGroups(_context, excludeCategory);
            return View(excludeCategory);
        }

        // GET: ExcludeCategories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ExcludeCategories == null)
            {
                return NotFound();
            }

            var excludeCategory = await _context.ExcludeCategories.AsNoTracking()
                                                                  .Include(c => c.AgeGroups)
                                                                    .ThenInclude(agc => agc.AgeGroup)
                                                                  .FirstOrDefaultAsync(m => m.ExcludeCategoryId == id);
            if (excludeCategory == null)
            {
                return NotFound();
            }

            return View(excludeCategory);
        }

        // POST: ExcludeCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.ExcludeCategories == null)
            {
                return Problem("Entity set 'ExcludeCategories' is null.");
            }
            var excludeCategory = await _context.ExcludeCategories.FindAsync(id);
            if (excludeCategory != null)
            {
                _context.ExcludeCategories.Remove(excludeCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExcludeCategoryExists(Guid id)
        {
          return (_context.ExcludeCategories?.Any(e => e.ExcludeCategoryId == id)).GetValueOrDefault();
        }
    }
}
