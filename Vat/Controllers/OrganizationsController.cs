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
    public class OrganizationsController : Controller
    {
        private readonly iVatContext _context;

        public OrganizationsController(iVatContext context)
        {
            _context = context;
        }

        // GET: Organizations
        public async Task<IActionResult> Index()
        {
            var iVatContext = _context.Organizations.Include(o => o.BusinessCategory).Include(o => o.BusinessNature).Include(o => o.CustomsAndVatcommissionarate).Include(o => o.FinancialActivityNature);
            return View(await iVatContext.ToListAsync());
        }

        // GET: Organizations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Organizations == null)
            {
                return NotFound();
            }

            var organization = await _context.Organizations
                .Include(o => o.BusinessCategory)
                .Include(o => o.BusinessNature)
                .Include(o => o.CustomsAndVatcommissionarate)
                .Include(o => o.FinancialActivityNature)
                .FirstOrDefaultAsync(m => m.OrganizationId == id);
            if (organization == null)
            {
                return NotFound();
            }

            return View(organization);
        }

        // GET: Organizations/Create
        public IActionResult Create()
        {
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "BusinessCategoryId");
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "BusinessNatureId");
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "CustomsAndVatcommissionarateId");
            ViewData["FinancialActivityNatureId"] = new SelectList(_context.FinancialActivityNatures, "FinancialActivityNatureId", "FinancialActivityNatureId");
            return View();
        }

        // POST: Organizations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrganizationId,Name,ParentOrganizationId,Code,VatregNo,Bin,CustomsAndVatcommissionarateId,FinancialActivityNatureId,BusinessNatureId,BusinessCategoryId,BusinessCategoryDescription,IsProductionCompany,IsDeductVatInSource,IsSellStandardVatProduct,CertificateNo,EmailAddress,Mobile,Address,CountryId,CityId,VatResponsiblePersonName,VatResponsiblePersonDesignation,VatResponsiblePersonMobileNo,VatResponsiblePersonEmailAddress,VatResponsiblePersonSignUrl,IsActive,EnlistedNo,PostalCode,IsSaleSimplified,IsImposeServiceCharge,ServiceChargePercent,IsUserSignInSalesTaxInvoice,IsRequireSku,IsRequireSkuId,IsRequireGoodsId,IsRequirePartNo,IsRequireComplecatedInformation,InvoiceNameEng,InvoiceNameBan,CreatedBy,CreatedTime,ModifiedBy,ModifiedTime")] Organization organization)
        {
            if (ModelState.IsValid)
            {
                _context.Add(organization);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "BusinessCategoryId", organization.BusinessCategoryId);
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "BusinessNatureId", organization.BusinessNatureId);
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "CustomsAndVatcommissionarateId", organization.CustomsAndVatcommissionarateId);
            ViewData["FinancialActivityNatureId"] = new SelectList(_context.FinancialActivityNatures, "FinancialActivityNatureId", "FinancialActivityNatureId", organization.FinancialActivityNatureId);
            return View(organization);
        }

        // GET: Organizations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Organizations == null)
            {
                return NotFound();
            }

            var organization = await _context.Organizations.FindAsync(id);
            if (organization == null)
            {
                return NotFound();
            }
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "BusinessCategoryId", organization.BusinessCategoryId);
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "BusinessNatureId", organization.BusinessNatureId);
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "CustomsAndVatcommissionarateId", organization.CustomsAndVatcommissionarateId);
            ViewData["FinancialActivityNatureId"] = new SelectList(_context.FinancialActivityNatures, "FinancialActivityNatureId", "FinancialActivityNatureId", organization.FinancialActivityNatureId);
            return View(organization);
        }

        // POST: Organizations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrganizationId,Name,ParentOrganizationId,Code,VatregNo,Bin,CustomsAndVatcommissionarateId,FinancialActivityNatureId,BusinessNatureId,BusinessCategoryId,BusinessCategoryDescription,IsProductionCompany,IsDeductVatInSource,IsSellStandardVatProduct,CertificateNo,EmailAddress,Mobile,Address,CountryId,CityId,VatResponsiblePersonName,VatResponsiblePersonDesignation,VatResponsiblePersonMobileNo,VatResponsiblePersonEmailAddress,VatResponsiblePersonSignUrl,IsActive,EnlistedNo,PostalCode,IsSaleSimplified,IsImposeServiceCharge,ServiceChargePercent,IsUserSignInSalesTaxInvoice,IsRequireSku,IsRequireSkuId,IsRequireGoodsId,IsRequirePartNo,IsRequireComplecatedInformation,InvoiceNameEng,InvoiceNameBan,CreatedBy,CreatedTime,ModifiedBy,ModifiedTime")] Organization organization)
        {
            if (id != organization.OrganizationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(organization);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrganizationExists(organization.OrganizationId))
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
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "BusinessCategoryId", organization.BusinessCategoryId);
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "BusinessNatureId", organization.BusinessNatureId);
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "CustomsAndVatcommissionarateId", organization.CustomsAndVatcommissionarateId);
            ViewData["FinancialActivityNatureId"] = new SelectList(_context.FinancialActivityNatures, "FinancialActivityNatureId", "FinancialActivityNatureId", organization.FinancialActivityNatureId);
            return View(organization);
        }

        // GET: Organizations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Organizations == null)
            {
                return NotFound();
            }

            var organization = await _context.Organizations
                .Include(o => o.BusinessCategory)
                .Include(o => o.BusinessNature)
                .Include(o => o.CustomsAndVatcommissionarate)
                .Include(o => o.FinancialActivityNature)
                .FirstOrDefaultAsync(m => m.OrganizationId == id);
            if (organization == null)
            {
                return NotFound();
            }

            return View(organization);
        }

        // POST: Organizations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Organizations == null)
            {
                return Problem("Entity set 'iVatContext.Organizations'  is null.");
            }
            var organization = await _context.Organizations.FindAsync(id);
            if (organization != null)
            {
                _context.Organizations.Remove(organization);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrganizationExists(int id)
        {
          return (_context.Organizations?.Any(e => e.OrganizationId == id)).GetValueOrDefault();
        }
    }
}
