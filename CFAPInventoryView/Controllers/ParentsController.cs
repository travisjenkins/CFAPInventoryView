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
    public class ParentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Parents
        public async Task<IActionResult> Index()
        {
              return _context.Parents != null ? 
                          View(await _context.Parents.AsNoTracking()
                                                    .Include(d => d.ProductTransactions)
                                                        .ThenInclude(pt => pt.Product)
                                                    .Include(d => d.BasketTransactions)
                                                        .ThenInclude(bt => bt.Basket)
                                                    .DefaultIfEmpty()
                                                    .ToListAsync()) :
                          Problem("Entity set 'Parents' is null.");
        }

        // GET: Parents/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Parents == null)
            {
                return NotFound();
            }

            var parents = await _context.Parents.AsNoTracking()
                                                 .Include(d => d.ProductTransactions)
                                                    .ThenInclude(pt => pt.Product)
                                                 .Include(d => d.BasketTransactions)
                                                    .ThenInclude(bt => bt.Basket)
                                                 .DefaultIfEmpty()
                                                 .FirstOrDefaultAsync(m => m.ParentId == id);
            if (parents == null)
            {
                return NotFound();
            }

            return View(parents);
        }

        // GET: Parents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Address1,Address2,City,State,ZipCode,IsFosterParent,IsAdoptiveParent")] Parent parent)
        {
            if (ModelState.IsValid)
            {
                parent.ParentId = Guid.NewGuid();
                _context.Add(parent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parent);
        }

        // GET: Parents/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Parents == null)
            {
                return NotFound();
            }

            var parent = await _context.Parents.FindAsync(id);
            if (parent == null)
            {
                return NotFound();
            }
            return View(parent);
        }

        // POST: Parents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ParentId,FirstName,LastName,Address1,Address2,City,State,ZipCode,IsFosterParent,IsAdoptiveParent")] Parent parent)
        {
            if (id != parent.ParentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParentExists(parent.ParentId))
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
            return View(parent);
        }

        // GET: Parents/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Parents == null)
            {
                return NotFound();
            }

            var parent = await _context.Parents.AsNoTracking()
                                             .Include(d => d.ProductTransactions)
                                                .ThenInclude(pt => pt.Product)
                                             .Include(d => d.BasketTransactions)
                                                .ThenInclude(bt => bt.Basket)
                                             .DefaultIfEmpty()
                                             .FirstOrDefaultAsync(m => m.ParentId == id);
            if (parent == null)
            {
                return NotFound();
            }

            return View(parent);
        }

        // POST: Parents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Parents == null)
            {
                return Problem("Entity set 'Parents' is null.");
            }
            var parent = await _context.Parents.FindAsync(id);
            if (parent != null)
            {
                _context.Parents.Remove(parent);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParentExists(Guid id)
        {
          return (_context.Parents?.Any(e => e.ParentId == id)).GetValueOrDefault();
        }
    }
}
