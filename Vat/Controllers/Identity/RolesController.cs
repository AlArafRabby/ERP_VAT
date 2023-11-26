using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vat.Context;
using Vat.Models;

namespace Vat.Controllers.Identity
{
    public class RolesController : Controller
    {
        private readonly iVatContext _context;

        public RolesController(iVatContext context)
        {
            _context = context;
        }

        // GET: Roles
        public async Task<IActionResult> Index()
        {

            List<Role> customers = _context.Roles.ToList();
            Role customer = new Role();
        
            customers.Add(customer);
            return View(customers);

            //List<Role> customers = _context.Roles.ToList();
            //Role customer = new Role();
            //return View(customer);
        }

        // GET: Roles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Roles == null)
            {
                return NotFound();
            }

            var role = await _context.Roles
                .Include(r => r.Organization)
                .FirstOrDefaultAsync(m => m.RoleId == id);
            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

        // GET: Roles/Create
        public IActionResult Create()
        {
            List<Role> customers = new List<Role>();
            Role customer = new Role();

            //customers.Add(customers);
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId");
            return View(customers);
          
            
        }

        // POST: Roles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Create(List<Role> customers)
        {
            foreach (Role customer in customers)
            {
                Role role = new Role();
                // Insert in Customer table and return inserted customerid.

                role.RoleName = customer.RoleName;
                role.OrganizationId = customer.OrganizationId;
                role.RoleDefaultPageId = customer.RoleDefaultPageId;
                role.IsActive = customer.IsActive;
                role.CreatedBy = customer.CreatedBy;
                role.CreatedTime = customer.CreatedTime;
                // Insert in Order table with returned customerid.
                _context.Add(role);
                 _context.SaveChangesAsync();

            }
            try
            {
                // Save changes asynchronously
                 _context.SaveChangesAsync();

                // If successful, return the list of inserted customers as JSON
                return Json(customers);
            }
            catch (Exception ex)
            {
                // Handle the exception (log or return an error response)
                return Json(new { error = ex.Message });
            }
            //if (ModelState.IsValid)
            //{
            //    _context.Add(role);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", role.OrganizationId);
            //return View(role);
        }

        // GET: Roles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Roles == null)
            {
                return NotFound();
            }

            var role = await _context.Roles.FindAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", role.OrganizationId);
            return View(role);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoleId,RoleName,OrganizationId,RoleDefaultPageId,IsActive,CreatedBy,CreatedTime")] Role role)
        {
            if (id != role.RoleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(role);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoleExists(role.RoleId))
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
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", role.OrganizationId);
            return View(role);
        }

        // GET: Roles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Roles == null)
            {
                return NotFound();
            }

            var role = await _context.Roles
                .Include(r => r.Organization)
                .FirstOrDefaultAsync(m => m.RoleId == id);
            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Roles == null)
            {
                return Problem("Entity set 'iVatContext.Roles'  is null.");
            }
            var role = await _context.Roles.FindAsync(id);
            if (role != null)
            {
                _context.Roles.Remove(role);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleExists(int id)
        {
          return (_context.Roles?.Any(e => e.RoleId == id)).GetValueOrDefault();
        }
    }
}
