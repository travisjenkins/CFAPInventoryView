﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Services;
using CFAPInventoryView.Models;
using Microsoft.CodeAnalysis;
using Microsoft.AspNetCore.Authorization;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole},{HelperMethods.MemberRole}")]
    public class IBelongBasketsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<IBelongBasketsController> _logger;

        public IBelongBasketsController(ApplicationDbContext context, ILogger<IBelongBasketsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: IBelongBaskets
        public async Task<IActionResult> Index()
        {
            return _context.ProductBaskets != null ?
                    View(await _context.Baskets.AsNoTracking()
                                                .Where(b => !b.IsShoppingListItem && b.Active)
                                                .Include(b => b.AgeGroup)
                                                .Include(b => b.Ethnicity)
                                                .Include(b => b.Gender)
                                                .Include(b => b.ProductBaskets.Where(pb => pb.Active))
                                                    .ThenInclude(pb => pb.Product)
                                                .DefaultIfEmpty()
                                                .OrderBy(b => b.AgeGroup.Description)
                                                .ThenBy(b => b.DateAssembled)
                                                .ToListAsync()) :
                    Problem("There are no iBelong Baskets in the database.");
        }

        // GET: IBelongBaskets/Details/5
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
                                                      .Include(b => b.ProductBaskets.Where(pb => pb.Active))
                                                         .ThenInclude(pb => pb.Product)
                                                      .DefaultIfEmpty()
                                                      .FirstOrDefaultAsync(b => b.BasketId == id);
            if (basket == null)
            {
                return NotFound();
            }

            return View(basket);
        }

        // GET: IBelongBaskets/Create
        public async Task<IActionResult> Create()
        {
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context);
            /*
             * Get all products from the database
             * Create a new basket and initialize the ProductBaskets property with an empty list (since the basket does not exist yet)
             */
            Basket basket = new();
            ViewData["AssignedProductsList"] = await PopulateAssignedProducts(basket);
            return View();
        }

        // POST: IBelongBaskets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("AgeGroupId,EthnicityId,GenderId,DateAssembled,Quantity,SafeStockLevel")] Basket basket, List<Guid>? assignedProducts)
        {
            if (assignedProducts is not null)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        basket.BasketId = Guid.NewGuid();
                        basket.IsShoppingListItem = false;
                        basket.Active = true;
                        basket.LastUpdateId = User.Identity?.Name;
                        basket.LastUpdateDateTime = DateTime.Now;
                        _context.Add(basket);
                        await _context.SaveChangesAsync();
                        await AddProductsToBasket(basket.BasketId, assignedProducts);
                        return RedirectToAction(nameof(Index));
                    }
                    catch (DbUpdateException ex)
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue assigning products to the basket. If the issue continues please contact an administrator.");
                    }
                }
            }
            ModelState.AddModelError(string.Empty, "You must assign at least one product to create the basket.");
            
            // Something failed. Redisplay the page with the user provided values.
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["AssignedProductsList"] = await PopulateAssignedProducts(basket);
            return View(basket);
        }

        // GET: IBelongBaskets/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Baskets == null)
            {
                return NotFound();
            }

            var basket = await _context.Baskets.Include(b => b.AgeGroup)
                                                      .Include(b => b.Ethnicity)
                                                      .Include(b => b.Gender)
                                                      .Include(b => b.ProductBaskets.Where(pb => pb.Active))
                                                      .DefaultIfEmpty()
                                                      .FirstOrDefaultAsync(b => b.BasketId == id);     
            if (basket == null)
            {
                return NotFound();
            }

            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["AssignedProductsList"] = await PopulateAssignedProducts(basket);
            return View(basket);
        }

        // POST: IBelongBaskets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("BasketId,AgeGroupId,EthnicityId,GenderId,DateAssembled,DateDistributed,Quantity,SafeStockLevel,Active")] Basket basket, List<Guid>? assignedProducts)
        {
            if (id != basket.BasketId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    basket.IsShoppingListItem = false;
                    basket.LastUpdateId = User.Identity?.Name;
                    basket.LastUpdateDateTime = DateTime.Now;
                    _context.Update(basket);

                    // 1. Get current assigned products
                    var currentAssignedProducts = await _context.ProductBaskets.Where(pb => pb.BasketId == id).ToListAsync();

                    if (assignedProducts is null)
                    {
                        await DeleteProductsFromBasket(id); // 2. If null delete all assigned
                    }
                    else
                    {
                        // 3. Get the Ids only
                        var currentAssignedProductIds = currentAssignedProducts.Select(pb => pb.ProductId).ToList();

                        // 4. Get the Ids to add
                        var productIdsToAdd = assignedProducts?.Where(id => !currentAssignedProductIds.Contains(id)).ToList();

                        // 5. Get the Ids to delete
                        var productIdsToDelete = currentAssignedProductIds.Where(id => !assignedProducts.Contains(id)).ToList();

                        // 6. Delete
                        if (productIdsToDelete?.Count > 0)
                        {
                            await DeleteProductsFromBasket(id, currentAssignedProducts, productIdsToDelete);
                        }

                        // 7. Add
                        if (productIdsToAdd?.Count > 0)
                        {
                            await AddProductsToBasket(id, productIdsToAdd);
                        }

                        // 8. If there were no products to add or remove ensure other changes are saved to the database.
                        if (productIdsToDelete?.Count is null || productIdsToDelete?.Count == 0 && productIdsToAdd?.Count is null || productIdsToAdd?.Count == 0)
                        {
                            await _context.SaveChangesAsync();
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex)
                {
                    if (!BasketExists(basket.BasketId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue assigning the products to the basket. If the issue continues please contact an administrator.");
                    }
                }
            }
            // Something failed. Redisplay the page with the user provided values.
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["AssignedProductsList"] = await PopulateAssignedProducts(basket);
            return View(basket);
        }

        // GET: IBelongBaskets/Delete/5
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
                                                      .Include(b => b.ProductBaskets.Where(pb => pb.Active))
                                                         .ThenInclude(pb => pb.Product)
                                                      .DefaultIfEmpty()
                                                      .FirstOrDefaultAsync(b => b.BasketId == id);
            if (basket == null)
            {
                return NotFound();
            }

            return View(basket);
        }

        // POST: IBelongBaskets/Delete/5
        [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Baskets == null)
            {
                return Problem("Nothing to delete.");
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

        private async Task<List<AssignedProductViewModel>> PopulateAssignedProducts(Basket basket)
        {
            List<AssignedProductViewModel> assignedProductViewModels = new();
            // Check if CategoryBaskets is null, if so create a new list (the line below is called a compound assignment statement)
            basket.ProductBaskets ??= new List<ProductBasket>();
            var allProducts = await _context.Products.AsNoTracking().Where(p => p.Active).OrderBy(p => p.Name).ToListAsync();
            if (allProducts is not null)
            {
                var productBasketProductIds = new HashSet<Guid>(basket.ProductBaskets.Select(p => p.ProductId));
                foreach (var product in allProducts)
                {
                    assignedProductViewModels.Add(new AssignedProductViewModel
                    {
                        ProductId = product.ProductId,
                        Name = product.Name,
                        Assigned = productBasketProductIds.Contains(product.ProductId)
                    });
                }
            }
            return assignedProductViewModels;
        }

        private async Task AddProductsToBasket(Guid basketId, List<Guid>? assignedProducts)
        {
            var productBaskets = await _context.ProductBaskets.Where(pb => pb.BasketId == basketId).ToListAsync();
            List<ProductBasket> productBasketsToAdd = new();
            if (assignedProducts is not null)
            {
                foreach (var productId in assignedProducts)
                {
                    var product = await _context.Products.FindAsync(productId) ?? throw new DbUpdateException("There was an issue getting the product from the database.");
                    if (!productBaskets.Any(pb => pb.ProductId == productId))
                    {
                        var productToAdd = new ProductBasket
                        {
                            ProductBasketId = Guid.NewGuid(),
                            BasketId = basketId,
                            ProductId = productId,
                            Active = true,
                            LastUpdateId = User.Identity?.Name,
                            LastUpdateDateTime = DateTime.Now
                        };
                        productBasketsToAdd.Add(productToAdd);

                        if (product.Quantity > 0)
                        {
                            product.Quantity -= 1;
                        }
                    }
                }
            }
            if (productBasketsToAdd.Count > 0)
            {
                await _context.ProductBaskets.AddRangeAsync(productBasketsToAdd);
                await _context.SaveChangesAsync();
            }
        }

        private async Task DeleteProductsFromBasket(Guid id, List<ProductBasket>? assignedProducts = null, List<Guid>? productIdsToDelete = null)
        {
            List<ProductBasket>? productBasketsToDelete = null;
            if (productIdsToDelete is null)
            {
                productBasketsToDelete = await _context.ProductBaskets.Where(pb => pb.BasketId == id).ToListAsync();
            }
            if (productIdsToDelete is not null && productIdsToDelete.Count > 0)
            {
                var basketProductIds = new HashSet<Guid>(productIdsToDelete);
                if (assignedProducts is not null)
                {
                    foreach (var productId in productIdsToDelete)
                    {
                        var product = await _context.Products.FindAsync(productId) ?? throw new DbUpdateException("There was an issue getting the product from the database.");
                        if (assignedProducts.Any(pb => pb.BasketId == id && basketProductIds.Contains(pb.ProductId)))
                        {
                            product.Quantity += 1;
                        }
                    }
                    productBasketsToDelete = assignedProducts.Where(pb => pb.BasketId == id && basketProductIds.Contains(pb.ProductId)).ToList();
                }
                else
                {
                    foreach (var productId in productIdsToDelete)
                    {
                        var product = await _context.Products.FindAsync(productId) ?? throw new DbUpdateException("There was an issue getting the product from the database.");
                        if (await _context.ProductBaskets.AnyAsync(pb => pb.BasketId == id && basketProductIds.Contains(pb.ProductId)))
                        {
                            product.Quantity += 1;
                        }
                    }
                    productBasketsToDelete = await _context.ProductBaskets.Where(pb => pb.BasketId == id && basketProductIds.Contains(pb.ProductId)).ToListAsync();
                }
            }
            if (productBasketsToDelete is not null && productBasketsToDelete.Count > 0)
            {
                _context.ProductBaskets.RemoveRange(productBasketsToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
