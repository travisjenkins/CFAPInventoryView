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
                                                .Where(b => !b.IsShoppingListItem && b.Active)
                                                .Include(b => b.StorageLocation)
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
                                                      .Include(b => b.StorageLocation)
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
            ViewData["StorageLocationsSelectList"] = await SelectListBuilder.GetStorageLocationsSelectListAsync(_context);
            /*
             * Get all products from the database
             * Create a new basket and initialize the ProductBaskets property with an empty list (since the basket does not exist yet)
             */
            Basket basket = new();
            ViewData["AssignedProductsList"] = await PopulateAssignedSupplies(basket, AgeGroupId);
            return View();
        }

        // POST: IBelongBaskets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("BasketNumber,AgeGroupId,EthnicityId,GenderId,DateAssembled,StorageLocationId")] Basket basket, List<Guid>? assignedSupplies)
        {
            if (!basket.BasketNumber.HasValue)
                ModelState.AddModelError(nameof(Basket.BasketNumber), "The basket number field is required.");
            else if (!basket.StorageLocationId.HasValue)
                ModelState.AddModelError(nameof(Basket.StorageLocationId), "The storage location field is required.");
            else if (assignedSupplies is null || assignedSupplies.Count == 0)
                ModelState.AddModelError(nameof(Basket.SupplyBaskets), "You must assign at least one supply to create the basket.");
            else
            {
                if (ModelState.IsValid)
                {
                    var shoppingList = await _context.Baskets.FirstAsync(b => b.IsShoppingListItem && b.AgeGroupId == basket.AgeGroupId && b.EthnicityId == basket.EthnicityId && b.GenderId == basket.GenderId);
                    if (shoppingList is not null)
                    {
                        try
                        {
                            basket.BasketId = Guid.NewGuid();
                            //basket.IsShoppingListItem = false;
                            basket.LastUpdateId = User.Identity?.Name;
                            basket.LastUpdateDateTime = DateTime.Now;
                            _context.Add(basket);
                            shoppingList.Quantity += 1;
                            _context.Update(shoppingList);
                            await _context.SaveChangesAsync();
                            await AddSuppliesToBasket(basket.BasketId, assignedSupplies);
                            return RedirectToAction(nameof(Index));
                        }
                        catch (DbUpdateException ex)
                        {
                            _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                            ModelState.AddModelError(string.Empty, "There was an issue assigning supplies to the basket. If the issue continues please contact an administrator.");
                        }
                    }
                    ModelState.AddModelError(string.Empty, "An iBelong Basket shopping list item could not be found for this basket type.  Please create it first before creating the iBelong Basket for proper inventory level adjustment.");
                }
            }
            // Something failed. Redisplay the page with the user provided values.
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["StorageLocationsSelectList"] = await SelectListBuilder.GetStorageLocationsSelectListAsync(_context, basket.StorageLocationId);
            ViewData["AssignedProductsList"] = await PopulateAssignedSupplies(basket, basket.AgeGroupId);
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
                                                      .Include(b => b.StorageLocation)
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
            ViewData["StorageLocationsSelectList"] = await SelectListBuilder.GetStorageLocationsSelectListAsync(_context, basket.StorageLocationId);

            if (AgeGroupId.HasValue)
            {
                ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, AgeGroupId);
                ViewData["AssignedProductsList"] = await PopulateAssignedSupplies(basket, AgeGroupId);
            }
            else
            {
                ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
                ViewData["AssignedProductsList"] = await PopulateAssignedSupplies(basket, basket.AgeGroupId);
            }
            
            return View(basket);
        }

        // POST: IBelongBaskets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("BasketId,BasketNumber,AgeGroupId,EthnicityId,GenderId,DateAssembled,StorageLocationId")] Basket basket, List<Guid>? assignedSupplies)
        {
            if (id != basket.BasketId)
            {
                return NotFound();
            }

            if (!basket.BasketNumber.HasValue)
                ModelState.AddModelError(nameof(Basket.BasketNumber), "The basket number field is required.");
            else if (!basket.StorageLocationId.HasValue)
                ModelState.AddModelError(nameof(Basket.StorageLocationId), "The storage location field is required.");
            else if (assignedSupplies is null || assignedSupplies.Count == 0)
                ModelState.AddModelError(nameof(Basket.SupplyBaskets), "You must assign at least one supply to update the basket.");
            else
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        //basket.IsShoppingListItem = false;
                        basket.LastUpdateId = User.Identity?.Name;
                        basket.LastUpdateDateTime = DateTime.Now;
                        _context.Update(basket);

                        // 1. Get current assigned products
                        var currentAssignedSupplies = await _context.SupplyBaskets.Where(pb => pb.BasketId == id).ToListAsync();

                        if (assignedSupplies is null)
                        {
                            await DeleteSuppliesFromBasket(id); // 2. If null delete all assigned
                        }
                        else
                        {
                            // 3. Get the Ids only
                            var currentAssignedSupplyIds = currentAssignedSupplies.Select(pb => pb.SupplyId).ToList();

                            // 4. Get the Ids to add
                            var supplyIdsToAdd = assignedSupplies?.Where(id => !currentAssignedSupplyIds.Contains(id)).ToList();

                            // 5. Get the Ids to delete
#pragma warning disable 8602
                            var supplyIdsToDelete = currentAssignedSupplyIds.Where(id => !assignedSupplies.Contains(id)).ToList();
#pragma warning restore 8602
                            // 6. Delete
                            if (supplyIdsToDelete?.Count > 0)
                            {
                                await DeleteSuppliesFromBasket(id, currentAssignedSupplies, supplyIdsToDelete);
                            }

                            // 7. Add
                            if (supplyIdsToAdd?.Count > 0)
                            {
                                await AddSuppliesToBasket(id, supplyIdsToAdd);
                            }

                            // 8. If there were no products to add or remove ensure other changes are saved to the database.
                            if (supplyIdsToDelete?.Count is null || supplyIdsToDelete?.Count == 0 && supplyIdsToAdd?.Count is null || supplyIdsToAdd?.Count == 0)
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
            }
            // Something failed. Redisplay the page with the user provided values.
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["StorageLocationsSelectList"] = await SelectListBuilder.GetStorageLocationsSelectListAsync(_context, basket.StorageLocationId);
            ViewData["AssignedProductsList"] = await PopulateAssignedSupplies(basket, basket.AgeGroupId);
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
                                                      .Include(b => b.StorageLocation)
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
            var basket = await _context.Baskets.Include(b => b.StorageLocation)
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

        private async Task<List<AssignedSupplyViewModel>> PopulateAssignedSupplies(Basket basket, Guid? selectedAgeGroupId = null)
        {
            List<AssignedSupplyViewModel> assignedSupplyViewModels = new();
            basket.SupplyBaskets ??= new List<SupplyBasket>();
            List<Supply>? allSupplies = await HelperMethods.GetAllAvailableSupplies(_context, selectedAgeGroupId);
            // Show all currently assigned supplies and all other supplies that aren't expired and are in a category with a quantity available greater than 0
            if (allSupplies is not null && allSupplies.Count > 0)
            {
                List<Supply> suppliesToDisplay = new();
                foreach (var supply in allSupplies)
                {
                    // Make sure the supply is not expiring in the next 7 days.
                    if (!supply.Expires || supply.ExpirationDate > DateTime.Now.AddDays(7))
                    {
                        // If there are no supplies assigned to the basket, or if there are supplies assigned,
                        // but the supply is not assigned to the basket, check the category's available quantity before adding.
                        if (basket.SupplyBaskets.Count == 0 || basket.SupplyBaskets.Count > 0 && !basket.SupplyBaskets.Where(sb => sb.SupplyId == supply.SupplyId).Any())
                        {
                            if (supply.CategoryId is not null)
                            {
                                var category = await _context.Categories.FindAsync(supply.CategoryId);
                                if (category is not null && category.Quantity > 0)
                                {
                                    suppliesToDisplay.Add(supply);
                                }
                            }
                            if (supply.OptionalCategoryId is not null)
                            {
                                var optionalCategory = await _context.OptionalCategories.FindAsync(supply.OptionalCategoryId);
                                if (optionalCategory is not null && optionalCategory.Quantity > 0)
                                {
                                    suppliesToDisplay.Add(supply);
                                }
                            }
                        }
                        // If the supply is already added to the basket, go ahead and add it for display
                        else
                        {
                            suppliesToDisplay.Add(supply);
                        }
                    }
                }
                if (suppliesToDisplay.Count > 0)
                {
                    var supplyIds = new HashSet<Guid>(basket.SupplyBaskets.Select(p => p.SupplyId));
                    foreach (var supply in suppliesToDisplay)
                    {
                        assignedSupplyViewModels.Add(new AssignedSupplyViewModel
                        {
                            SupplyId = supply.SupplyId,
                            Name = supply.Name,
                            Assigned = supplyIds.Contains(supply.SupplyId)
                        });
                    }
                }
            }
            return assignedSupplyViewModels;
        }

        private async Task AddSuppliesToBasket(Guid basketId, List<Guid> assignedSupplies)
        {
            var supplyBaskets = await _context.SupplyBaskets.Where(pb => pb.BasketId == basketId).ToListAsync();
            List<SupplyBasket> supplyBasketsToAdd = new();
            foreach (var supplyId in assignedSupplies)
            {
                if (!supplyBaskets.Any(pb => pb.SupplyId == supplyId))
                {
                    try
                    {
                        var supply = await _context.Supplies.FindAsync(supplyId) ?? throw new DbUpdateException($"A supply could not be found in the database with ID {supplyId}");
                        await HelperMethods.DecreaseAssignedCategoryQuantityByOne(_context, supply);
                    }
                    catch (DbUpdateException ex)
                    {
                        _logger.LogError($"ERROR: {ex.Message}, StackTrace: {ex.StackTrace}");
                        throw new DbUpdateException("There was an issue updating the supply category's quantity.", ex);
                    }
                    var suppliesToAdd = new SupplyBasket
                    {
                        SupplyBasketId = Guid.NewGuid(),
                        BasketId = basketId,
                        SupplyId = supplyId,
                        LastUpdateId = User.Identity?.Name,
                        LastUpdateDateTime = DateTime.Now
                    };
                    supplyBasketsToAdd.Add(suppliesToAdd);
                }
            }
            if (supplyBasketsToAdd.Count > 0)
            {
                await _context.SupplyBaskets.AddRangeAsync(supplyBasketsToAdd);
                await _context.SaveChangesAsync();
            }
        }

        private async Task DeleteSuppliesFromBasket(Guid id, List<SupplyBasket>? assignedSupplies = null, List<Guid>? supplyIdsToDelete = null)
        {
            List<SupplyBasket>? supplyBasketsToDelete = null;
            // 1. Delete all
            if (supplyIdsToDelete is null)
            {
                supplyBasketsToDelete = await _context.SupplyBaskets.Where(pb => pb.BasketId == id).ToListAsync();
            }
            // 2. Delete unselected
            if (supplyIdsToDelete is not null && supplyIdsToDelete.Count > 0)
            {
                var basketSupplyIds = new HashSet<Guid>(supplyIdsToDelete);
                if (assignedSupplies is not null)
                {
                    foreach (var supplyId in supplyIdsToDelete)
                    {
                        var supply = await _context.Supplies.FindAsync(supplyId) ?? throw new DbUpdateException("There was an issue getting the supply from the database.");
                        if (assignedSupplies.Any(pb => pb.BasketId == id && basketSupplyIds.Contains(pb.SupplyId)))
                        {
                            try
                            {
                                await HelperMethods.IncreaseAssignedCategoryQuantityByOne(_context, supply);
                            }
                            catch (DbUpdateException ex)
                            {
                                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                                throw new DbUpdateException("There was an issue adding the supply category quantity back while removing the supply from the basket.");
                            }
                        }
                    }
                    supplyBasketsToDelete = assignedSupplies.Where(pb => pb.BasketId == id && basketSupplyIds.Contains(pb.SupplyId)).ToList();
                }
                else
                {
                    foreach (var supplyId in supplyIdsToDelete)
                    {
                        var supply = await _context.Supplies.FindAsync(supplyId) ?? throw new DbUpdateException("There was an issue getting the supply from the database.");
                        if (await _context.SupplyBaskets.AnyAsync(pb => pb.BasketId == id && basketSupplyIds.Contains(pb.SupplyId)))
                        {
                            try
                            {
                                await HelperMethods.IncreaseAssignedCategoryQuantityByOne(_context, supply);
                            }
                            catch (DbUpdateException ex)
                            {
                                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                                throw new DbUpdateException("There was an issue adding the supply category quantity back while removing the supply from the basket.");
                            }
                        }
                    }
                    supplyBasketsToDelete = await _context.SupplyBaskets.Where(pb => pb.BasketId == id && basketSupplyIds.Contains(pb.SupplyId)).ToListAsync();
                }
            }
            if (supplyBasketsToDelete is not null && supplyBasketsToDelete.Count > 0)
            {
                _context.SupplyBaskets.RemoveRange(supplyBasketsToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
