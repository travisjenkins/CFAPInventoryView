using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace CFAPInventoryView.Controllers
{
    public class ShoppingListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShoppingListController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ShoppingList
        public async Task<IActionResult> Index()
        {
            return _context.CategoryBaskets != null ?
                        View(await _context.Baskets.AsNoTracking()
                                                   .Include(b => b.AgeGroup)
                                                   .Include(b => b.Ethnicity)
                                                   .Include(b => b.Gender)
                                                   .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                                   .DefaultIfEmpty()
                                                   .OrderBy(b => b.AgeGroup.Description)
                                                   .ThenBy(b => b.DateAssembled)
                                                   .ToListAsync()) :
                        Problem("Entity set 'Baskets' is null.");
        }

        // GET: ShoppingList/Detials/1
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
                                               .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                               .DefaultIfEmpty()
                                               .FirstOrDefaultAsync(b => b.BasketId == id);
            if (basket == null)
            {
                return NotFound();
            }

            return View(basket);
        }

        // GET: ShoppingList/Create
        public async Task<IActionResult> Create()
        {
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context);
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context);
            return View();
        }

        // POST: ShoppingList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // TODO: Pass in selected Id's for category, optional category, and exclude category.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("AgeGroupId,EthnicityId,GenderId,DateAssembled,Quantity,SafeStockLevel")] Basket basket)
        {
            if (ModelState.IsValid)
            {
                basket.BasketId = Guid.NewGuid();
                // TODO: Add selected categories to CategoryBasket collection
                basket.Active = true;
                basket.LastUpdateId = User.Identity?.Name;
                basket.LastUpdateDateTime = DateTime.Now;
                _context.Add(basket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context);
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context);
            return View(basket);
        }

        // GET: ShoppingList/Edit/1
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Baskets == null)
            {
                return NotFound();
            }

            var basket = await _context.Baskets.FindAsync(id);
            if (basket == null)
            {
                return NotFound();
            }
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context);
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context);
            return View(basket);
        }

        // POST: ShoppingList/Edit/1
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // TODO: Pass in selected Id's for category, optional category, and exclude category.
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
                    // TODO: Add/Delete categories in CategoryBasket collection
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
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context);
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context);
            return View(basket);
        }

        // GET: ShoppingList/Delete/1
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
                                               .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                               .DefaultIfEmpty()
                                               .FirstOrDefaultAsync(b => b.BasketId == id);
            if (basket == null)
            {
                return NotFound();
            }

            return View(basket);
        }

        // POST: ShoppingList/Delete/1
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
