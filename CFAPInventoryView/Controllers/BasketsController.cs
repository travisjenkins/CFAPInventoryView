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

namespace CFAPInventoryView.Controllers
{
    public class BasketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BasketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Baskets
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Baskets.AsNoTracking()
                                                       .Include(b => b.AgeGroup)
                                                       .Include(b => b.Ethnicity)
                                                       .Include(b => b.Gender)
                                                       .DefaultIfEmpty()
                                                       .OrderBy(b => b.AgeGroup.Description);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Baskets/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Baskets == null)
            {
                return NotFound();
            }

            var basket = await _context.Baskets.AsNoTracking()
                                               .Include(b => b.AgeGroup)
                                               .Include(b => b.Ethnicity)
                                               .Include(b => b.Gender)
                                               .DefaultIfEmpty()
                                               .FirstOrDefaultAsync(m => m.BasketId == id);

            if (basket == null)
            {
                return NotFound();
            }

            return View(basket);
        }

        // GET: Baskets/Create
        public async Task<IActionResult> Create()
        {
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context);
            return View();
        }

        // POST: Baskets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("AgeGroupId,EthnicityId,GenderId,DateAssembled,Quantity,SafeStockLevel")] Basket basket)
        {
            if (ModelState.IsValid)
            {
                basket.BasketId = Guid.NewGuid();
                basket.Active = true;
                basket.LastUpdateId = User.Identity?.Name;
                basket.LastUpdateDateTime = DateTime.Now;
                _context.Add(basket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            return View(basket);
        }

        // GET: Baskets/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Baskets == null)
            {
                return NotFound();
            }

            var basket = await _context.Baskets.Include(b => b.AgeGroup)
                                               .Include(b => b.Ethnicity)
                                               .Include(b => b.Gender)
                                               .DefaultIfEmpty()
                                               .FirstOrDefaultAsync(m => m.BasketId == id);

            if (basket == null)
            {
                return NotFound();
            }
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            return View(basket);
        }

        // POST: Baskets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("BasketId,AgeGroupId,EthnicityId,GenderId,DateAssembled,Quantity,SafeStockLevel,Active")] Basket basket)
        {
            if (id != basket.BasketId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    basket.LastUpdateId = User.Identity?.Name;
                    basket.LastUpdateDateTime = DateTime.Now;
                    _context.Update(basket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BasketExists(basket.BasketId))
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
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            return View(basket);
        }

        // GET: Baskets/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Baskets == null)
            {
                return NotFound();
            }

            var basket = await _context.Baskets.AsNoTracking()
                                               .Include(b => b.AgeGroup)
                                               .Include(b => b.Ethnicity)
                                               .Include(b => b.Gender)
                                               .DefaultIfEmpty()
                                               .FirstOrDefaultAsync(m => m.BasketId == id);

            if (basket == null)
            {
                return NotFound();
            }

            return View(basket);
        }

        // POST: Baskets/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Baskets == null)
            {
                return Problem("Entity set 'Baskets' is null.");
            }
            var basket = await _context.Baskets.FindAsync(id);
            if (basket != null)
            {
                _context.Baskets.Remove(basket);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BasketExists(Guid id)
        {
          return (_context.Baskets?.Any(e => e.BasketId == id)).GetValueOrDefault();
        }
    }
}
