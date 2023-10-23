using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Models;
using CFAPInventoryView.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

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
            
            /*
             * Get all categories from the database
             * Create a new basket and initialize the CategoryBaskets property with an empty list
             */
            var allCategories = await _context.Categories.AsNoTracking().Where(c => c.Active).ToListAsync();
            var allOptionalCategories = await _context.OptionalCategories.AsNoTracking().Where(c => c.Active).ToListAsync();
            var allExcludeCategories = await _context.ExcludeCategories.AsNoTracking().Where(c => c.Active).ToListAsync();
            Basket basket = new()
            {
                CategoryBaskets = new List<CategoryBasket>()
            };
            ViewData["Categories"] = PopulateAssignedCategories(allCategories, "Category", basket);
            ViewData["OptionalCategories"] = PopulateAssignedCategories(allOptionalCategories, "Optional", basket);
            ViewData["ExcludeCategories"] = PopulateAssignedCategories(allExcludeCategories, "Exclude", basket);
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
                basket.BasketId = Guid.NewGuid();
                basket.Active = true;
                basket.LastUpdateId = User.Identity?.Name;
                basket.LastUpdateDateTime = DateTime.Now;
                _context.Add(basket);
                await _context.SaveChangesAsync();

                try
                {
                    await AddBasketCategories(basket.BasketId, assignedCategories, assignedOptionalCategories, assignedExcludeCategories);
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                    ModelState.AddModelError(string.Empty, "There was an issue assigning the categories to the basket. If the issue continues please contact an administrator.");
                }
            }
            ViewData["AgeGroupsSelectList"] = await SelectListBuilder.GetAgeGroupsSelectListAsync(_context, basket.AgeGroupId);
            ViewData["EthnicitiesSelectList"] = await SelectListBuilder.GetEthnicitiesSelectListAsync(_context, basket.EthnicityId);
            ViewData["GendersSelectList"] = await SelectListBuilder.GetGendersSelectListAsync(_context, basket.GenderId);

            var allCategories = await _context.Categories.AsNoTracking().Where(c => c.Active).ToListAsync();
            var allOptionalCategories = await _context.OptionalCategories.AsNoTracking().Where(c => c.Active).ToListAsync();
            var allExcludeCategories = await _context.ExcludeCategories.AsNoTracking().Where(c => c.Active).ToListAsync();

            ViewData["Categories"] = PopulateAssignedCategories(allCategories, "Category", basket);
            ViewData["OptionalCategories"] = PopulateAssignedCategories(allOptionalCategories, "Optional", basket);
            ViewData["ExcludeCategories"] = PopulateAssignedCategories(allExcludeCategories, "Exclude", basket);

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

            // Retrieve all categories from the DB to populate the categories and checkmark the ones assigned
            var allCategories = await _context.Categories.AsNoTracking().Where(c => c.Active).ToListAsync();
            var allOptionalCategories = await _context.OptionalCategories.AsNoTracking().Where(c => c.Active).ToListAsync();
            var allExcludeCategories = await _context.ExcludeCategories.AsNoTracking().Where(c => c.Active).ToListAsync();
            // Send in the populated categories view data
            ViewData["Categories"] = PopulateAssignedCategories(allCategories, "Category", basket);
            ViewData["OptionalCategories"] = PopulateAssignedCategories(allOptionalCategories, "Optional", basket);
            ViewData["ExcludeCategories"] = PopulateAssignedCategories(allExcludeCategories, "Exclude", basket);

            return View(basket);
        }

        // POST: ShoppingList/Edit/1
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("BasketId,AgeGroupId,EthnicityId,GenderId,DateAssembled,Quantity,SafeStockLevel,Active")] Basket basket, List<Guid> assignedCategories, List<Guid> assignedOptionalCategories, List<Guid> assignedExcludeCategories)
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

                    // TODO: Add/Delete categories in CategoryBasket collection

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

            // Retrieve all categories from the DB to populate the categories and checkmark the ones assigned
            var allCategories = await _context.Categories.AsNoTracking().Where(c => c.Active).ToListAsync();
            var allOptionalCategories = await _context.OptionalCategories.AsNoTracking().Where(c => c.Active).ToListAsync();
            var allExcludeCategories = await _context.ExcludeCategories.AsNoTracking().Where(c => c.Active).ToListAsync();
            // Send in the populated categories view data
            ViewData["Categories"] = PopulateAssignedCategories(allCategories, "Category", basket);
            ViewData["OptionalCategories"] = PopulateAssignedCategories(allOptionalCategories, "Optional", basket);
            ViewData["ExcludeCategories"] = PopulateAssignedCategories(allExcludeCategories, "Exclude", basket);

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

        private static List<AssignedCategoryViewModel> PopulateAssignedCategories<T>(List<T> allCategories, string categoryType, Basket basket)
        {
            List<AssignedCategoryViewModel> assignedCategoryViewModel = new();
            switch (categoryType)
            {
                case "Category":
                    List<Category>? categories = allCategories as List<Category>;
                    if (categories is not null)
                    {
                        var basketCategories = new HashSet<Guid?>(basket.CategoryBaskets.Select(c => c.CategoryId));
                        foreach (var category in categories)
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
                    List<OptionalCategory>? optionalCategories = allCategories as List<OptionalCategory>;
                    if (optionalCategories is not null)
                    {
                        var basketOptionalCategories = new HashSet<Guid?>(basket.CategoryBaskets.Select(c => c.OptionalCategoryId));
                        foreach (var category in optionalCategories)
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
                    List<ExcludeCategory>? excludeCategories = allCategories as List<ExcludeCategory>;
                    if (excludeCategories is not null)
                    {
                        var basketExcludeCategories = new HashSet<Guid?>(basket.CategoryBaskets.Select(c => c.ExcludeCategoryId));
                        foreach (var category in excludeCategories)
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
                AddCategories(basketId, assignedCategories, categoryBaskets, categoriesToAdd);
            }
            if (assignedOptionalCategories is not null)
            {
                AddCategories(basketId, assignedOptionalCategories, categoryBaskets, categoriesToAdd);
            }
            if (assignedExcludeCategories is not null)
            {
                AddCategories(basketId, assignedExcludeCategories, categoryBaskets, categoriesToAdd);
            }
            if (categoriesToAdd.Count > 0)
            {
                await _context.CategoryBaskets.AddRangeAsync(categoriesToAdd);
                await _context.SaveChangesAsync();
            }
        }

        private void AddCategories(Guid basketId, List<Guid> selectedCategories, List<CategoryBasket> categoryBaskets, List<CategoryBasket> categoriesToAdd)
        {
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
        }
    }
}
