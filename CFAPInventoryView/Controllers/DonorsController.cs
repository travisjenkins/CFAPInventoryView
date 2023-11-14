using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;

namespace CFAPInventoryView.Controllers
{
    public class DonorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DonorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Donors
        public async Task<IActionResult> Index()
        {   
            return _context.Donors != null ? 
                          View(await _context.Donors.AsNoTracking()
                                                    .Include(d => d.ProductTransactions)
                                                        .ThenInclude(pt => pt.Product)
                                                    .Include(d => d.BasketTransactions)
                                                        .ThenInclude(bt => bt.Basket)
                                                    .DefaultIfEmpty()
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
                                             .Include(d => d.ProductTransactions)
                                                .ThenInclude(pt => pt.Product)
                                             .Include(d => d.BasketTransactions)
                                                .ThenInclude(bt => bt.Basket)
                                             .DefaultIfEmpty()
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
            return View();
        }

        // POST: Donors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Address1,Address2,City,State,ZipCode")] Donor donor)
        {
            if (ModelState.IsValid)
            {
                donor.DonorId = Guid.NewGuid();
                _context.Add(donor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
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
                    _context.Update(donor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonorExists(donor.DonorId))
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
                                             .Include(d => d.ProductTransactions)
                                                .ThenInclude(pt => pt.Product)
                                             .Include(d => d.BasketTransactions)
                                                .ThenInclude(bt => bt.Basket)
                                             .DefaultIfEmpty()
                                             .FirstOrDefaultAsync(m => m.DonorId == id);
            if (donor == null)
            {
                return NotFound();
            }

            return View(donor);
        }

        // POST: Donors/Delete/5
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
                _context.Donors.Remove(donor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonorExists(Guid id)
        {
          return (_context.Donors?.Any(e => e.DonorId == id)).GetValueOrDefault();
        }
    }
}
