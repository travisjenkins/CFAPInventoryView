using CFAPInventoryView.Data;
using CFAPInventoryView.Data.Models;
using CFAPInventoryView.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole},{HelperMethods.MemberRole}")]
    public class BasketTransactionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BasketTransactionsController> _logger;

        public BasketTransactionsController(ApplicationDbContext context, ILogger<BasketTransactionsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: BasketTransactions
        public async Task<IActionResult> Index()
        {
            return _context.BasketTransactions != null ?
                View(await _context.BasketTransactions.AsNoTracking()
                                                      .Include(bt => bt.Basket)
                                                        .ThenInclude(b => b.AgeGroup)
                                                      .Include(bt => bt.Basket)
                                                        .ThenInclude(b => b.Ethnicity)
                                                      .Include(bt => bt.Basket)
                                                        .ThenInclude(b => b.Gender)
                                                      .Include(bt => bt.Recipient)
                                                      .ToListAsync()) :
                Problem("Entity set 'BasketTransactions' is null.");
        }

        // GET: BasketTransactions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.BasketTransactions == null)
            {
                return NotFound();
            }

            var basketTransaction = await _context.BasketTransactions
                                                  .AsNoTracking()
                                                  .Include(bt => bt.Basket)
                                                    .ThenInclude(b => b.AgeGroup)
                                                  .Include(bt => bt.Basket)
                                                    .ThenInclude(b => b.Ethnicity)
                                                  .Include(bt => bt.Basket)
                                                    .ThenInclude(b => b.Gender)
                                                  .Include(bt => bt.Recipient)
                                                  .FirstOrDefaultAsync(bt => bt.BasketTransactionId == id);
            if (basketTransaction == null)
            {
                return NotFound();
            }

            return View(basketTransaction);
        }

        // GET: BasketTransactions/Create
        public async Task<IActionResult> Create()
        {
            ViewData["BasketsList"] = await _context.Baskets.AsNoTracking().Where(b => !b.IsShoppingListItem).Include(b => b.AgeGroup).Include(b => b.Ethnicity).Include(b => b.Gender).Include(b => b.SupplyBaskets).OrderBy(b => b.AgeGroup.SortOrder).ToListAsync();
            ViewData["RecipientsList"] = await _context.Recipients.AsNoTracking().OrderBy(r => r.LastName).ToListAsync();
            return View();
        }

        // POST: BasketTransactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("BasketId,RecipientId,DateDistributed,DistributedBy")] BasketTransaction transaction)
        {
            var basket = await _context.Baskets.FindAsync(transaction.BasketId);
            if (basket != null)
            {
                var shoppingList = await _context.Baskets.FirstOrDefaultAsync(b => b.IsShoppingListItem && b.AgeGroupId == basket.AgeGroupId && b.EthnicityId == basket.EthnicityId && b.GenderId == basket.GenderId);
                if (shoppingList != null)
                {
                    try
                    {
                        if (ModelState.IsValid)
                        {
                            transaction.BasketTransactionId = Guid.NewGuid();
                            transaction.LastUpdateId = User.Identity?.Name;
                            transaction.LastUpdateDateTime = DateTime.Now;
                            _context.Add(transaction);
                            shoppingList.Quantity -= 1;
                            _context.Update(shoppingList);
                            await _context.SaveChangesAsync();
                            return RedirectToAction(nameof(Index));
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue creating the basket transaction.  If the issue persists, please contact an administrator.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "There was an issue locating an iBelong Basket shopping list item that matched the basket.  This is needed up update the available quantities.");
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, $"No basket found with Id {transaction.BasketId}.");
            }
            ViewData["BasketsList"] = await _context.Baskets.AsNoTracking().Where(b => !b.IsShoppingListItem).Include(b => b.AgeGroup).Include(b => b.Ethnicity).Include(b => b.Gender).Include(b => b.SupplyBaskets).OrderBy(b => b.AgeGroup.SortOrder).ToListAsync();
            ViewData["RecipientsList"] = await _context.Recipients.AsNoTracking().OrderBy(r => r.LastName).ToListAsync();
            return View(transaction);
        }

        // GET: BasketTransactions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.BasketTransactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.BasketTransactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            ViewData["BasketsList"] = await _context.Baskets.AsNoTracking().Where(b => !b.IsShoppingListItem).Include(b => b.AgeGroup).Include(b => b.Ethnicity).Include(b => b.Gender).Include(b => b.SupplyBaskets).OrderBy(b => b.AgeGroup.SortOrder).ToListAsync();
            ViewData["RecipientsList"] = await _context.Recipients.AsNoTracking().OrderBy(r => r.LastName).ToListAsync();
            return View(transaction);
        }

        // POST: BasketTransactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("BasketTransactionId,BasketId,RecipientId,DateDistributed,DistributedBy")] BasketTransaction transaction)
        {
            if (id != transaction.BasketTransactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    transaction.LastUpdateId = User.Identity?.Name;
                    transaction.LastUpdateDateTime = DateTime.Now;
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    if (!BasketTransactionExists(transaction.BasketTransactionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue updating the basket transaction.  If the issue persists, please contact an administrator.");
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BasketsList"] = await _context.Baskets.AsNoTracking().Where(b => !b.IsShoppingListItem).Include(b => b.AgeGroup).Include(b => b.Ethnicity).Include(b => b.Gender).Include(b => b.SupplyBaskets).OrderBy(b => b.AgeGroup.SortOrder).ToListAsync();
            ViewData["RecipientsList"] = await _context.Recipients.AsNoTracking().OrderBy(r => r.LastName).ToListAsync();
            return View(transaction);
        }

        // GET: BasketTransactions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.BasketTransactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.BasketTransactions
                                                  .AsNoTracking()
                                                  .Include(bt => bt.Basket)
                                                    .ThenInclude(b => b.AgeGroup)
                                                  .Include(bt => bt.Basket)
                                                    .ThenInclude(b => b.Ethnicity)
                                                  .Include(bt => bt.Basket)
                                                    .ThenInclude(b => b.Gender)
                                                  .Include(bt => bt.Recipient)
                                                  .FirstOrDefaultAsync(bt => bt.BasketTransactionId == id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // POST: BasketTransactions/Delete/5
        [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.BasketTransactions == null)
            {
                return Problem("Entity set 'BasketTransactions' is null.");
            }
            var transaction = await _context.BasketTransactions.Include(bt => bt.Basket)
                                                                 .ThenInclude(b => b.AgeGroup)
                                                               .Include(bt => bt.Basket)
                                                                 .ThenInclude(b => b.Ethnicity)
                                                               .Include(bt => bt.Basket)
                                                                 .ThenInclude(b => b.Gender)
                                                               .Include(bt => bt.Recipient)
                                                               .FirstOrDefaultAsync(bt => bt.BasketTransactionId == id);
            if (transaction != null)
            {
                var basket = await _context.Baskets.FindAsync(transaction.BasketId);
                if (basket != null)
                {
                    var shoppingList = await _context.Baskets.FirstOrDefaultAsync(b => b.IsShoppingListItem && b.AgeGroupId == basket.AgeGroupId && b.EthnicityId == basket.EthnicityId && b.GenderId == basket.GenderId);
                    if (shoppingList != null)
                    {
                        try
                        {
                            shoppingList.Quantity += 1;
                            _context.Update(shoppingList);
                            _context.BasketTransactions.Remove(transaction);
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateException ex)
                        {
                            _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                            ModelState.AddModelError(string.Empty, "There was an issue deleting the basket transaction.  If the issue persists, please contact an administrator.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "There was an issue locating an iBelong Basket shopping list item that matched the basket.  This is needed up update the available quantities.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"No basket found with Id {transaction.BasketId}.");
                }
                return View(transaction);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool BasketTransactionExists(Guid id)
        {
            return (_context.BasketTransactions?.Any(b => b.BasketTransactionId == id)).GetValueOrDefault();
        }
    }
}
