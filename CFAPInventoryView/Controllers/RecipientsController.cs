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
using System.Drawing;
using Microsoft.AspNetCore.Authorization;

namespace CFAPInventoryView.Controllers
{
    [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole},{HelperMethods.MemberRole}")]
    public class RecipientsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<RecipientsController> _logger;

        public RecipientsController(ApplicationDbContext context, ILogger<RecipientsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Recipients
        public async Task<IActionResult> Index()
        {
              return _context.Recipients != null ? 
                          View(await _context.Recipients.AsNoTracking()
                                                    .Include(d => d.SupplyTransactions)
                                                        .ThenInclude(pt => pt.Supply)
                                                    .Include(d => d.BasketTransactions)
                                                        .ThenInclude(bt => bt.Basket)
                                                    .DefaultIfEmpty()
                                                    .ToListAsync()) :
                          Problem("Entity set 'Recipients' is null.");
        }

        // GET: Recipients/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Recipients == null)
            {
                return NotFound();
            }

            var parents = await _context.Recipients.AsNoTracking()
                                                 .Include(d => d.SupplyTransactions)
                                                    .ThenInclude(pt => pt.Supply)
                                                 .Include(d => d.BasketTransactions)
                                                    .ThenInclude(bt => bt.Basket)
                                                 .DefaultIfEmpty()
#pragma warning disable 8602
                                                 .FirstOrDefaultAsync(m => m.RecipientId == id);
#pragma warning restore 8602
            if (parents == null)
            {
                return NotFound();
            }

            return View(parents);
        }

        // GET: Recipients/Create
        public IActionResult Create()
        {
            ViewData["StatesSelectList"] = SelectListBuilder.GetStatesSelectList();
            return View();
        }

        // POST: Recipients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Address1,Address2,City,State,ZipCode,IsFosterParent,IsAdoptiveParent")] Recipient parent)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    parent.RecipientId = Guid.NewGuid();
                    parent.State = HelperMethods.JustTheStateName(parent.State);
                    parent.LastUpdateId = User.Identity?.Name;
                    parent.LastUpdateDateTime = DateTime.Now;
                    _context.Add(parent);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                ModelState.AddModelError(string.Empty, "There was an issue creating the recipient. If the issue continues please contact an administrator.");
            }
            var selectList = SelectListBuilder.GetStatesSelectList(parent.State);
            ViewData["StatesSelectList"] = selectList;
            parent.State = selectList?.FirstOrDefault(s => s.Selected)?.Value;
            return View(parent);
        }

        // GET: Recipients/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Recipients == null)
            {
                return NotFound();
            }

            var parent = await _context.Recipients.FindAsync(id);
            if (parent == null)
            {
                return NotFound();
            }
            var selectList = SelectListBuilder.GetStatesSelectList(parent.State);
            ViewData["StatesSelectList"] = selectList;
            parent.State = selectList?.FirstOrDefault(s => s.Selected)?.Value;
            return View(parent);
        }

        // POST: Recipients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ParentId,FirstName,LastName,Address1,Address2,City,State,ZipCode,IsFosterParent,IsAdoptiveParent")] Recipient parent)
        {
            if (id != parent.RecipientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    parent.State = HelperMethods.JustTheStateName(parent.State);
                    parent.LastUpdateId = User.Identity?.Name;
                    parent.LastUpdateDateTime = DateTime.Now;
                    _context.Update(parent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException ex)
                {
                    if (!ParentExists(parent.RecipientId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"ERROR:  {ex.Message}, StackTrace:  {ex.StackTrace}");
                        ModelState.AddModelError(string.Empty, "There was an issue updating the recipient. If the issue continues please contact an administrator.");
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            var selectList = SelectListBuilder.GetStatesSelectList(parent.State);
            ViewData["StatesSelectList"] = selectList;
            parent.State = selectList?.FirstOrDefault(s => s.Selected)?.Value;
            return View(parent);
        }

        // GET: Recipients/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Recipients == null)
            {
                return NotFound();
            }

            var parent = await _context.Recipients.AsNoTracking()
                                             .Include(d => d.SupplyTransactions)
                                                .ThenInclude(pt => pt.Supply)
                                             .Include(d => d.BasketTransactions)
                                                .ThenInclude(bt => bt.Basket)
                                             .DefaultIfEmpty()
#pragma warning disable 8602
                                             .FirstOrDefaultAsync(m => m.RecipientId == id);
#pragma warning restore 8602
            if (parent == null)
            {
                return NotFound();
            }

            return View(parent);
        }

        // POST: Recipients/Delete/5
        [Authorize(Roles = $"{HelperMethods.AdministratorRole},{HelperMethods.ManagerRole}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Recipients == null)
            {
                return Problem("Entity set 'Recipients' is null.");
            }
            var parent = await _context.Recipients.FindAsync(id);
            if (parent != null)
            {
                _context.Recipients.Remove(parent);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParentExists(Guid id)
        {
          return (_context.Recipients?.Any(e => e.RecipientId == id)).GetValueOrDefault();
        }
    }
}
