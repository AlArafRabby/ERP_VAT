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
    public class VehicleTypesController : Controller
    {
        private readonly iVatContext _context;

        public VehicleTypesController(iVatContext context)
        {
            _context = context;
        }

        // GET: VehicleTypes
        public async Task<IActionResult> Index()
        {
            var iVatContext = _context.VehicleTypes.Include(v => v.Organization);
            return View(await iVatContext.ToListAsync());
        }

        // GET: VehicleTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.VehicleTypes == null)
            {
                return NotFound();
            }

            var vehicleType = await _context.VehicleTypes
                .Include(v => v.Organization)
                .FirstOrDefaultAsync(m => m.VehicleTypeId == id);
            if (vehicleType == null)
            {
                return NotFound();
            }

            return View(vehicleType);
        }

        // GET: VehicleTypes/Create
        public IActionResult Create()
        {
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId");
            return View();
        }

        // POST: VehicleTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VehicleTypeId,OrganizationId,VehicleTypeName,IsRequireRegistration,Description,ReferenceKey,IsActive,CreatedBy,CreatedTime")] VehicleType vehicleType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", vehicleType.OrganizationId);
            return View(vehicleType);
        }

        // GET: VehicleTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.VehicleTypes == null)
            {
                return NotFound();
            }

            var vehicleType = await _context.VehicleTypes.FindAsync(id);
            if (vehicleType == null)
            {
                return NotFound();
            }
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", vehicleType.OrganizationId);
            return View(vehicleType);
        }

        // POST: VehicleTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehicleTypeId,OrganizationId,VehicleTypeName,IsRequireRegistration,Description,ReferenceKey,IsActive,CreatedBy,CreatedTime")] VehicleType vehicleType)
        {
            if (id != vehicleType.VehicleTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleTypeExists(vehicleType.VehicleTypeId))
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
            ViewData["OrganizationId"] = new SelectList(_context.Organizations, "OrganizationId", "OrganizationId", vehicleType.OrganizationId);
            return View(vehicleType);
        }

        // GET: VehicleTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.VehicleTypes == null)
            {
                return NotFound();
            }

            var vehicleType = await _context.VehicleTypes
                .Include(v => v.Organization)
                .FirstOrDefaultAsync(m => m.VehicleTypeId == id);
            if (vehicleType == null)
            {
                return NotFound();
            }

            return View(vehicleType);
        }

        // POST: VehicleTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.VehicleTypes == null)
            {
                return Problem("Entity set 'iVatContext.VehicleTypes'  is null.");
            }
            var vehicleType = await _context.VehicleTypes.FindAsync(id);
            if (vehicleType != null)
            {
                _context.VehicleTypes.Remove(vehicleType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleTypeExists(int id)
        {
          return (_context.VehicleTypes?.Any(e => e.VehicleTypeId == id)).GetValueOrDefault();
        }
    }
}
