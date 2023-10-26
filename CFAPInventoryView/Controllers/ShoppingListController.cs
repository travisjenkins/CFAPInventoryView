using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Models;
using CFAPInventoryView.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CFAPInventoryView.Controllers
{
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
                                                   .Include(b => b.AgeGroup)
                                                   .Include(b => b.Ethnicity)
                                                   .Include(b => b.Gender)
                                                   .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                                        .ThenInclude(cb => cb.Category)
                                                   .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                                        .ThenInclude(cb => cb.OptionalCategory)
                                                   .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                                        .ThenInclude(cb => cb.ExcludeCategory)
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
                                                    .ThenInclude(cb => cb.Category)
                                                .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                                    .ThenInclude(cb => cb.OptionalCategory)
                                                .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                                    .ThenInclude(cb => cb.ExcludeCategory)
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

            /*
             * Get all categories from the database
             * Create a new basket and initialize the CategoryBaskets property with an empty list (since the basket does not exist yet)
             */
            Basket basket = new();
            ViewData["Categories"] = await PopulateAssignedCategories("Category", basket);
            ViewData["OptionalCategories"] = await PopulateAssignedCategories("Optional", basket);
            ViewData["ExcludeCategories"] = await PopulateAssignedCategories("Exclude", basket);
            return View();
        }

        // POST: ShoppingList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("AgeGroupId,EthnicityId,GenderId,DateAssembled,Quantity,SafeStockLevel")] Basket basket, List<Guid>? assignedCategories, List<Guid>? assignedOptionalCategories, List<Guid>? assignedExcludeCategories)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    basket.BasketId = Guid.NewGuid();
                    basket.Active = true;
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
                    ModelState.AddModelError(string.Empty, "There was an issue assigning the categories to the basket. If the issue continues please contact an administrator.");
                }
            }
            // Something failed. Redisplay the page with user provided values.
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["Categories"] = await PopulateAssignedCategories("Category", basket);
            ViewData["OptionalCategories"] = await PopulateAssignedCategories("Optional", basket);
            ViewData["ExcludeCategories"] = await PopulateAssignedCategories("Exclude", basket);

            return View(basket);
        }

        // GET: ShoppingList/Edit/1
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Baskets == null)
            {
                return NotFound();
            }

            var basket = await _context.Baskets.Include(b => b.AgeGroup)
                                               .Include(b => b.Ethnicity)
                                               .Include(b => b.Gender)
                                               .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                               .DefaultIfEmpty()
                                               .FirstOrDefaultAsync(b => b.BasketId == id);
            if (basket == null)
            {
                return NotFound();
            }

            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["Categories"] = await PopulateAssignedCategories("Category", basket);
            ViewData["OptionalCategories"] = await PopulateAssignedCategories("Optional", basket);
            ViewData["ExcludeCategories"] = await PopulateAssignedCategories("Exclude", basket);

            return View(basket);
        }

        // POST: ShoppingList/Edit/1
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("BasketId,AgeGroupId,EthnicityId,GenderId,DateAssembled,Quantity,SafeStockLevel,Active")] Basket basket, List<Guid>? assignedCategories, List<Guid>? assignedOptionalCategories, List<Guid>? assignedExcludeCategories)
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
                        var currentAssignedExcludeCategoryIds = currentAssignedExcludeCategories.Select( cb => cb.ExcludeCategoryId).ToList();
                        
                        // 3. Get the Ids to add
                        var categoryIdsToAdd = assignedCategories?.Where(id => !currentAssignedCategoryIds.Contains(id)).ToList();
                        var optionalCategoryIdsToAdd = assignedOptionalCategories?.Where(id => !currentAssignedOptionalCategoryIds.Contains(id)).ToList();
                        var excludeCategoryIdsToAdd = assignedExcludeCategories?.Where(id => !currentAssignedExcludeCategoryIds.Contains(id)).ToList();

                        // 4. Get the Ids to delete
                        var categoriesToDelete = currentAssignedCategoryIds.Where(cb => !assignedCategories.Contains((Guid)cb)).ToList();
                        var optionalCategoriesToDelete = currentAssignedOptionalCategoryIds.Where(cb => !assignedOptionalCategories.Contains((Guid)cb)).ToList();
                        var excludeCategoriesToDelete = currentAssignedExcludeCategoryIds.Where(cb => !assignedExcludeCategories.Contains((Guid)cb)).ToList();
                        
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
                catch (DbUpdateConcurrencyException ex)
                {
                    if (!BasketExists(basket.BasketId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue assigning the categories to the basket. If the issue continues please contact an administrator.");
                    }
                }
            }
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);
            ViewData["Categories"] = await PopulateAssignedCategories("Category", basket);
            ViewData["OptionalCategories"] = await PopulateAssignedCategories("Optional", basket);
            ViewData["ExcludeCategories"] = await PopulateAssignedCategories("Exclude", basket);

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
                                                    .ThenInclude(cb => cb.Category)
                                                .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                                    .ThenInclude(cb => cb.OptionalCategory)
                                                .Include(b => b.CategoryBaskets.Where(cb => cb.Active))
                                                    .ThenInclude(cb => cb.ExcludeCategory)
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

        private async Task<List<AssignedCategoryViewModel>> PopulateAssignedCategories(string categoryType, Basket basket)
        {
            List<AssignedCategoryViewModel> assignedCategoryViewModel = new();
            // Check if CategoryBaskets is null, if so create a new list (the line below is called a compound assignment statement)
            basket.CategoryBaskets ??= new List<CategoryBasket>();
            switch (categoryType)
            {
                case "Category":
                    var allCategories = await _context.Categories.AsNoTracking().Where(c => c.Active).OrderBy(c => c.Name).ToListAsync();
                    if (allCategories is not null)
                    {
                        var basketCategories = new HashSet<Guid?>(basket.CategoryBaskets.Select(c => c.CategoryId));
                        foreach (var category in allCategories)
                        {
                            assignedCategoryViewModel.Add(new AssignedCategoryViewModel
                            {
                                CategoryId = category.CategoryId,
                                Name = category.Name,
                                Assigned = basketCategories.Contains(category.CategoryId)
                            });
                        }
                    }
                    break;
                case "Optional":
                    var allOptionalCategories = await _context.OptionalCategories.AsNoTracking().Where(c => c.Active).OrderBy(c => c.Name).ToListAsync();
                    if (allOptionalCategories is not null)
                    {
                        var basketOptionalCategories = new HashSet<Guid?>(basket.CategoryBaskets.Select(c => c.OptionalCategoryId));
                        foreach (var category in allOptionalCategories)
                        {
                            assignedCategoryViewModel.Add(new AssignedCategoryViewModel
                            {
                                CategoryId = category.OptionalCategoryId,
                                Name = category.Name,
                                Assigned = basketOptionalCategories.Contains(category.OptionalCategoryId)
                            });
                        }
                    }
                    break;
                case "Exclude":
                    var allExcludeCategories = await _context.ExcludeCategories.AsNoTracking().Where(c => c.Active).OrderBy(c => c.Name).ToListAsync();
                    if (allExcludeCategories is not null)
                    {
                        var basketExcludeCategories = new HashSet<Guid?>(basket.CategoryBaskets.Select(c => c.ExcludeCategoryId));
                        foreach (var category in allExcludeCategories)
                        {
                            assignedCategoryViewModel.Add(new AssignedCategoryViewModel
                            {
                                CategoryId = category.ExcludeCategoryId,
                                Name = category.Name,
                                Assigned = basketExcludeCategories.Contains(category.ExcludeCategoryId)
                            });
                        }
                    }
                    break;
                default:
                    break;
            }
            return assignedCategoryViewModel;
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
                                Active = true,
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
                                Active = true,
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
                                Active = true,
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

        private async Task DeleteCategoriesForBasket(Guid id, List<CategoryBasket>? assignedCategories = null, List<CategoryBasket>? assignedOptionalCategories = null, List<CategoryBasket>? assignedExcludeCategories = null, List<Guid?>? categoriesToDelete = null, List<Guid?>? optionalCategoriesToDelete = null, List<Guid?>? excludeCategoriesToDelete = null)
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
