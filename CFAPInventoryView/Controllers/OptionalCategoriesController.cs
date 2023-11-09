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
    public class OptionalCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OptionalCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OptionalCategories
        public async Task<IActionResult> Index()
        {
              return _context.OptionalCategories != null ? 
                          View(await _context.OptionalCategories.OrderBy(oc => oc.Name).ToListAsync()) :
                          Problem("Entity set 'OptionalCategories' is null.");
        }

        // GET: OptionalCategories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.OptionalCategories == null)
            {
                return NotFound();
            }

            var optionalCategory = await _context.OptionalCategories
                .FirstOrDefaultAsync(m => m.OptionalCategoryId == id);
            if (optionalCategory == null)
            {
                return NotFound();
            }

            return View(optionalCategory);
        }

        // GET: OptionalCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OptionalCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name")] OptionalCategory optionalCategory)
        {
            if (ModelState.IsValid)
            {
                if (!await _context.OptionalCategories.AnyAsync(c => c.Name == optionalCategory.Name))
                {
                    optionalCategory.OptionalCategoryId = Guid.NewGuid();
                    optionalCategory.Active = true;
                    optionalCategory.LastUpdateId = User.Identity?.Name;
                    optionalCategory.LastUpdateDateTime = DateTime.Now;
                    _context.Add(optionalCategory);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError(nameof(optionalCategory.Name), $"The category ({optionalCategory.Name}) already exists in the database.");
            }
            return View(optionalCategory);
        }

        // GET: OptionalCategories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.OptionalCategories == null)
            {
                return NotFound();
            }

            var optionalCategory = await _context.OptionalCategories.FindAsync(id);
            if (optionalCategory == null)
            {
                return NotFound();
            }
            return View(optionalCategory);
        }

        // POST: OptionalCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("OptionalCategoryId,Name,Active")] OptionalCategory optionalCategory)
        {
            if (id != optionalCategory.OptionalCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (!await _context.OptionalCategories.AnyAsync(c => c.Name == optionalCategory.Name))
                {
                    try
                    {
                        optionalCategory.LastUpdateId = User.Identity?.Name;
                        optionalCategory.LastUpdateDateTime = DateTime.Now;
                        _context.Update(optionalCategory);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!OptionalCategoryExists(optionalCategory.OptionalCategoryId))
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
                ModelState.AddModelError(nameof(optionalCategory.Name), $"The category ({optionalCategory.Name}) already exists in the database.");
            }
            return View(optionalCategory);
        }

        // GET: OptionalCategories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.OptionalCategories == null)
            {
                return NotFound();
            }

            var optionalCategory = await _context.OptionalCategories
                .FirstOrDefaultAsync(m => m.OptionalCategoryId == id);
            if (optionalCategory == null)
            {
                return NotFound();
            }

            return View(optionalCategory);
        }

        // POST: OptionalCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.OptionalCategories == null)
            {
                return Problem("Entity set 'OptionalCategories' is null.");
            }
            var optionalCategory = await _context.OptionalCategories.FindAsync(id);
            if (optionalCategory != null)
            {
                _context.OptionalCategories.Remove(optionalCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OptionalCategoryExists(Guid id)
        {
          return (_context.OptionalCategories?.Any(e => e.OptionalCategoryId == id)).GetValueOrDefault();
        }
    }
}
