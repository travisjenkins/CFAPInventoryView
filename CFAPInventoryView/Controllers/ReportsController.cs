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
                // Products
                viewModel.TotalProducts = await _context.Products.AsNoTracking().Where(p => p.Active).CountAsync();
                viewModel.TotalItemsThatExpire = await _context.Products.AsNoTracking().Where(p => p.Expires).CountAsync();

                decimal totalInventoryPrice = 0;
                var products = await _context.Products.AsNoTracking().Where(p => p.Active).ToListAsync();
                if (products is not null && products.Count > 0)
                {
                    long temp = 0;
                    foreach (var product in products)
                    {
                        totalInventoryPrice += product.Price * product.Quantity;
                        if (product.DurationOnShelf.HasValue)
                        {
                            temp += product.DurationOnShelf.Value / products.Count;
                        }
                    }
                    viewModel.TotalProductDurationOnShelf = new TimeSpan(temp);
                }
                viewModel.TotalInventoryPrice = totalInventoryPrice;

                // iBelong
                viewModel.TotalShoppingListBaskets = await _context.Baskets.AsNoTracking().Where(b => b.IsShoppingListItem).CountAsync();
                viewModel.TotaliBelongBaskets = await _context.Baskets.AsNoTracking().Where(b => !b.IsShoppingListItem).CountAsync();

                decimal totalIBelongBasketPrice = 0;
                var baskets = await _context.Baskets.AsNoTracking().Where(b => !b.IsShoppingListItem && b.Active).Include(b => b.ProductBaskets.Where(pb => pb.Active)).DefaultIfEmpty().ToListAsync();
                if (baskets is not null && baskets.Count > 0)
                {
                    long temp = 0;
                    foreach (var basket in baskets)
                    {
                        totalIBelongBasketPrice += basket.TotalPrice;
                        if (basket.DurationOnShelf.HasValue)
                        {
                            temp += basket.DurationOnShelf.Value / baskets.Count;
                        }
                    }
                    viewModel.TotalBasketDurationOnShelf = new TimeSpan(temp);
                }
                viewModel.TotaliBelongBasketPrice = totalIBelongBasketPrice;
            }
            catch (DbException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Restock()
        {
            return View(await _context.Products.AsNoTracking().Where(p => p.Active && p.Quantity < p.SafeStockLevel).OrderBy(p => p.Quantity).ToListAsync());
        }

        public async Task<IActionResult> ExpiresSoon()
        {
            return View(await _context.Products.AsNoTracking().Where(p => p.Active && p.Expires && p.ExpirationDate <= DateTime.Now.AddDays(7)).OrderByDescending(p => p.ExpirationDate).ToListAsync());
        }
    }
}
