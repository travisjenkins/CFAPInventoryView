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

        public ExcludeCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ExcludeCategories
        public async Task<IActionResult> Index()
        {
            return _context.ExcludeCategories != null ?
                        View(await _context.ExcludeCategories.Where(ec => ec.Active).OrderBy(ec => ec.Name).ToListAsync()) :
                        Problem("Entity set 'ExcludeCategories' is null.");
        }

        // GET: ExcludeCategories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.ExcludeCategories == null)
            {
                return NotFound();
            }

            var excludeCategory = await _context.ExcludeCategories
                .FirstOrDefaultAsync(m => m.ExcludeCategoryId == id);
            if (excludeCategory == null)
            {
                return NotFound();
            }

            return View(excludeCategory);
        }

        // GET: ExcludeCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExcludeCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name")] ExcludeCategory excludeCategory)
        {
            if (ModelState.IsValid)
            {
                if (!await _context.ExcludeCategories.AnyAsync(c => c.Name == excludeCategory.Name))
                {
                    excludeCategory.ExcludeCategoryId = Guid.NewGuid();
                    excludeCategory.Active = true;
                    excludeCategory.LastUpdateId = User.Identity?.Name;
                    excludeCategory.LastUpdateDateTime = DateTime.Now;
                    _context.Add(excludeCategory);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError(nameof(excludeCategory.Name), $"The exclude category ({excludeCategory.Name}) already exists in the database.");
            }
            return View(excludeCategory);
        }

        // GET: ExcludeCategories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ExcludeCategories == null)
            {
                return NotFound();
            }

            var excludeCategory = await _context.ExcludeCategories.FindAsync(id);
            if (excludeCategory == null)
            {
                return NotFound();
            }
            return View(excludeCategory);
        }

        // POST: ExcludeCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("ExcludeCategoryId,Name,Active")] ExcludeCategory excludeCategory)
        {
            if (id != excludeCategory.ExcludeCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (!await _context.ExcludeCategories.AnyAsync(c => c.Name == excludeCategory.Name))
                {
                    try
                    {
                        excludeCategory.LastUpdateId = User.Identity?.Name;
                        excludeCategory.LastUpdateDateTime = DateTime.Now;
                        _context.Update(excludeCategory);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ExcludeCategoryExists(excludeCategory.ExcludeCategoryId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError(nameof(excludeCategory.Name), $"The exclude category ({excludeCategory.Name}) already exists in the database.");
            }
            return View(excludeCategory);
        }

        // GET: ExcludeCategories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ExcludeCategories == null)
            {
                return NotFound();
            }

            var excludeCategory = await _context.ExcludeCategories
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
