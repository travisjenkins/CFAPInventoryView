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
using NUglify.Helpers;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
    public class StorageLocationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<StorageLocationsController> _logger;

        public StorageLocationsController(ApplicationDbContext context, ILogger<StorageLocationsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: StorageLocations
        public async Task<IActionResult> Index()
        {
              return _context.StorageLocations != null ? 
                          View(await _context.StorageLocations.AsNoTracking().OrderBy(s => s.Name).ToListAsync()) :
                          Problem("Entity set 'StorageLocations' is null.");
        }

        // GET: StorageLocations/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.StorageLocations == null)
            {
                return NotFound();
            }

            var storageLocation = await _context.StorageLocations.AsNoTracking()
                .FirstOrDefaultAsync(m => m.StorageLocationId == id);
            if (storageLocation == null)
            {
                return NotFound();
            }

            return View(storageLocation);
        }

        // GET: StorageLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StorageLocations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Shelf,Row,Column")] StorageLocation storageLocation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    storageLocation.StorageLocationId = Guid.NewGuid();
                    storageLocation.LastUpdateId = User.Identity?.Name;
                    storageLocation.LastUpdateDateTime = DateTime.Now;
                    _context.Add(storageLocation);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "There was an issue creating the storage location. If the issue continues please contact an administrator.");
            }
            return View(storageLocation);
        }

        // GET: StorageLocations/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.StorageLocations == null)
            {
                return NotFound();
            }

            var storageLocation = await _context.StorageLocations.FindAsync(id);
            if (storageLocation == null)
            {
                return NotFound();
            }
            return View(storageLocation);
        }

        // POST: StorageLocations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("StorageLocationId,Name,Shelf,Row,Column")] StorageLocation storageLocation)
        {
            if (id != storageLocation.StorageLocationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    storageLocation.LastUpdateId = User.Identity?.Name;
                    storageLocation.LastUpdateDateTime = DateTime.Now;
                    _context.Update(storageLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    if (!StorageLocationExists(storageLocation.StorageLocationId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue updating the storage location. If the issue continues please contact an administrator.");
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(storageLocation);
        }

        // GET: StorageLocations/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.StorageLocations == null)
            {
                return NotFound();
            }

            var storageLocation = await _context.StorageLocations.AsNoTracking()
                .FirstOrDefaultAsync(m => m.StorageLocationId == id);
            if (storageLocation == null)
            {
                return NotFound();
            }

            return View(storageLocation);
        }

        // POST: StorageLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.StorageLocations == null)
            {
                return Problem("Entity set 'StorageLocations' is null.");
            }
            var storageLocation = await _context.StorageLocations.FindAsync(id);
            if (storageLocation != null)
            {
                try
                {
                    _context.StorageLocations.Remove(storageLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool StorageLocationExists(Guid id)
        {
          return (_context.StorageLocations?.Any(e => e.StorageLocationId == id)).GetValueOrDefault();
        }
    }
}
