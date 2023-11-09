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
    public class EthnicitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EthnicitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ethnicities
        public async Task<IActionResult> Index()
        {
              return _context.Ethnicities != null ? 
                          View(await _context.Ethnicities.AsNoTracking().OrderBy(e => e.Description).ToListAsync()) :
                          Problem("Entity set 'Ethnicities' is null.");
        }

        // GET: Ethnicities/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Ethnicities == null)
            {
                return NotFound();
            }

            var ethnicity = await _context.Ethnicities
                .FirstOrDefaultAsync(m => m.EthnicityId == id);
            if (ethnicity == null)
            {
                return NotFound();
            }

            return View(ethnicity);
        }

        // GET: Ethnicities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ethnicities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Description")] Ethnicity ethnicity)
        {
            if (ModelState.IsValid)
            {
                ethnicity.EthnicityId = Guid.NewGuid();
                ethnicity.Active = true;
                ethnicity.LastUpdateId = User.Identity?.Name;
                ethnicity.LastUpdateDateTime = DateTime.Now;
                _context.Add(ethnicity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ethnicity);
        }

        // GET: Ethnicities/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Ethnicities == null)
            {
                return NotFound();
            }

            var ethnicity = await _context.Ethnicities.FindAsync(id);
            if (ethnicity == null)
            {
                return NotFound();
            }
            return View(ethnicity);
        }

        // POST: Ethnicities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("EthnicityId,Description,Active")] Ethnicity ethnicity)
        {
            if (id != ethnicity.EthnicityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ethnicity.LastUpdateId = User.Identity?.Name;
                    ethnicity.LastUpdateDateTime = DateTime.Now;
                    _context.Update(ethnicity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EthnicityExists(ethnicity.EthnicityId))
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
            return View(ethnicity);
        }

        // GET: Ethnicities/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Ethnicities == null)
            {
                return NotFound();
            }

            var ethnicity = await _context.Ethnicities
                .FirstOrDefaultAsync(m => m.EthnicityId == id);
            if (ethnicity == null)
            {
                return NotFound();
            }

            return View(ethnicity);
        }

        // POST: Ethnicities/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Ethnicities == null)
            {
                return Problem("Entity set 'Ethnicities' is null.");
            }
            var ethnicity = await _context.Ethnicities.FindAsync(id);
            if (ethnicity != null)
            {
                _context.Ethnicities.Remove(ethnicity);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EthnicityExists(Guid id)
        {
          return (_context.Ethnicities?.Any(e => e.EthnicityId == id)).GetValueOrDefault();
        }
    }
}
