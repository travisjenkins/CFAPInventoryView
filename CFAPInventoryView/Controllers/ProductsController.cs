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
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
              return _context.Products != null ? 
                          View(await _context.Products.AsNoTracking()
                                                      .OrderBy(p => p.Name)
                                                      .ThenBy(p => p.PurchaseDate)
                                                      .Include(p => p.Category)
                                                      .Include(p => p.OptionalCategory)
                                                      .Include(p => p.ExcludeCategory)
                                                      .Where(p => p.Active)
                                                      .DefaultIfEmpty()
                                                      .ToListAsync()) :
                          Problem("Entity set 'Products' is null.");
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.AsNoTracking()
                                                 .Include(p => p.Category)
                                                 .Include(p => p.OptionalCategory)
                                                 .Include(p => p.ExcludeCategory)
                                                 .DefaultIfEmpty()
                                                 .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public async Task<IActionResult> Create()
        {
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context);
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description,Expires,ExpirationDate,PurchaseDate,Quantity,SafeStockLevel,Price,Barcode,CategoryId,OptionalCategoryId,ExcludeCategoryId")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.ProductId = Guid.NewGuid();
                product.Active = true;
                product.LastUpdateId = User.Identity?.Name;
                product.LastUpdateDateTime = DateTime.Now;
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context, product.CategoryId);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context, product.OptionalCategoryId);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context, product.ExcludeCategoryId);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context, product.CategoryId);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context, product.OptionalCategoryId);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context, product.ExcludeCategoryId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProductId,Name,Description,Expires,ExpirationDate,PurchaseDate,Quantity,SafeStockLevel,Price,Barcode,CategoryId,OptionalCategoryId,ExcludeCategoryId,Active")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    product.LastUpdateId = User.Identity?.Name;
                    product.LastUpdateDateTime = DateTime.Now;
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            ViewData["CategoriesSelectList"] = await SelectListBuilder.GetCategoriesSelectListAsync(_context, product.CategoryId);
            ViewData["OptionalCategoriesSelectList"] = await SelectListBuilder.GetOptionalCategoriesSelectListAsync(_context, product.OptionalCategoryId);
            ViewData["ExcludeCategoriesSelectList"] = await SelectListBuilder.GetExcludeCategoriesSelectListAsync(_context, product.ExcludeCategoryId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.AsNoTracking()
                                                 .Include(p => p.Category)
                                                 .Include(p => p.OptionalCategory)
                                                 .Include(p => p.ExcludeCategory)
                                                 .DefaultIfEmpty()
                                                 .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'Products' is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(Guid id)
        {
          return (_context.Products?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
