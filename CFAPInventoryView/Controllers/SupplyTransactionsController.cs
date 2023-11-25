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
using Microsoft.AspNetCore.Authorization;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole},{HelperMethods.MemberRole}")]
    public class SupplyTransactionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<SupplyTransactionsController> _logger;

        public SupplyTransactionsController(ApplicationDbContext context, ILogger<SupplyTransactionsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: SupplyTransactions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SupplyTransactions.AsNoTracking()
                                                                   .Include(p => p.Supply)
                                                                   .Include(p => p.Recipient);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SupplyTransactions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.SupplyTransactions == null)
            {
                return NotFound();
            }

            var supplyTransaction = await _context.SupplyTransactions.AsNoTracking()
                                                                       .Include(p => p.Supply)
                                                                       .Include(p => p.Recipient)
                                                                       .FirstOrDefaultAsync(m => m.SupplyTransactionId == id);
            if (supplyTransaction == null)
            {
                return NotFound();
            }

            return View(supplyTransaction);
        }

        // GET: SupplyTransactions/Create
        public async Task<IActionResult> Create()
        {
            ViewData["RecipientsList"] = await _context.Recipients.AsNoTracking().OrderBy(r => r.LastName).ToListAsync();
            ViewData["SuppliesList"] = await _context.Supplies.AsNoTracking().OrderBy(s => s.Name).ToListAsync();
            return View();
        }

        // POST: SupplyTransactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("SupplyId,RecipientId,DistributedBy,DateDistributed")] SupplyTransaction supplyTransaction)
        {
            var product = await _context.Supplies.FindAsync(supplyTransaction.SupplyId);
            if (product != null)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        supplyTransaction.SupplyTransactionId = Guid.NewGuid();
                        supplyTransaction.LastUpdateId = User.Identity?.Name;
                        supplyTransaction.LastUpdateDateTime = DateTime.Now;
                        _context.Add(supplyTransaction);
                        await HelperMethods.DecreaseAssignedCategoryQuantityByOne(_context, product);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch (DbUpdateException ex)
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue creating the supply transaction.  If the issue persists, please contact an administrator.");
                    }
                }
            }
            ModelState.AddModelError(string.Empty, $"A supply with Id {supplyTransaction.SupplyId} could not be located in the database.");
            ViewData["RecipientsList"] = await _context.Recipients.AsNoTracking().OrderBy(r => r.LastName).ToListAsync();
            ViewData["SuppliesList"] = await _context.Supplies.AsNoTracking().OrderBy(s => s.Name).ToListAsync();
            return View(supplyTransaction);
        }

        // GET: SupplyTransactions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.SupplyTransactions == null)
            {
                return NotFound();
            }

            var productTransaction = await _context.SupplyTransactions.FindAsync(id);
            if (productTransaction == null)
            {
                return NotFound();
            }
            ViewData["RecipientsList"] = await _context.Recipients.AsNoTracking().OrderBy(r => r.LastName).ToListAsync();
            ViewData["SuppliesList"] = await _context.Supplies.AsNoTracking().OrderBy(s => s.Name).ToListAsync();
            return View(productTransaction);
        }

        // POST: SupplyTransactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("SupplyTransactionId,SupplyId,RecipientId,DistributedBy,DateDistributed")] SupplyTransaction supplyTransaction)
        {
            if (id != supplyTransaction.SupplyTransactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    supplyTransaction.LastUpdateId = User.Identity?.Name;
                    supplyTransaction.LastUpdateDateTime = DateTime.Now;
                    _context.Update(supplyTransaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    if (!SupplyTransactionExists(supplyTransaction.SupplyTransactionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue updating the supply transaction.  If the issue persists, please contact an administrator.");
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RecipientsList"] = await _context.Recipients.AsNoTracking().OrderBy(r => r.LastName).ToListAsync();
            ViewData["SuppliesList"] = await _context.Supplies.AsNoTracking().OrderBy(s => s.Name).ToListAsync();
            return View(supplyTransaction);
        }

        // GET: SupplyTransactions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.SupplyTransactions == null)
            {
                return NotFound();
            }

            var supplyTransaction = await _context.SupplyTransactions.AsNoTracking()
                                                                       .Include(p => p.Supply)
                                                                       .Include(p => p.Recipient)
                                                                       .FirstOrDefaultAsync(m => m.SupplyTransactionId == id);
            if (supplyTransaction == null)
            {
                return NotFound();
            }

            return View(supplyTransaction);
        }

        // POST: SupplyTransactions/Delete/5
        [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.SupplyTransactions == null)
            {
                return Problem("Entity set 'SupplyTransactions' is null.");
            }
            var supplyTransaction = await _context.SupplyTransactions.Include(p => p.Supply)
                                                                      .Include(p => p.Recipient)
                                                                      .FirstOrDefaultAsync(m => m.SupplyTransactionId == id);
            if (supplyTransaction != null)
            {
                var product = await _context.Supplies.FindAsync(supplyTransaction.SupplyId);
                if (product != null)
                {
                    try
                    {
                        await HelperMethods.IncreaseAssignedCategoryQuantityByOne(_context, product);
                        _context.SupplyTransactions.Remove(supplyTransaction);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch (DbUpdateException ex)
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue deleting the transaction. If the issue continues please contact an administrator.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, $"A supply with Id {supplyTransaction.SupplyId} could not be located in the database.");
                }
                return View(supplyTransaction);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool SupplyTransactionExists(Guid id)
        {
          return (_context.SupplyTransactions?.Any(e => e.SupplyTransactionId == id)).GetValueOrDefault();
        }
    }
}
