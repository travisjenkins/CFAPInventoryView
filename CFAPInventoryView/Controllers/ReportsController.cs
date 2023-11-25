using CFAPInventoryView.Data;
using CFAPInventoryView.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ReportsController> _logger;

        public ReportsController(ApplicationDbContext context, ILogger<ReportsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Statistics()
        {
            StatisticsViewModel viewModel = new();
            try
            {
                // Supplies
                viewModel.TotalSupplies = await _context.Supplies.AsNoTracking().CountAsync();
                viewModel.TotalItemsThatExpire = await _context.Supplies.AsNoTracking().Where(p => p.Expires).CountAsync();

                decimal totalInventoryPrice = 0;
                var supplies = await _context.Supplies.AsNoTracking().ToListAsync();
                if (supplies is not null && supplies.Count > 0)
                {
                    long temp = 0;
                    foreach (var supply in supplies)
                    {
                        totalInventoryPrice += supply.Price * supply.Quantity;
                        //if (product.DurationOnShelf.HasValue)
                        //{
                        //    temp += product.DurationOnShelf.Value / products.Count;
                        //}
                    }
                    viewModel.TotalSupplyDurationOnShelf = new TimeSpan(temp);
                }
                viewModel.TotalInventoryPrice = totalInventoryPrice;

                // iBelong
                viewModel.TotalShoppingListBaskets = await _context.Baskets.AsNoTracking().Where(b => b.IsShoppingListItem).CountAsync();
                viewModel.TotaliBelongBaskets = await _context.Baskets.AsNoTracking().Where(b => !b.IsShoppingListItem).CountAsync();

                decimal totalIBelongBasketPrice = 0;
#pragma warning disable 8604
                var baskets = await _context.Baskets.AsNoTracking().Where(b => !b.IsShoppingListItem).Include(b => b.SupplyBaskets).ThenInclude(sb => sb.Supply).ToListAsync();
#pragma warning restore 8604
                if (baskets is not null && baskets.Count > 0)
                {
                    long temp = 0;
                    foreach (var basket in baskets)
                    {
                        totalIBelongBasketPrice += basket.TotalPrice;
                        //if (basket.DurationOnShelf.HasValue)
                        //{
                        //    temp += basket.DurationOnShelf.Value / baskets.Count;
                        //}
                    }
                    viewModel.TotalBasketDurationOnShelf = new TimeSpan(temp);
                }
                viewModel.TotaliBelongBasketPrice = totalIBelongBasketPrice;
            }
            catch (DbException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "ERROR: There was an issue retrieving information from the database. If the issue persists, please contact and administrator.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "ERROR: Something bad happened. If the issue persists, please contact and administrator.");
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Restock()
        {
            RestockViewModel viewModel = new()
            {
                Categories = await _context.Categories.AsNoTracking().Where(c => c.Quantity <= c.SafeStockLevel).OrderBy(c => c.Quantity).ToListAsync(),
                OptionalCategories = await _context.OptionalCategories.AsNoTracking().Where(c => c.Quantity <= c.SafeStockLevel).OrderBy(c => c.Quantity).ToListAsync()
            };
            return View(viewModel);
        }
        public async Task<IActionResult> ExpiresSoon()
        {
            return View(await _context.Supplies.AsNoTracking().Where(p => p.Expires && p.ExpirationDate <= DateTime.Now.AddDays(7)).OrderBy(p => p.ExpirationDate).ToListAsync());
        }
    }
}
