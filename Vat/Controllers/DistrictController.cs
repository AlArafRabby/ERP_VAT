using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vat.Context;
using Vat.Models;

namespace Vat.Controllers
{
    public class DistrictController : Controller
    {
        private readonly iVatContext _context;

        public DistrictController(iVatContext context)
        {
            _context = context;
        }

        // GET: Vendors
        public async Task<IActionResult> Index()
        {
            var iVatContext = _context.Districts;
            return View(await iVatContext.ToListAsync());
        }

        // GET: Vendors/Create
        public IActionResult Create()
        {
            ViewData["DivisionOrStateId"] = new SelectList(_context.DivisionOrStates, "DivisionOrStateId", "DivisionOrStateName");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DistrictId,Name,NameInBangla")] District district)
        {
            if (ModelState.IsValid)
            {
                _context.Add(district);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DivisionOrStateId"] = new SelectList(_context.DivisionOrStates, "DivisionOrStateId", "DivisionOrStateName");
            TempData["DistrictSave"] = "District Insert Succesfull";
            return View(district);
        }
    }
}
