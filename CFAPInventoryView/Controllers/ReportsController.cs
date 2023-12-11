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
            // Supplies
            try
            {
                var supplies = await _context.Supplies.AsNoTracking()
                                                    .Where(s => s.Active)
                                                    .ToListAsync();
                var supplyTransactions = await _context.SupplyTransactions.AsNoTracking()
                                                                            .Include(st => st.Supply)
                                                                            .ToListAsync();
                viewModel.TotalItemsThatExpire = supplies.Where(s => s.Expires).Count();
                // Calculate total supply inventory price and average duration on shelf
                if (supplies is not null && supplies.Count > 0)
                {
                    int totalSupplies = 0;
                    decimal totalInventoryPrice = 0;
                    foreach (var supply in supplies)
                    {
                        totalSupplies += supply.Quantity;
                        totalInventoryPrice += supply.Price * supply.Quantity;
                    }
                    viewModel.TotalSupplies = totalSupplies;
                    viewModel.TotalInventoryPrice = totalInventoryPrice;

                    long temp = 0;
                    foreach (var transaction in supplyTransactions)
                    {
                        if (transaction.DurationOnShelf.HasValue && viewModel.TotalSupplies > 0)
                        {
                            temp += transaction.DurationOnShelf.Value / viewModel.TotalSupplies;
                        }
                    }
                    viewModel.AverageSupplyDurationOnShelf = new TimeSpan(temp);
                }
            }
            catch (DbException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "ERROR: There was an issue retrieving supply information from the database. If the issue persists, please contact and administrator.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "ERROR: Something bad happened calculating supply information. If the issue persists, please contact and administrator.");
            }


            // iBelong
            try
            {
                decimal totalIBelongBasketPrice = 0;
#pragma warning disable 8604
                var baskets = await _context.Baskets.AsNoTracking()
                                                    .Where(b => b.Active && !b.IsShoppingListItem)
                                                    .Include(b => b.SupplyBaskets)
                                                        .ThenInclude(sb => sb.Supply)
                                                    .ToListAsync();
#pragma warning restore 8604
                var basketTransactions = await _context.BasketTransactions.AsNoTracking()
                                                                            .Include(bt => bt.Basket)
                                                                            .ToListAsync();
                viewModel.TotalShoppingListBaskets = await _context.Baskets.AsNoTracking()
                                                                            .Where(b => b.Active && b.IsShoppingListItem)
                                                                            .CountAsync();
                viewModel.TotaliBelongBaskets = baskets.Count;
                if (baskets is not null && baskets.Count > 0)
                {
                    long temp = 0;
                    foreach (var basket in baskets)
                    {
                        totalIBelongBasketPrice += basket.TotalPrice;
                    }
                    foreach (var transaction in basketTransactions)
                    {
                        if (transaction.DurationOnShelf.HasValue && viewModel.TotaliBelongBaskets > 0)
                        {
                            temp += transaction.DurationOnShelf.Value / viewModel.TotaliBelongBaskets;
                        }
                    }
                    viewModel.AverageBasketDurationOnShelf = new TimeSpan(temp);
                }
                viewModel.TotaliBelongBasketPrice = totalIBelongBasketPrice;
            }
            catch (DbException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "ERROR: There was an issue retrieving iBelong information from the database. If the issue persists, please contact and administrator.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "ERROR: Something bad happened calculating iBelong information. If the issue persists, please contact and administrator.");
            }


            // Donors
            try
            {
                var donors = await _context.Donors.AsNoTracking()
                                                .Include(d => d.SuppliesDonated)
                                                .ToListAsync();
                if (donors is not null && donors.Count > 0)
                {
                    viewModel.TopNumberOfDonations = donors.Max(d => d.SuppliesDonated.Count);
                    viewModel.TopDonorByNumberOfDonations = donors.FirstOrDefault(d => d.SuppliesDonated.Count == viewModel.TopNumberOfDonations);
                    viewModel.TopDollarAmountDonated = donors.Max(d => d.TotalOfDonations);
                    viewModel.TopDonorByDollarAmountDonated = donors.FirstOrDefault(d => d.TotalOfDonations == viewModel.TopDollarAmountDonated);
                }
            }
            catch (DbException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "ERROR: There was an issue retrieving donor information from the database. If the issue persists, please contact and administrator.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "ERROR: Something bad happened calculating donor information. If the issue persists, please contact and administrator.");
            }


            // Recipients
            try
            {
                var recipients = await _context.Recipients.AsNoTracking()
                                                        .Include(r => r.SupplyTransactions)
                                                            .ThenInclude(st => st.Supply)
                                                        .Include(r => r.BasketTransactions)
                                                            .ThenInclude(bt => bt.Basket)
                                                        .ToListAsync();
                if (recipients is not null && recipients.Count > 0)
                {
                    viewModel.TopNumberOfItemsReceived = recipients
                        .Max(r => r.SupplyTransactions.Count + r.BasketTransactions.Count);
                    viewModel.TopRecipientByNumberOfItemsReceived = recipients
                        .FirstOrDefault(r => (r.SupplyTransactions.Count + r.BasketTransactions.Count) == viewModel.TopNumberOfItemsReceived);
                    viewModel.TopDollarAmountReceived = recipients
                        .Max(r => r.TotalOfDonationsReceived);
                    viewModel.TopRecipientByDollarAmountReceived = recipients
                        .FirstOrDefault(r => r.TotalOfDonationsReceived == viewModel.TopDollarAmountReceived);
                }
            }
            catch (DbException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "ERROR: There was an issue retrieving recipient information from the database. If the issue persists, please contact and administrator.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "ERROR: Something bad happened calculating recipient information. If the issue persists, please contact and administrator.");
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Restock()
        {
            RestockViewModel viewModel = new()
            {
                Categories = await _context.Categories.AsNoTracking()
                                                      .Where(c => c.Quantity < c.SafeStockLevel)
                                                      .OrderBy(c => c.Quantity)
                                                      .ToListAsync(),
                OptionalCategories = await _context.OptionalCategories.AsNoTracking()
                                                                      .Where(c => c.Quantity < c.SafeStockLevel)
                                                                      .OrderBy(c => c.Quantity)
                                                                      .ToListAsync()
            };
            return View(viewModel);
        }
        public async Task<IActionResult> ExpiresSoon()
        {
            return View(await _context.Supplies.AsNoTracking()
                                               .Include(s => s.StorageLocation)
                                               .Where(p => p.Expires && p.ExpirationDate <= DateTime.Now.AddDays(7))
                                               .OrderBy(p => p.ExpirationDate)
                                               .ToListAsync());
        }
    }
}
