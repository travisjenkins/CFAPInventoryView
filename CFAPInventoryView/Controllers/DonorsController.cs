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
    public class DonorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DonorsController> _logger;

        public DonorsController(ApplicationDbContext context, ILogger<DonorsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Donors
        public async Task<IActionResult> Index()
        {   
            return _context.Donors != null ? 
                          View(await _context.Donors.AsNoTracking()
                                                    .Include(d => d.SuppliesDonated)
                                                    .ToListAsync()) :
                          Problem("Entity set 'Donors' is null.");
        }

        // GET: Donors/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Donors == null)
            {
                return NotFound();
            }

            var donor = await _context.Donors.AsNoTracking()
                                             .Include(d => d.SuppliesDonated)
                                             .FirstOrDefaultAsync(m => m.DonorId == id);
            if (donor == null)
            {
                return NotFound();
            }

            return View(donor);
        }

        // GET: Donors/Create
        public IActionResult Create()
        {
            ViewData["StatesSelectList"] = SelectListBuilder.GetStatesSelectList();
            return View();
        }

        // POST: Donors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Address1,Address2,City,State,ZipCode")] Donor donor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    donor.DonorId = Guid.NewGuid();
                    donor.State = HelperMethods.JustTheStateName(donor.State);
                    donor.LastUpdateId = User.Identity?.Name;
                    donor.LastUpdateDateTime = DateTime.Now;
                    _context.Add(donor);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "There was an issue creating the donor. If the issue continues please contact an administrator.");
            }
            
            var selectList = SelectListBuilder.GetStatesSelectList(donor.State);
            ViewData["StatesSelectList"] = selectList;
            donor.State = selectList?.FirstOrDefault(s => s.Selected)?.Value;
            return View(donor);
        }

        // GET: Donors/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Donors == null)
            {
                return NotFound();
            }

            var donor = await _context.Donors.FindAsync(id);
            if (donor == null)
            {
                return NotFound();
            }
            var selectList = SelectListBuilder.GetStatesSelectList(donor.State);
            ViewData["StatesSelectList"] = selectList;
            donor.State = selectList?.FirstOrDefault(s => s.Selected)?.Value;
            return View(donor);
        }

        // POST: Donors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("DonorId,FirstName,LastName,Address1,Address2,City,State,ZipCode")] Donor donor)
        {
            if (id != donor.DonorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    donor.State = HelperMethods.JustTheStateName(donor.State);
                    donor.LastUpdateId = User.Identity?.Name;
                    donor.LastUpdateDateTime = DateTime.Now;
                    _context.Update(donor);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex)
                {
                    if (!DonorExists(donor.DonorId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue updating the donor. If the issue continues please contact an administrator.");
                    }
                }
            }
            var selectList = SelectListBuilder.GetStatesSelectList(donor.State);
            ViewData["StatesSelectList"] = selectList;
            donor.State = selectList?.FirstOrDefault(s => s.Selected)?.Value;
            return View(donor);
        }

        // GET: Donors/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Donors == null)
            {
                return NotFound();
            }

            var donor = await _context.Donors.AsNoTracking()
                                             .Include(d => d.SuppliesDonated)
                                             .FirstOrDefaultAsync(m => m.DonorId == id);
            if (donor == null)
            {
                return NotFound();
            }

            return View(donor);
        }

        // POST: Donors/Delete/5
        [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Donors == null)
            {
                return Problem("Entity set 'Donors' is null.");
            }
            var donor = await _context.Donors.FindAsync(id);
            if (donor != null)
            {
                try
                {
                    _context.Donors.Remove(donor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex) 
                { 
                    _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}"); 
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool DonorExists(Guid id)
        {
          return (_context.Donors?.Any(e => e.DonorId == id)).GetValueOrDefault();
        }
    }
}
