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
    public class DivisionOrStatesController : Controller
    {
        private readonly iVatContext _context;

        public DivisionOrStatesController(iVatContext context)
        {
            _context = context;
        }

        // GET: DivisionOrStates
        public async Task<IActionResult> Index()
        {
            var iVatContext = _context.DivisionOrStates.Include(d => d.Country).Include(d => d.Organization);
            return View(await iVatContext.ToListAsync());
        }




        [HttpPost, ActionName("GetCountryByOrganization")]
        public JsonResult GetCountryByOrganization(string OrganizationId)
        {
            int catId;
            List<Country> countries = new List<Country>();
            if (!string.IsNullOrEmpty(OrganizationId))
            {
                catId = Convert.ToInt32(OrganizationId);
                countries = _context.Countries.ToList();
                if(countries==null)
                {
                    countries = null;
                }
            }
            return Json(countries);
        }


        // GET: DivisionOrStates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DivisionOrStates == null)
            {
                return NotFound();
            }

            var divisionOrState = await _context.DivisionOrStates
                .Include(d => d.Country)
                .Include(d => d.Organization)
                .FirstOrDefaultAsync(m => m.DivisionOrStateId == id);
            if (divisionOrState == null)
            {
                return NotFound();
            }

            return View(divisionOrState);
        }

        // GET: DivisionOrStates/Create
        public IActionResult Create()
        {
            //ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "Name");
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "Name");
            return View();
        }

        // POST: DivisionOrStates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DivisionOrStateId,OrganizationId,CountryId,DivisionOrStateName,DivisionOrStateShortName,ReferenceKey,CreatedBy,CreatedTime,ModifiedBy,ModifiedTime")] DivisionOrState divisionOrState)
        {
            if (ModelState.IsValid)
            {
                _context.Add(divisionOrState);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "Name", divisionOrState.CountryId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "Name", divisionOrState.OrganizationId);
            return View(divisionOrState);
        }

        // GET: DivisionOrStates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DivisionOrStates == null)
            {
                return NotFound();
            }

            var divisionOrState = await _context.DivisionOrStates.FindAsync(id);
            if (divisionOrState == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "Name", divisionOrState.CountryId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "Name", divisionOrState.OrganizationId);
            return View(divisionOrState);
        }

        // POST: DivisionOrStates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DivisionOrStateId,OrganizationId,CountryId,DivisionOrStateName,DivisionOrStateShortName,ReferenceKey,CreatedBy,CreatedTime,ModifiedBy,ModifiedTime")] DivisionOrState divisionOrState)
        {
            if (id != divisionOrState.DivisionOrStateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(divisionOrState);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DivisionOrStateExists(divisionOrState.DivisionOrStateId))
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
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "Name", divisionOrState.CountryId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "Name", divisionOrState.OrganizationId);
            return View(divisionOrState);
        }

        // GET: DivisionOrStates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DivisionOrStates == null)
            {
                return NotFound();
            }

            var divisionOrState = await _context.DivisionOrStates
                .Include(d => d.Country)
                .Include(d => d.Organization)
                .FirstOrDefaultAsync(m => m.DivisionOrStateId == id);
            if (divisionOrState == null)
            {
                return NotFound();
            }

            return View(divisionOrState);
        }

        // POST: DivisionOrStates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DivisionOrStates == null)
            {
                return Problem("Entity set 'iVatContext.DivisionOrStates'  is null.");
            }
            var divisionOrState = await _context.DivisionOrStates.FindAsync(id);
            if (divisionOrState != null)
            {
                _context.DivisionOrStates.Remove(divisionOrState);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DivisionOrStateExists(int id)
        {
          return (_context.DivisionOrStates?.Any(e => e.DivisionOrStateId == id)).GetValueOrDefault();
        }
    }
}
