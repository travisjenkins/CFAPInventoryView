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
    public class GendersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<GendersController> _logger;

        public GendersController(ApplicationDbContext context, ILogger<GendersController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Genders
        public async Task<IActionResult> Index()
        {
            return _context.Genders != null ?
                        View(await _context.Genders.AsNoTracking().OrderBy(g => g.Description).ToListAsync()) :
                        Problem("Entity set 'Genders' is null.");
        }

        // GET: Genders/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Genders == null)
            {
                return NotFound();
            }

            var gender = await _context.Genders.AsNoTracking()
                .FirstOrDefaultAsync(m => m.GenderId == id);
            if (gender == null)
            {
                return NotFound();
            }

            return View(gender);
        }

        // GET: Genders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Description")] Gender gender)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gender.GenderId = Guid.NewGuid();
                    gender.LastUpdateId = User.Identity?.Name;
                    gender.LastUpdateDateTime = DateTime.Now;
                    _context.Add(gender);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "There was an issue creating the gender. If the issue continues please contact an administrator.");
            }
            
            return View(gender);
        }

        // GET: Genders/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Genders == null)
            {
                return NotFound();
            }

            var gender = await _context.Genders.FindAsync(id);
            if (gender == null)
            {
                return NotFound();
            }
            return View(gender);
        }

        // POST: Genders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("GenderId,Description")] Gender gender)
        {
            if (id != gender.GenderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    gender.LastUpdateId = User.Identity?.Name;
                    gender.LastUpdateDateTime = DateTime.Now;
                    _context.Update(gender);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    if (!GenderExists(gender.GenderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue updating the gender. If the issue continues please contact an administrator.");
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(gender);
        }

        // GET: Genders/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Genders == null)
            {
                return NotFound();
            }

            var gender = await _context.Genders.AsNoTracking()
                .FirstOrDefaultAsync(m => m.GenderId == id);
            if (gender == null)
            {
                return NotFound();
            }

            return View(gender);
        }

        // POST: Genders/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Genders == null)
            {
                return Problem("Entity set 'Genders' is null.");
            }
            var gender = await _context.Genders.FindAsync(id);
            if (gender != null)
            {
                try
                {
                    _context.Genders.Remove(gender);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex) 
                { 
                    _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}"); 
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool GenderExists(Guid id)
        {
          return (_context.Genders?.Any(e => e.GenderId == id)).GetValueOrDefault();
        }
    }
}
