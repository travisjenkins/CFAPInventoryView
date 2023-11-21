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
    public class AgeGroupsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AgeGroupsController> _logger;

        public AgeGroupsController(ApplicationDbContext context, ILogger<AgeGroupsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: AgeGroups
        public async Task<IActionResult> Index()
        {
            return _context.AgeGroups != null ?
                        View(await _context.AgeGroups.AsNoTracking().OrderBy(ag => ag.SortOrder).ToListAsync()) :
                        Problem("Entity set 'AgeGroups' is null.");
        }

        // GET: AgeGroups/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.AgeGroups == null)
            {
                return NotFound();
            }

            var ageGroup = await _context.AgeGroups.AsNoTracking()
                .FirstOrDefaultAsync(m => m.AgeGroupId == id);
            if (ageGroup == null)
            {
                return NotFound();
            }

            return View(ageGroup);
        }

        // GET: AgeGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AgeGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Description,SortOrder")] AgeGroup ageGroup)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ageGroup.AgeGroupId = Guid.NewGuid();
                    ageGroup.LastUpdateId = User.Identity?.Name;
                    ageGroup.LastUpdateDateTime = DateTime.Now;
                    _context.Add(ageGroup);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "There was an issue creating the age group.  If the issue persists, please contact an administrator.");
            }
            return View(ageGroup);
        }

        // GET: AgeGroups/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.AgeGroups == null)
            {
                return NotFound();
            }

            var ageGroup = await _context.AgeGroups.FindAsync(id);
            if (ageGroup == null)
            {
                return NotFound();
            }
            return View(ageGroup);
        }

        // POST: AgeGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("AgeGroupId,Description,SortOrder")] AgeGroup ageGroup)
        {
            if (id != ageGroup.AgeGroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ageGroup.LastUpdateId = User.Identity?.Name;
                    ageGroup.LastUpdateDateTime = DateTime.Now;
                    _context.Update(ageGroup);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex)
                {
                    if (!AgeGroupExists(ageGroup.AgeGroupId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue updating the age group.  If the issue persists, please contact an administrator.");
                    }
                }
            }
            return View(ageGroup);
        }

        // GET: AgeGroups/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.AgeGroups == null)
            {
                return NotFound();
            }

            var ageGroup = await _context.AgeGroups.AsNoTracking()
                .FirstOrDefaultAsync(m => m.AgeGroupId == id);
            if (ageGroup == null)
            {
                return NotFound();
            }

            return View(ageGroup);
        }

        // POST: AgeGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.AgeGroups == null)
            {
                return Problem("Entity set 'AgeGroups' is null.");
            }
            var ageGroup = await _context.AgeGroups.FindAsync(id);
            if (ageGroup != null)
            {
                _context.AgeGroups.Remove(ageGroup);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgeGroupExists(Guid id)
        {
          return (_context.AgeGroups?.Any(e => e.AgeGroupId == id)).GetValueOrDefault();
        }
    }
}
