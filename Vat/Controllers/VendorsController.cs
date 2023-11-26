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
    public class VendorsController : Controller
    {
        private readonly iVatContext _context;

        public VendorsController(iVatContext context)
        {
            _context = context;
        }

        // GET: Vendors
        public async Task<IActionResult> Index()
        {
            var iVatContext = _context.Vendors.Include(v => v.Bank).Include(v => v.BankBranchCountry).Include(v => v.BankBranchDistrictOrCity).Include(v => v.BusinessCategory).Include(v => v.BusinessNature).Include(v => v.Country).Include(v => v.CustomsAndVatcommissionarate).Include(v => v.DistrictOrCity).Include(v => v.DivisionOrState).Include(v => v.Organization);
            return View(await iVatContext.ToListAsync());
        }

        // GET: Vendors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Vendors == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors
                .Include(v => v.Bank)
                .Include(v => v.BankBranchCountry)
                .Include(v => v.BankBranchDistrictOrCity)
                .Include(v => v.BusinessCategory)
                .Include(v => v.BusinessNature)
                .Include(v => v.Country)
                .Include(v => v.CustomsAndVatcommissionarate)
                .Include(v => v.DistrictOrCity)
                .Include(v => v.DivisionOrState)
                .Include(v => v.Organization)
                .FirstOrDefaultAsync(m => m.VendorId == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // GET: Vendors/Create
        public IActionResult Create()
        {
            ViewData["BankId"] = new SelectList(_context.Banks, "BankId", "Name");
            ViewData["BankBranchCountryId"] = new SelectList(_context.Countries, "CountryId", "Name");
            ViewData["BankBranchDistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityName");
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "Name");
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "Name");
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "Name");
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "Name");
            ViewData["DistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityName");
            ViewData["DivisionOrStateId"] = new SelectList(_context.DivisionOrStates, "DivisionOrStateId", "DivisionOrStateName");
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "Name");
            return View();
        }

        // POST: Vendors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VendorId,OrganizationId,VendorOrganizationId,Name,AccountCode,BinNo,NationalIdNo,Tinno,IsVds,Vdsrate,IsTds,Tdsrate,IsRegisteredUnderActNinetyFour,RegistrationNumberUnderActNinetyFour,CustomsAndVatcommissionarateId,ServiceVatCode,CountryId,DistrictOrCityId,DivisionOrStateId,Address,PostCode,ContactNo,EmailAddress,IsActive,ContactPerson,ContactPersonDesignation,ContactPersonMobile,ContactPersonEmailAddress,BankAccountNo,BankRoutingCode,BankId,BankBranchName,BankBranchCountryId,BankBranchDistrictOrCityId,BankBranchAddress,BusinessNatureId,BusinessCategoryId,BusinessCategoryDescription,IsRegisteredAsTurnOverOrg,IsRegistered,IsForeignVendor,ReferenceKey,CreatedBy,CreatedTime,ModifiedBy,ModifiedTime,ApiTransactionId,ExcelDataUploadId")] Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BankId"] = new SelectList(_context.Banks, "BankId", "Name", vendor.BankId);
            ViewData["BankBranchCountryId"] = new SelectList(_context.Countries, "CountryId", "Name", vendor.BankBranchCountryId);
            ViewData["BankBranchDistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityName", vendor.BankBranchDistrictOrCityId);
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "Name", vendor.BusinessCategoryId);
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "Name", vendor.BusinessNatureId);
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "Name", vendor.CountryId);
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "Name", vendor.CustomsAndVatcommissionarateId);
            ViewData["DistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityName", vendor.DistrictOrCityId);
            ViewData["DivisionOrStateId"] = new SelectList(_context.DivisionOrStates, "DivisionOrStateId", "DivisionOrStateName", vendor.DivisionOrStateId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "Name", vendor.OrganizationId);
            TempData["VendorSave"] = "Vendor Insert Succesfull";
            return View(vendor);
        }

        // GET: Vendors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Vendors == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
            ViewData["BankId"] = new SelectList(_context.Banks, "BankId", "BankId", vendor.BankId);
            ViewData["BankBranchCountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", vendor.BankBranchCountryId);
            ViewData["BankBranchDistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityId", vendor.BankBranchDistrictOrCityId);
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "BusinessCategoryId", vendor.BusinessCategoryId);
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "BusinessNatureId", vendor.BusinessNatureId);
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", vendor.CountryId);
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "CustomsAndVatcommissionarateId", vendor.CustomsAndVatcommissionarateId);
            ViewData["DistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityId", vendor.DistrictOrCityId);
            ViewData["DivisionOrStateId"] = new SelectList(_context.DivisionOrStates, "DivisionOrStateId", "DivisionOrStateId", vendor.DivisionOrStateId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", vendor.OrganizationId);
            return View(vendor);
        }

        // POST: Vendors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VendorId,OrganizationId,VendorOrganizationId,Name,AccountCode,BinNo,NationalIdNo,Tinno,IsVds,Vdsrate,IsTds,Tdsrate,IsRegisteredUnderActNinetyFour,RegistrationNumberUnderActNinetyFour,CustomsAndVatcommissionarateId,ServiceVatCode,CountryId,DistrictOrCityId,DivisionOrStateId,Address,PostCode,ContactNo,EmailAddress,IsActive,ContactPerson,ContactPersonDesignation,ContactPersonMobile,ContactPersonEmailAddress,BankAccountNo,BankRoutingCode,BankId,BankBranchName,BankBranchCountryId,BankBranchDistrictOrCityId,BankBranchAddress,BusinessNatureId,BusinessCategoryId,BusinessCategoryDescription,IsRegisteredAsTurnOverOrg,IsRegistered,IsForeignVendor,ReferenceKey,CreatedBy,CreatedTime,ModifiedBy,ModifiedTime,ApiTransactionId,ExcelDataUploadId")] Vendor vendor)
        {
            if (id != vendor.VendorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendorExists(vendor.VendorId))
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
            ViewData["BankId"] = new SelectList(_context.Banks, "BankId", "BankId", vendor.BankId);
            ViewData["BankBranchCountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", vendor.BankBranchCountryId);
            ViewData["BankBranchDistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityId", vendor.BankBranchDistrictOrCityId);
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "BusinessCategoryId", vendor.BusinessCategoryId);
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "BusinessNatureId", vendor.BusinessNatureId);
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", vendor.CountryId);
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "CustomsAndVatcommissionarateId", vendor.CustomsAndVatcommissionarateId);
            ViewData["DistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityId", vendor.DistrictOrCityId);
            ViewData["DivisionOrStateId"] = new SelectList(_context.DivisionOrStates, "DivisionOrStateId", "DivisionOrStateId", vendor.DivisionOrStateId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", vendor.OrganizationId);
            return View(vendor);
        }

        // GET: Vendors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Vendors == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors
                .Include(v => v.Bank)
                .Include(v => v.BankBranchCountry)
                .Include(v => v.BankBranchDistrictOrCity)
                .Include(v => v.BusinessCategory)
                .Include(v => v.BusinessNature)
                .Include(v => v.Country)
                .Include(v => v.CustomsAndVatcommissionarate)
                .Include(v => v.DistrictOrCity)
                .Include(v => v.DivisionOrState)
                .Include(v => v.Organization)
                .FirstOrDefaultAsync(m => m.VendorId == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // POST: Vendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Vendors == null)
            {
                return Problem("Entity set 'iVatContext.Vendors'  is null.");
            }
            var vendor = await _context.Vendors.FindAsync(id);
            if (vendor != null)
            {
                _context.Vendors.Remove(vendor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendorExists(int id)
        {
          return (_context.Vendors?.Any(e => e.VendorId == id)).GetValueOrDefault();
        }
    }
}
