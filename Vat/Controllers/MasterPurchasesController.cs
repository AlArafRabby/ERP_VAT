using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vat.Context;
using Vat.Models;

namespace Vat.Controllers
{
    public class MasterPurchasesController : Controller
    {
        private readonly iVatContext _context;

        public MasterPurchasesController(iVatContext context)
        {
            _context = context;
        }

        // GET: MasterPurchases
        public async Task<IActionResult> Index()
        {
              return _context.MasterPurchases != null ? 
                          View(await _context.MasterPurchases.ToListAsync()) :
                          Problem("Entity set 'iVatContext.MasterPurchases'  is null.");
        }

        // GET: MasterPurchases/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.MasterPurchases == null)
            {
                return NotFound();
            }

            var masterPurchase = await _context.MasterPurchases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (masterPurchase == null)
            {
                return NotFound();
            }

            return View(masterPurchase);
        }

        // GET: MasterPurchases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterPurchases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MasterPurchase masterPurchase)
        {
            if (ModelState.IsValid && masterPurchase.MasterPurchaseDetails!=null && masterPurchase.MasterPurchaseDetails.Count>0)
            {
                _context.MasterPurchases.Add(masterPurchase);
                var isPurchaseAdded = _context.SaveChanges() > 0;
                if(isPurchaseAdded)
                {
                    return View(masterPurchase);
                }
            }
            return View();

        }



        private List<SelectListItem> GetDefaultSelectListItem()
        {
            var items = new List<SelectListItem>()
            {   new SelectListItem()
                {
                    Value="",Text="---Select---"
                }
            };
            return items;

        }

        // GET: MasterPurchases/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.MasterPurchases == null)
            {
                return NotFound();
            }

            var masterPurchase = await _context.MasterPurchases.FindAsync(id);
            if (masterPurchase == null)
            {
                return NotFound();
            }
            return View(masterPurchase);
        }

        // POST: MasterPurchases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Customername,CustomerContactNo,Description,PurchaseDate")] MasterPurchase masterPurchase)
        {
            if (id != masterPurchase.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(masterPurchase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MasterPurchaseExists(masterPurchase.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(masterPurchase);
        }

        // GET: MasterPurchases/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.MasterPurchases == null)
            {
                return NotFound();
            }

            var masterPurchase = await _context.MasterPurchases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (masterPurchase == null)
            {
                return NotFound();
            }

            return View(masterPurchase);
        }

        // POST: MasterPurchases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.MasterPurchases == null)
            {
                return Problem("Entity set 'iVatContext.MasterPurchases'  is null.");
            }
            var masterPurchase = await _context.MasterPurchases.FindAsync(id);
            if (masterPurchase != null)
            {
                _context.MasterPurchases.Remove(masterPurchase);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MasterPurchaseExists(long id)
        {
          return (_context.MasterPurchases?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
