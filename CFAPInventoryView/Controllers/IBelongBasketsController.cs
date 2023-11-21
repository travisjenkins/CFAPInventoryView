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
        public async Task<IActionResult> Index(bool? fromBasketTransactions = null)
        {
            if (fromBasketTransactions.HasValue)
            {
                ViewData["FromBasketTransactions"] = fromBasketTransactions.Value;
            }
            return _context.SupplyBaskets != null ?
                    View(await _context.Baskets.AsNoTracking()
                                                .Where(b => !b.IsShoppingListItem)
                                                .Include(b => b.AgeGroup)
                                                .Include(b => b.Ethnicity)
                                                .Include(b => b.Gender)
                                                .Include(b => b.SupplyBaskets)
                                                    .ThenInclude(pb => pb.Supply)
                                                .DefaultIfEmpty()
#pragma warning disable 8602
                                                .OrderBy(b => b.AgeGroup.Description)
                                                .ThenBy(b => b.DateAssembled)
#pragma warning restore 8602
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
                                                      .Include(b => b.SupplyBaskets)
                                                         .ThenInclude(pb => pb.Supply)
                                                      .DefaultIfEmpty()
#pragma warning disable 8602
                                                      .FirstOrDefaultAsync(b => b.BasketId == id);
#pragma warning restore 8602
            if (basket == null)
            {
                return NotFound();
            }

            return View(basket);
        }

        // GET: IBelongBaskets/Create
        public async Task<IActionResult> Create(Guid? AgeGroupId)
        {
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context);
            /*
             * Get all products from the database
             * Create a new basket and initialize the ProductBaskets property with an empty list (since the basket does not exist yet)
             */
            Basket basket = new();
            ViewData["AssignedProductsList"] = await PopulateAssignedProducts(basket, AgeGroupId);
            return View();
        }

        // POST: IBelongBaskets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("BasketNumber,AgeGroupId,EthnicityId,GenderId,DateAssembled")] Basket basket, List<Guid>? assignedProducts)
        {
            if (assignedProducts is not null)
            {
                var shoppingList = await _context.Baskets.FirstOrDefaultAsync(b => b.IsShoppingListItem && b.AgeGroupId == basket.AgeGroupId && b.EthnicityId == basket.EthnicityId && b.GenderId == basket.GenderId);
                if (shoppingList is not null)
                {
                    if (ModelState.IsValid)
                    {
                        if (basket.BasketNumber.HasValue)
                        {
                            try
                            {
                                basket.BasketId = Guid.NewGuid();
                                basket.IsShoppingListItem = false;
                                basket.LastUpdateId = User.Identity?.Name;
                                basket.LastUpdateDateTime = DateTime.Now;
                                _context.Add(basket);
                                shoppingList.Quantity += 1;
                                _context.Update(shoppingList);
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
                        ModelState.AddModelError(nameof(Basket.BasketNumber), "The basket number field is required.");
                    }
                }
                ModelState.AddModelError(string.Empty, "An iBelong Basket shopping list item could not be found for this basket type.  Please create it first before creating the iBelong Basket for proper inventory level adjustment.");
            }
            ModelState.AddModelError(string.Empty, "You must assign at least one product to create the basket.");
            
            // Something failed. Redisplay the page with the user provided values.
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["AssignedProductsList"] = await PopulateAssignedProducts(basket, basket.AgeGroupId);
            return View(basket);
        }

        // GET: IBelongBaskets/Edit/5
        public async Task<IActionResult> Edit(Guid? id, Guid? AgeGroupId)
        {
            if (id == null || _context.Baskets == null)
            {
                return NotFound();
            }

            var basket = await _context.Baskets.Include(b => b.AgeGroup)
                                                      .Include(b => b.Ethnicity)
                                                      .Include(b => b.Gender)
                                                      .Include(b => b.SupplyBaskets)
                                                      .DefaultIfEmpty()
#pragma warning disable 8602
                                                      .FirstOrDefaultAsync(b => b.BasketId == id);
#pragma warning restore 8602
            if (basket == null)
            {
                return NotFound();
            }

            
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);

            if (AgeGroupId.HasValue)
            {
                ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, AgeGroupId);
                ViewData["AssignedProductsList"] = await PopulateAssignedProducts(basket, AgeGroupId);
            }
            else
            {
                ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
                ViewData["AssignedProductsList"] = await PopulateAssignedProducts(basket, basket.AgeGroupId);
            }
            
            return View(basket);
        }

        // POST: IBelongBaskets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("BasketId,BasketNumber,AgeGroupId,EthnicityId,GenderId,DateAssembled")] Basket basket, List<Guid>? assignedProducts)
        {
            if (id != basket.BasketId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (basket.BasketNumber.HasValue)
                {
                    try
                    {
                        basket.IsShoppingListItem = false;
                        basket.LastUpdateId = User.Identity?.Name;
                        basket.LastUpdateDateTime = DateTime.Now;
                        _context.Update(basket);

                        // 1. Get current assigned products
                        var currentAssignedProducts = await _context.SupplyBaskets.Where(pb => pb.BasketId == id).ToListAsync();

                        if (assignedProducts is null)
                        {
                            await DeleteProductsFromBasket(id); // 2. If null delete all assigned
                        }
                        else
                        {
                            // 3. Get the Ids only
                            var currentAssignedProductIds = currentAssignedProducts.Select(pb => pb.SupplyId).ToList();

                            // 4. Get the Ids to add
                            var productIdsToAdd = assignedProducts?.Where(id => !currentAssignedProductIds.Contains(id)).ToList();

                            // 5. Get the Ids to delete
#pragma warning disable 8602
                            var productIdsToDelete = currentAssignedProductIds.Where(id => !assignedProducts.Contains(id)).ToList();
#pragma warning restore 8602
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
                ModelState.AddModelError(nameof(Basket.BasketNumber), "The basket number field is required.");
            }
            // Something failed. Redisplay the page with the user provided values.
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["AssignedProductsList"] = await PopulateAssignedProducts(basket, basket.AgeGroupId);
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
#pragma warning disable 8604
                                                      .Include(b => b.SupplyBaskets)
                                                         .ThenInclude(pb => pb.Supply)
#pragma warning restore 8604
                                                      .DefaultIfEmpty()
#pragma warning disable 8602
                                                      .FirstOrDefaultAsync(b => b.BasketId == id);
#pragma warning restore 8602
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
            var basket = await _context.Baskets.Include(b => b.AgeGroup)
                                               .Include(b => b.Ethnicity)
                                               .Include(b => b.Gender)
#pragma warning disable 8604
                                               .Include(b => b.SupplyBaskets)
                                                   .ThenInclude(pb => pb.Supply)
#pragma warning restore 8604
                                               .DefaultIfEmpty()
#pragma warning disable 8602
                                               .FirstOrDefaultAsync(b => b.BasketId == id);
            if (basket != null)
            {
                try
                {
                    var shoppingList = await _context.Baskets.FirstOrDefaultAsync(b => b.IsShoppingListItem && b.AgeGroupId == basket.AgeGroupId && b.EthnicityId == basket.EthnicityId && b.GenderId == basket.GenderId);
                    if (shoppingList != null)
                    {
                        if (shoppingList.Quantity > 0)
                        {
                            shoppingList.Quantity -= 1;
                            _context.Update(shoppingList);
                        }
                        _context.Baskets.Remove(basket);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  No associated shopping list for basketId {basket.BasketId}.");
                        ModelState.AddModelError(string.Empty, "An iBelong Basket shopping list item could not be found for this basket type. Please contact an administrator.");
                    }
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                    ModelState.AddModelError(string.Empty, "There was an issue deleting the basket. If the issue continues please contact an administrator.");
                }
                return View(basket);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool BasketExists(Guid id)
        {
          return (_context.Baskets?.Any(e => e.BasketId == id)).GetValueOrDefault();
        }

        private async Task<List<AssignedSupplyViewModel>> PopulateAssignedProducts(Basket basket, Guid? selectedAgeGroupId = null)
        {
            List<AssignedSupplyViewModel> assignedSupplyViewModels = new();
            basket.SupplyBaskets ??= new List<SupplyBasket>();
            // Get all categories that apply to the selected age group.
            List<Category> allCategories = await HelperMethods.GetCategoriesForAgeGroup(_context, selectedAgeGroupId);
            var categoryIds = new HashSet<Guid>(allCategories.Select(c => c.CategoryId));
            List<OptionalCategory> allOptionalCategories = await HelperMethods.GetOptionalCategoriesForAgeGroup(_context, selectedAgeGroupId);
            var optionalCategoryIds = new HashSet<Guid>(allOptionalCategories.Select(c => c.OptionalCategoryId));
            // Get all products that have a quantity greater than 0 and are assigned to one of the categories that apply to the slected age group.
            var availableSupplies = await _context.Supplies.AsNoTracking()
                .Where(p => p.Quantity > 0 && p.CategoryId != null && categoryIds.Contains((Guid)p.CategoryId) ||
                            p.Quantity > 0 && p.OptionalCategoryId != null && optionalCategoryIds.Contains((Guid)p.OptionalCategoryId))
                .OrderBy(p => p.Name)
                .ToListAsync();
            if (availableSupplies is not null && availableSupplies.Count > 0)
            {
                var supplyIds = new HashSet<Guid>(basket.SupplyBaskets.Select(p => p.SupplyId));
                foreach (var product in availableSupplies)
                {
                    assignedSupplyViewModels.Add(new AssignedSupplyViewModel
                    {
                        SupplyId = product.SupplyId,
                        Name = product.Name,
                        Assigned = supplyIds.Contains(product.SupplyId)
                    });
                }
            }
            return assignedSupplyViewModels;
        }

        private async Task AddProductsToBasket(Guid basketId, List<Guid> assignedProducts)
        {
            var productBaskets = await _context.SupplyBaskets.Where(pb => pb.BasketId == basketId).ToListAsync();
            List<SupplyBasket> productBasketsToAdd = new();
            foreach (var productId in assignedProducts)
            {
                if (!productBaskets.Any(pb => pb.SupplyId == productId))
                {
                    try
                    {
                        var product = await _context.Supplies.FindAsync(productId) ?? throw new DbUpdateException($"A product could not be found in the database with ID {productId}");
                        await HelperMethods.DecreaseAssignedCategoryQuantityByOne(_context, product);
                    }
                    catch (DbUpdateException ex)
                    {
                        _logger.LogError($"ERROR: {ex.Message}, StackTrace: {ex.StackTrace}");
                        throw new DbUpdateException("There was an issue updating the product category's quantity.", ex);
                    }
                    var productToAdd = new SupplyBasket
                    {
                        SupplyBasketId = Guid.NewGuid(),
                        BasketId = basketId,
                        SupplyId = productId,
                        LastUpdateId = User.Identity?.Name,
                        LastUpdateDateTime = DateTime.Now
                    };
                    productBasketsToAdd.Add(productToAdd);
                }
            }
            if (productBasketsToAdd.Count > 0)
            {
                await _context.SupplyBaskets.AddRangeAsync(productBasketsToAdd);
                await _context.SaveChangesAsync();
            }
        }

        private async Task DeleteProductsFromBasket(Guid id, List<SupplyBasket>? assignedProducts = null, List<Guid>? productIdsToDelete = null)
        {
            List<SupplyBasket>? productBasketsToDelete = null;
            // 1. Delete all
            if (productIdsToDelete is null)
            {
                productBasketsToDelete = await _context.SupplyBaskets.Where(pb => pb.BasketId == id).ToListAsync();
            }
            // 2. Delete unselected
            if (productIdsToDelete is not null && productIdsToDelete.Count > 0)
            {
                var basketProductIds = new HashSet<Guid>(productIdsToDelete);
                if (assignedProducts is not null)
                {
                    foreach (var productId in productIdsToDelete)
                    {
                        var product = await _context.Supplies.FindAsync(productId) ?? throw new DbUpdateException("There was an issue getting the product from the database.");
                        if (assignedProducts.Any(pb => pb.BasketId == id && basketProductIds.Contains(pb.SupplyId)))
                        {
                            try
                            {
                                await HelperMethods.IncreaseAssignedCategoryQuantityByOne(_context, product);
                            }
                            catch (DbUpdateException ex)
                            {
                                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                                throw new DbUpdateException("There was an issue adding the product category quantity back while removing the product from the basket.");
                            }
                        }
                    }
                    productBasketsToDelete = assignedProducts.Where(pb => pb.BasketId == id && basketProductIds.Contains(pb.SupplyId)).ToList();
                }
                else
                {
                    foreach (var productId in productIdsToDelete)
                    {
                        var product = await _context.Supplies.FindAsync(productId) ?? throw new DbUpdateException("There was an issue getting the product from the database.");
                        if (await _context.SupplyBaskets.AnyAsync(pb => pb.BasketId == id && basketProductIds.Contains(pb.SupplyId)))
                        {
                            try
                            {
                                await HelperMethods.IncreaseAssignedCategoryQuantityByOne(_context, product);
                            }
                            catch (DbUpdateException ex)
                            {
                                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                                throw new DbUpdateException("There was an issue adding the product category quantity back while removing the product from the basket.");
                            }
                        }
                    }
                    productBasketsToDelete = await _context.SupplyBaskets.Where(pb => pb.BasketId == id && basketProductIds.Contains(pb.SupplyId)).ToListAsync();
                }
            }
            if (productBasketsToDelete is not null && productBasketsToDelete.Count > 0)
            {
                _context.SupplyBaskets.RemoveRange(productBasketsToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
