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
    public class CustomersController : Controller
    {
        private readonly iVatContext _context;

        public CustomersController(iVatContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var iVatContext = _context.Customers.Include(c => c.Bank).Include(c => c.BankBranchCountry).Include(c => c.BankBranchDistrictOrCity).Include(c => c.BusinessCategory).Include(c => c.BusinessNature).Include(c => c.Country).Include(c => c.CustomsAndVatcommissionarate).Include(c => c.Organization);
            return View(await iVatContext.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.Bank)
                .Include(c => c.BankBranchCountry)
                .Include(c => c.BankBranchDistrictOrCity)
                .Include(c => c.BusinessCategory)
                .Include(c => c.BusinessNature)
                .Include(c => c.Country)
                .Include(c => c.CustomsAndVatcommissionarate)
                .Include(c => c.Organization)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["BankId"] = new SelectList(_context.Banks, "BankId", "BankId");
            ViewData["BankBranchCountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId");
            ViewData["BankBranchDistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityId");
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "BusinessCategoryId");
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "BusinessNatureId");
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId");
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "CustomsAndVatcommissionarateId");
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,OrganizationId,CustomerOrganizationId,Name,AccountCode,Bin,Nidno,Tinno,IsVds,Vdsrate,IsTds,Tdsrate,IsRegisteredUnderActNinetyFour,RegistrationNumberUnderActNinetyFour,CustomsAndVatcommissionarateId,ServiceVatCode,CountryId,DistrictOrCityId,DivisionOrStateId,Address,PostCode,PhoneNo,EmailAddress,IsActive,BusinessNatureId,BusinessCategoryId,BusinessCategoryDescription,IsForeignCustomer,IsFullExportOriented,ContactPerson,ContactPersonDesignation,ContactPersonMobile,ContactPersonEmailAddress,DeliveryCountryId,DeliveryDistrictOrCityId,DeliveryDivisionOrStateId,DeliveryAddress,DeliveryContactPerson,DeliveryContactPersonDesignation,DeliveryContactPersonMobile,DeliveryContactPersonEmailAddress,BankAccountNo,BankRoutingCode,BankId,BankBranchName,BankBranchCountryId,BankBranchDistrictOrCityId,BankBranchAddress,ReferenceKey,CreatedBy,CreatedTime,ModifiedBy,ModifiedTime,ApiTransactionId,ExcelDataUploadId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BankId"] = new SelectList(_context.Banks, "BankId", "BankId", customer.BankId);
            ViewData["BankBranchCountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", customer.BankBranchCountryId);
            ViewData["BankBranchDistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityId", customer.BankBranchDistrictOrCityId);
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "BusinessCategoryId", customer.BusinessCategoryId);
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "BusinessNatureId", customer.BusinessNatureId);
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", customer.CountryId);
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "CustomsAndVatcommissionarateId", customer.CustomsAndVatcommissionarateId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", customer.OrganizationId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["BankId"] = new SelectList(_context.Banks, "BankId", "BankId", customer.BankId);
            ViewData["BankBranchCountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", customer.BankBranchCountryId);
            ViewData["BankBranchDistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityId", customer.BankBranchDistrictOrCityId);
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "BusinessCategoryId", customer.BusinessCategoryId);
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "BusinessNatureId", customer.BusinessNatureId);
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", customer.CountryId);
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "CustomsAndVatcommissionarateId", customer.CustomsAndVatcommissionarateId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", customer.OrganizationId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,OrganizationId,CustomerOrganizationId,Name,AccountCode,Bin,Nidno,Tinno,IsVds,Vdsrate,IsTds,Tdsrate,IsRegisteredUnderActNinetyFour,RegistrationNumberUnderActNinetyFour,CustomsAndVatcommissionarateId,ServiceVatCode,CountryId,DistrictOrCityId,DivisionOrStateId,Address,PostCode,PhoneNo,EmailAddress,IsActive,BusinessNatureId,BusinessCategoryId,BusinessCategoryDescription,IsForeignCustomer,IsFullExportOriented,ContactPerson,ContactPersonDesignation,ContactPersonMobile,ContactPersonEmailAddress,DeliveryCountryId,DeliveryDistrictOrCityId,DeliveryDivisionOrStateId,DeliveryAddress,DeliveryContactPerson,DeliveryContactPersonDesignation,DeliveryContactPersonMobile,DeliveryContactPersonEmailAddress,BankAccountNo,BankRoutingCode,BankId,BankBranchName,BankBranchCountryId,BankBranchDistrictOrCityId,BankBranchAddress,ReferenceKey,CreatedBy,CreatedTime,ModifiedBy,ModifiedTime,ApiTransactionId,ExcelDataUploadId")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
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
            ViewData["BankId"] = new SelectList(_context.Banks, "BankId", "BankId", customer.BankId);
            ViewData["BankBranchCountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", customer.BankBranchCountryId);
            ViewData["BankBranchDistrictOrCityId"] = new SelectList(_context.DistrictOrCities, "DistrictOrCityId", "DistrictOrCityId", customer.BankBranchDistrictOrCityId);
            ViewData["BusinessCategoryId"] = new SelectList(_context.BusinessCategories, "BusinessCategoryId", "BusinessCategoryId", customer.BusinessCategoryId);
            ViewData["BusinessNatureId"] = new SelectList(_context.BusinessNatures, "BusinessNatureId", "BusinessNatureId", customer.BusinessNatureId);
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId", customer.CountryId);
            ViewData["CustomsAndVatcommissionarateId"] = new SelectList(_context.CustomsAndVatcommissionarates, "CustomsAndVatcommissionarateId", "CustomsAndVatcommissionarateId", customer.CustomsAndVatcommissionarateId);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", customer.OrganizationId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Customers == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.Bank)
                .Include(c => c.BankBranchCountry)
                .Include(c => c.BankBranchDistrictOrCity)
                .Include(c => c.BusinessCategory)
                .Include(c => c.BusinessNature)
                .Include(c => c.Country)
                .Include(c => c.CustomsAndVatcommissionarate)
                .Include(c => c.Organization)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Customers == null)
            {
                return Problem("Entity set 'iVatContext.Customers'  is null.");
            }
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
          return (_context.Customers?.Any(e => e.CustomerId == id)).GetValueOrDefault();
        }
    }
}
