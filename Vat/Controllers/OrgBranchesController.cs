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
    public class OrgBranchesController : Controller
    {
        private readonly iVatContext _context;

        public OrgBranchesController(iVatContext context)
        {
            _context = context;
        }

        // GET: OrgBranches
        public async Task<IActionResult> Index()
        {
            var iVatContext = _context.OrgBranches.Include(o => o.Country).Include(o => o.District).Include(o => o.OrgBranchType).Include(o => o.Organization);
            return View(await iVatContext.ToListAsync());
        }

        // GET: OrgBranches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OrgBranches == null)
            {
                return NotFound();
            }

            var orgBranch = await _context.OrgBranches
                .Include(o => o.Country)
                .Include(o => o.District)
                .Include(o => o.OrgBranchType)
                .Include(o => o.Organization)
                .FirstOrDefaultAsync(m => m.OrgBranchId == id);
            if (orgBranch == null)
            {
                return NotFound();
            }

            return View(orgBranch);
        }

        // GET: OrgBranches/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId");
            ViewData["DistrictId"] = new SelectList(_context.Districts, "DistrictId", "DistrictId");
            ViewData["OrgBranchTypeId"] = new SelectList(_context.OrgBranchTypes, "OrgBranchTypeId", "OrgBranchTypeId");
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId");
            return View();
        }

        // POST: OrgBranches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrgBranchId,OrgBranchTypeId,OrganizationId,Name,Code,CustomsAndVatcommissionarateId,FinancialActivityNatureId,BusinessNatureId,BusinessCategoryId,BusinessCategoryDescription,IsSellStandardVatProduct,EmailAddress,Mobile,Address,CountryId,DistrictId,VatResponsiblePersonName,VatResponsiblePersonDesignation,VatResponsiblePersonMobileNo,VatResponsiblePersonEmailAddress,VatResponsiblePersonSignUrl,IsActive,PostalCode,CreatedBy,CreatedTime,ModifiedBy,ModifiedTime,ApiTransactionId,ReferenceKey,ExcelDataUploadId")] OrgBranch orgBranch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orgBranch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", orgBranch.CountryId);
            ViewData["DistrictId"] = new SelectList(_context.Districts, "DistrictId", "DistrictId", orgBranch.DistrictId);
            ViewData["OrgBranchTypeId"] = new SelectList(_context.OrgBranchTypes, "OrgBranchTypeId", "OrgBranchTypeId", orgBranch.OrgBranchTypeId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", orgBranch.OrganizationId);
            return View(orgBranch);
        }

        // GET: OrgBranches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OrgBranches == null)
            {
                return NotFound();
            }

            var orgBranch = await _context.OrgBranches.FindAsync(id);
            if (orgBranch == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", orgBranch.CountryId);
            ViewData["DistrictId"] = new SelectList(_context.Districts, "DistrictId", "DistrictId", orgBranch.DistrictId);
            ViewData["OrgBranchTypeId"] = new SelectList(_context.OrgBranchTypes, "OrgBranchTypeId", "OrgBranchTypeId", orgBranch.OrgBranchTypeId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", orgBranch.OrganizationId);
            return View(orgBranch);
        }

        // POST: OrgBranches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrgBranchId,OrgBranchTypeId,OrganizationId,Name,Code,CustomsAndVatcommissionarateId,FinancialActivityNatureId,BusinessNatureId,BusinessCategoryId,BusinessCategoryDescription,IsSellStandardVatProduct,EmailAddress,Mobile,Address,CountryId,DistrictId,VatResponsiblePersonName,VatResponsiblePersonDesignation,VatResponsiblePersonMobileNo,VatResponsiblePersonEmailAddress,VatResponsiblePersonSignUrl,IsActive,PostalCode,CreatedBy,CreatedTime,ModifiedBy,ModifiedTime,ApiTransactionId,ReferenceKey,ExcelDataUploadId")] OrgBranch orgBranch)
        {
            if (id != orgBranch.OrgBranchId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orgBranch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrgBranchExists(orgBranch.OrgBranchId))
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
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", orgBranch.CountryId);
            ViewData["DistrictId"] = new SelectList(_context.Districts, "DistrictId", "DistrictId", orgBranch.DistrictId);
            ViewData["OrgBranchTypeId"] = new SelectList(_context.OrgBranchTypes, "OrgBranchTypeId", "OrgBranchTypeId", orgBranch.OrgBranchTypeId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", orgBranch.OrganizationId);
            return View(orgBranch);
        }

        // GET: OrgBranches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OrgBranches == null)
            {
                return NotFound();
            }

            var orgBranch = await _context.OrgBranches
                .Include(o => o.Country)
                .Include(o => o.District)
                .Include(o => o.OrgBranchType)
                .Include(o => o.Organization)
                .FirstOrDefaultAsync(m => m.OrgBranchId == id);
            if (orgBranch == null)
            {
                return NotFound();
            }

            return View(orgBranch);
        }

        // POST: OrgBranches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OrgBranches == null)
            {
                return Problem("Entity set 'iVatContext.OrgBranches'  is null.");
            }
            var orgBranch = await _context.OrgBranches.FindAsync(id);
            if (orgBranch != null)
            {
                _context.OrgBranches.Remove(orgBranch);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrgBranchExists(int id)
        {
          return (_context.OrgBranches?.Any(e => e.OrgBranchId == id)).GetValueOrDefault();
        }
    }
}
