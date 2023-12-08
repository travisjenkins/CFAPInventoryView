using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Models;
using CFAPInventoryView.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole},{HelperMethods.MemberRole}")]
    public class ShoppingListController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ShoppingListController> _logger;

        public ShoppingListController(ApplicationDbContext context, ILogger<ShoppingListController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: ShoppingList
        public async Task<IActionResult> Index()
        {
            return _context.CategoryBaskets != null ?
                        View(await _context.Baskets.AsNoTracking()
                                                   .Where(b => b.IsShoppingListItem)
                                                   .Include(b => b.AgeGroup)
                                                   .Include(b => b.Ethnicity)
                                                   .Include(b => b.Gender)
                                                   .Include(b => b.CategoryBaskets)
                                                        .ThenInclude(cb => cb.Category)
                                                   .Include(b => b.CategoryBaskets)
                                                        .ThenInclude(cb => cb.OptionalCategory)
                                                   .Include(b => b.CategoryBaskets)
                                                        .ThenInclude(cb => cb.ExcludeCategory)
                                                   .DefaultIfEmpty()
#pragma warning disable 8602
                                                   .OrderBy(b => b.AgeGroup.Description)
                                                   .ThenBy(b => b.DateAssembled)
#pragma warning restore 8602
                                                   .ToListAsync()) :
                        Problem("There are no shopping lists in the database.");
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
                                               .Include(b => b.CategoryBaskets)
                                                    .ThenInclude(cb => cb.Category)
                                                .Include(b => b.CategoryBaskets)
                                                    .ThenInclude(cb => cb.OptionalCategory)
                                                .Include(b => b.CategoryBaskets)
                                                    .ThenInclude(cb => cb.ExcludeCategory)
                                               .FirstOrDefaultAsync(b => b.BasketId == id);
            if (basket == null)
            {
                return NotFound();
            }

            return View(basket);
        }

        // GET: ShoppingList/Create
        public async Task<IActionResult> Create(Guid? AgeGroupId)
        {
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context);

            /*
             * Get all categories from the database
             * Create a new basket and initialize the CategoryBaskets property with an empty list (since the basket does not exist yet)
             */
            Basket basket = new();
            ViewData["Categories"] = await PopulateAssignedCategories("Category", basket, AgeGroupId);
            ViewData["OptionalCategories"] = await PopulateAssignedCategories("Optional", basket, AgeGroupId);
            ViewData["ExcludeCategories"] = await PopulateAssignedCategories("Exclude", basket, AgeGroupId);
            return View();
        }

        // POST: ShoppingList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("AgeGroupId,EthnicityId,GenderId,DateAssembled,SafeStockLevel")] Basket basket, 
                                                List<Guid>? assignedCategories, 
                                                List<Guid>? assignedOptionalCategories, 
                                                List<Guid>? assignedExcludeCategories)
        {
            if (basket.SafeStockLevel is not null && basket.SafeStockLevel > 0)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        basket.BasketId = Guid.NewGuid();
                        basket.IsShoppingListItem = true;
                        basket.Quantity = 0;
                        basket.LastUpdateId = User.Identity?.Name;
                        basket.LastUpdateDateTime = DateTime.Now;
                        _context.Add(basket);
                        await _context.SaveChangesAsync();
                        await AddBasketCategories(basket.BasketId, assignedCategories, assignedOptionalCategories, assignedExcludeCategories);
                        return RedirectToAction(nameof(Index));
                    }
                    catch (DbUpdateException ex)
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue creating the iBelong Basket shopping list. If the issue continues please contact an administrator.");
                    }
                }
            }
            else
            {
                ModelState.AddModelError(nameof(Basket.SafeStockLevel), "You must provide a safe stock level for this type of basket.");
            }
            // Something failed. Redisplay the page with user provided values.
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["Categories"] = await PopulateAssignedCategories("Category", basket, basket.AgeGroupId);
            ViewData["OptionalCategories"] = await PopulateAssignedCategories("Optional", basket, basket.AgeGroupId);
            ViewData["ExcludeCategories"] = await PopulateAssignedCategories("Exclude", basket, basket.AgeGroupId);

            return View(basket);
        }

        // GET: ShoppingList/Edit/1
        public async Task<IActionResult> Edit(Guid? id, Guid? AgeGroupId)
        {
            if (id == null || _context.Baskets == null)
            {
                return NotFound();
            }

            var basket = await _context.Baskets.Include(b => b.AgeGroup)
                                               .Include(b => b.Ethnicity)
                                               .Include(b => b.Gender)
                                               .Include(b => b.CategoryBaskets)
                                               .FirstOrDefaultAsync(b => b.BasketId == id);
            if (basket == null)
            {
                return NotFound();
            }

            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            if (AgeGroupId.HasValue)
            {
                ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, AgeGroupId);
                ViewData["Categories"] = await PopulateAssignedCategories("Category", basket, AgeGroupId);
                ViewData["OptionalCategories"] = await PopulateAssignedCategories("Optional", basket, AgeGroupId);
                ViewData["ExcludeCategories"] = await PopulateAssignedCategories("Exclude", basket, AgeGroupId);
            }
            else
            {
                ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
                ViewData["Categories"] = await PopulateAssignedCategories("Category", basket, basket.AgeGroupId);
                ViewData["OptionalCategories"] = await PopulateAssignedCategories("Optional", basket, basket.AgeGroupId);
                ViewData["ExcludeCategories"] = await PopulateAssignedCategories("Exclude", basket, basket.AgeGroupId);
            }
            return View(basket);
        }

        // POST: ShoppingList/Edit/1
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, 
                                              [Bind("BasketId,AgeGroupId,EthnicityId,GenderId,DateAssembled,Quantity,SafeStockLevel")] Basket basket, 
                                              List<Guid>? assignedCategories, 
                                              List<Guid>? assignedOptionalCategories, 
                                              List<Guid>? assignedExcludeCategories)
        {
            if (id != basket.BasketId)
            {
                return NotFound();
            }

            if (basket.SafeStockLevel is not null && basket.SafeStockLevel > 0)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        basket.IsShoppingListItem = true;
                        basket.LastUpdateId = User.Identity?.Name;
                        basket.LastUpdateDateTime = DateTime.Now;
                        _context.Update(basket);
                        await _context.SaveChangesAsync();

                        if (assignedCategories is null && assignedOptionalCategories is null && assignedExcludeCategories is null)
                        {
                            await DeleteCategoriesForBasket(id);
                        }
                        else
                        {
                            // 1. Get current Categories, OptionalCategories, and ExcludeCategories from DB
                            var currentAssignedCategories = await _context.CategoryBaskets.Where(cb => cb.BasketId == id && cb.CategoryId != null).ToListAsync();
                            var currentAssignedOptionalCategories = await _context.CategoryBaskets.Where(cb => cb.BasketId == id && cb.OptionalCategoryId != null).ToListAsync();
                            var currentAssignedExcludeCategories = await _context.CategoryBaskets.Where(cb => cb.BasketId == id && cb.ExcludeCategoryId != null).ToListAsync();

                            // 2. Get the Ids
                            var currentAssignedCategoryIds = currentAssignedCategories.Select(cb => cb.CategoryId).ToList();
                            var currentAssignedOptionalCategoryIds = currentAssignedOptionalCategories.Select(cb => cb.OptionalCategoryId).ToList();
                            var currentAssignedExcludeCategoryIds = currentAssignedExcludeCategories.Select(cb => cb.ExcludeCategoryId).ToList();

                            // 3. Get the Ids to add
                            var categoryIdsToAdd = assignedCategories?.Where(id => !currentAssignedCategoryIds.Contains(id)).ToList();
                            var optionalCategoryIdsToAdd = assignedOptionalCategories?.Where(id => !currentAssignedOptionalCategoryIds.Contains(id)).ToList();
                            var excludeCategoryIdsToAdd = assignedExcludeCategories?.Where(id => !currentAssignedExcludeCategoryIds.Contains(id)).ToList();

                            // 4. Get the Ids to delete
#pragma warning disable 8629
#pragma warning disable 8602
                            var categoriesToDelete = currentAssignedCategoryIds.Where(cb => !assignedCategories.Contains((Guid)cb)).ToList();
                            var optionalCategoriesToDelete = currentAssignedOptionalCategoryIds.Where(cb => !assignedOptionalCategories.Contains((Guid)cb)).ToList();
                            var excludeCategoriesToDelete = currentAssignedExcludeCategoryIds.Where(cb => !assignedExcludeCategories.Contains((Guid)cb)).ToList();
#pragma warning restore 8602
#pragma warning restore 8629

                            // 5. Delete
                            if (categoriesToDelete?.Count > 0 || optionalCategoriesToDelete?.Count > 0 || excludeCategoriesToDelete?.Count > 0)
                            {
                                await DeleteCategoriesForBasket(
                                                            id,
                                                            currentAssignedCategories,
                                                            currentAssignedOptionalCategories,
                                                            currentAssignedExcludeCategories,
                                                            categoriesToDelete,
                                                            optionalCategoriesToDelete,
                                                            excludeCategoriesToDelete
                                                            );
                            }

                            // 6. Add
                            if (categoryIdsToAdd?.Count > 0 || optionalCategoryIdsToAdd?.Count > 0 || excludeCategoryIdsToAdd?.Count > 0)
                            {
                                await AddBasketCategories(id, categoryIdsToAdd, optionalCategoryIdsToAdd, excludeCategoryIdsToAdd);
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
                            ModelState.AddModelError(string.Empty, "There was an issue updating the iBelong Basket shopping list. If the issue continues please contact an administrator.");
                        }
                    }
                }
            }
            else
            {
                ModelState.AddModelError(nameof(Basket.SafeStockLevel), "You must provide a safe stock level for this basket setup's inventory tracking.");
            }
            // Something failed. Redisplay the page with user provided values.
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["Categories"] = await PopulateAssignedCategories("Category", basket, basket.AgeGroupId);
            ViewData["OptionalCategories"] = await PopulateAssignedCategories("Optional", basket, basket.AgeGroupId);
            ViewData["ExcludeCategories"] = await PopulateAssignedCategories("Exclude", basket, basket.AgeGroupId);

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
#pragma warning disable 8604
                                               .Include(b => b.CategoryBaskets)
                                                    .ThenInclude(cb => cb.Category)
                                                .Include(b => b.CategoryBaskets)
                                                    .ThenInclude(cb => cb.OptionalCategory)
                                                .Include(b => b.CategoryBaskets)
                                                    .ThenInclude(cb => cb.ExcludeCategory)
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

        // POST: ShoppingList/Delete/1
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
                try
                {
                    _context.Baskets.Remove(basket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool BasketExists(Guid id)
        {
            return (_context.Baskets?.Any(e => e.BasketId == id)).GetValueOrDefault();
        }

        private async Task<List<AssignedCategoryViewModel>> PopulateAssignedCategories(string categoryType, Basket basket, Guid? selectedAgeGroupId = null)
        {
            List<AssignedCategoryViewModel> assignedCategoryViewModels = new();
            // Check if CategoryBaskets is null, if so create a new list (the line below is called a compound assignment statement)
            basket.CategoryBaskets ??= new List<CategoryBasket>();
            switch (categoryType)
            {
                case "Category":
                    await AddCategoriesToViewModel(basket, selectedAgeGroupId, assignedCategoryViewModels);
                    break;
                case "Optional":
                    await AddOptionalCategoriesToViewModel(basket, selectedAgeGroupId, assignedCategoryViewModels);
                    break;
                case "Exclude":
                    await AddExcludeCategoriesToViewModel(basket, selectedAgeGroupId, assignedCategoryViewModels);
                    break;
                default:
                    break;
            }
            return assignedCategoryViewModels;
        }

        private async Task AddExcludeCategoriesToViewModel(Basket basket, Guid? selectedAgeGroupId, List<AssignedCategoryViewModel> assignedCategoryViewModels)
        {
            List<ExcludeCategory> allExcludeCategories = await HelperMethods.GetExcludeCategoriesForAgeGroup(_context, selectedAgeGroupId);
            if (allExcludeCategories is not null && allExcludeCategories.Count > 0)
            {
                var basketExcludeCategories = new HashSet<Guid?>(basket.CategoryBaskets.Select(c => c.ExcludeCategoryId));
                foreach (var category in allExcludeCategories)
                {
                    assignedCategoryViewModels.Add(new AssignedCategoryViewModel
                    {
                        CategoryId = category.ExcludeCategoryId,
                        Name = category.Name,
                        Assigned = basketExcludeCategories.Contains(category.ExcludeCategoryId)
                    });
                }
            }
        }

        private async Task AddOptionalCategoriesToViewModel(Basket basket, Guid? selectedAgeGroupId, List<AssignedCategoryViewModel> assignedCategoryViewModels)
        {
            List<OptionalCategory> allOptionalCategories = await HelperMethods.GetOptionalCategoriesForAgeGroup(_context, selectedAgeGroupId);
            if (allOptionalCategories is not null && allOptionalCategories.Count > 0)
            {
                var basketOptionalCategories = new HashSet<Guid?>(basket.CategoryBaskets.Select(c => c.OptionalCategoryId));
                foreach (var category in allOptionalCategories)
                {
                    assignedCategoryViewModels.Add(new AssignedCategoryViewModel
                    {
                        CategoryId = category.OptionalCategoryId,
                        Name = category.Name,
                        Assigned = basketOptionalCategories.Contains(category.OptionalCategoryId)
                    });
                }
            }
        }

        private async Task AddCategoriesToViewModel(Basket basket, Guid? selectedAgeGroupId, List<AssignedCategoryViewModel> assignedCategoryViewModels)
        {
            List<Category> allCategories = await HelperMethods.GetCategoriesForAgeGroup(_context, selectedAgeGroupId);
            if (allCategories is not null && allCategories.Count > 0)
            {
                var basketCategories = new HashSet<Guid?>(basket.CategoryBaskets.Select(c => c.CategoryId));
                foreach (var category in allCategories)
                {
                    assignedCategoryViewModels.Add(new AssignedCategoryViewModel
                    {
                        CategoryId = category.CategoryId,
                        Name = category.Name,
                        Assigned = basketCategories.Contains(category.CategoryId)
                    });
                }
            }
        }

        private async Task AddBasketCategories(Guid basketId, List<Guid>? assignedCategories, List<Guid>? assignedOptionalCategories, List<Guid>? assignedExcludeCategories)
        {
            var categoryBaskets = await _context.CategoryBaskets.Where(cb => cb.BasketId == basketId).ToListAsync();
            List<CategoryBasket> categoriesToAdd = new();
            if (assignedCategories is not null)
            {
                AddCategories(basketId, "Category", assignedCategories, categoryBaskets, categoriesToAdd);
            }
            if (assignedOptionalCategories is not null)
            {
                AddCategories(basketId, "Optional", assignedOptionalCategories, categoryBaskets, categoriesToAdd);
            }
            if (assignedExcludeCategories is not null)
            {
                AddCategories(basketId, "Exclude", assignedExcludeCategories, categoryBaskets, categoriesToAdd);
            }
            if (categoriesToAdd.Count > 0)
            {
                await _context.CategoryBaskets.AddRangeAsync(categoriesToAdd);
                await _context.SaveChangesAsync();
            }
        }

        private void AddCategories(Guid basketId, string categoryType, List<Guid> selectedCategories, List<CategoryBasket> categoryBaskets, List<CategoryBasket> categoriesToAdd)
        {
            switch (categoryType)
            {
                case "Category":
                    foreach (var categoryId in selectedCategories)
                    {
                        if (!categoryBaskets.Any(cb => cb.CategoryId == categoryId))
                        {
                            var categoryToAdd = new CategoryBasket
                            {
                                CategoryBasketId = Guid.NewGuid(),
                                BasketId = basketId,
                                CategoryId = categoryId,
                                LastUpdateId = User.Identity?.Name,
                                LastUpdateDateTime = DateTime.Now
                            };
                            categoriesToAdd.Add(categoryToAdd);
                        }
                    }
                    break;
                case "Optional":
                    foreach (var categoryId in selectedCategories)
                    {
                        if (!categoryBaskets.Any(cb => cb.OptionalCategoryId == categoryId))
                        {
                            var categoryToAdd = new CategoryBasket
                            {
                                CategoryBasketId = Guid.NewGuid(),
                                BasketId = basketId,
                                OptionalCategoryId = categoryId,
                                LastUpdateId = User.Identity?.Name,
                                LastUpdateDateTime = DateTime.Now
                            };
                            categoriesToAdd.Add(categoryToAdd);
                        }
                    }
                    break;
                case "Exclude":
                    foreach (var categoryId in selectedCategories)
                    {
                        if (!categoryBaskets.Any(cb => cb.ExcludeCategoryId == categoryId))
                        {
                            var categoryToAdd = new CategoryBasket
                            {
                                CategoryBasketId = Guid.NewGuid(),
                                BasketId = basketId,
                                ExcludeCategoryId = categoryId,
                                LastUpdateId = User.Identity?.Name,
                                LastUpdateDateTime = DateTime.Now
                            };
                            categoriesToAdd.Add(categoryToAdd);
                        }
                    }
                    break;
                default:
                    break;
            }
            
        }

        private async Task DeleteCategoriesForBasket(Guid id, 
                                                     List<CategoryBasket>? assignedCategories = null, 
                                                     List<CategoryBasket>? assignedOptionalCategories = null, 
                                                     List<CategoryBasket>? assignedExcludeCategories = null, 
                                                     List<Guid?>? categoriesToDelete = null, 
                                                     List<Guid?>? optionalCategoriesToDelete = null, 
                                                     List<Guid?>? excludeCategoriesToDelete = null)
        {
            List<CategoryBasket>? categoryBaskets = null;
            if (categoriesToDelete is null && optionalCategoriesToDelete is null && excludeCategoriesToDelete is null)
            {
                categoryBaskets = await _context.CategoryBaskets.Where(cb => cb.BasketId == id).ToListAsync();
            }
            if (categoriesToDelete is not null && categoriesToDelete.Count > 0)
            {
                var basketCategories = new HashSet<Guid?>(categoriesToDelete);
                if (assignedCategories is not null)
                {
                    categoryBaskets = assignedCategories.Where(cb => cb.BasketId == id && basketCategories.Contains(cb.CategoryId)).ToList();
                }
                else
                {
                    categoryBaskets = await _context.CategoryBaskets.Where(cb => cb.BasketId == id && basketCategories.Contains(cb.CategoryId)).ToListAsync();
                }
            }
            if (optionalCategoriesToDelete is not null && optionalCategoriesToDelete.Count > 0)
            {
                var optionalCategories = new HashSet<Guid?>(optionalCategoriesToDelete);
                if (assignedOptionalCategories is not null)
                {
                    if (categoryBaskets is not null)
                    {
                        categoryBaskets.AddRange(assignedOptionalCategories.Where(cb => cb.BasketId == id && optionalCategories.Contains(cb.OptionalCategoryId)).ToList());
                    }
                    else
                    {
                        categoryBaskets = assignedOptionalCategories.Where(cb => cb.BasketId == id && optionalCategories.Contains(cb.OptionalCategoryId)).ToList();
                    }
                }
                else
                {
                    if (categoryBaskets is not null)
                    {
                        categoryBaskets.AddRange(await _context.CategoryBaskets.Where(cb => cb.BasketId == id && optionalCategories.Contains(cb.OptionalCategoryId)).ToListAsync());
                    }
                    else
                    {
                        categoryBaskets = await _context.CategoryBaskets.Where(cb => cb.BasketId == id && optionalCategories.Contains(cb.OptionalCategoryId)).ToListAsync();
                    }
                }
            }
            if (excludeCategoriesToDelete is not null && excludeCategoriesToDelete.Count > 0)
            {
                if (assignedExcludeCategories is not null)
                {
                    var excludeCategories = new HashSet<Guid?>(excludeCategoriesToDelete);
                    if (categoryBaskets is not null)
                    {
                        categoryBaskets.AddRange(assignedExcludeCategories.Where(cb => cb.BasketId == id && excludeCategories.Contains(cb.ExcludeCategoryId)).ToList());
                    }
                    else
                    {
                        categoryBaskets = assignedExcludeCategories.Where(cb => cb.BasketId == id && excludeCategories.Contains(cb.ExcludeCategoryId)).ToList();
                    }
                }
                else 
                {
                    var excludeCategories = new HashSet<Guid?>(excludeCategoriesToDelete);
                    if (categoryBaskets is not null)
                    {
                        categoryBaskets.AddRange(await _context.CategoryBaskets.Where(cb => cb.BasketId == id && excludeCategories.Contains(cb.ExcludeCategoryId)).ToListAsync());
                    }
                    else
                    {
                        categoryBaskets = await _context.CategoryBaskets.Where(cb => cb.BasketId == id && excludeCategories.Contains(cb.ExcludeCategoryId)).ToListAsync();
                    }
                }
            }
            if (categoryBaskets is not null && categoryBaskets.Count > 0)
            {
                _context.CategoryBaskets.RemoveRange(categoryBaskets);
                await _context.SaveChangesAsync();
            }
        }
    }
}
