using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vat.Context;
using Vat.Models;

namespace Vat.Controllers.Identity
{
    public class IdentityController : Controller
    {
        private readonly iVatContext _context;

        public IdentityController(iVatContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var iVatContext = _context.Users.Include(v => v.Role);
            return View(await iVatContext.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName");
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,FullName,UserName,EmployeeId,EmployeePin,Designation,EmailAddress,Mobile,NidNo,TinNo,Address,UserImageUrl,UserSignUrl,Password,UserTypeId,RoleId,OrganizationId,IsActive,InActivationReason,InActivationTime,InActivatedBy,IsLocked,LastLockTime,LastLockReason,LastUnlockedBy,LastUnlockTime,LastLoginTime,AccessFailedCount,IsDefaultPassword,IsCompanyRepresentative,CreatedBy,CreatedTime,ExpiryDate")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "RoleId", "RoleName");
            TempData["UsersSave"] = "Users Insert Succesfull";
            return View(user);
        }







        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var vendor = await _context.Users.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
         
            return View(vendor);
        }

        // POST: Vendors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,FullName,UserName,EmployeeId,EmployeePin,Designation,EmailAddress,Mobile,NidNo,TinNo,Address,UserImageUrl,UserSignUrl,Password,UserTypeId,RoleId,OrganizationId,IsActive,InActivationReason,InActivationTime,InActivatedBy,IsLocked,LastLockTime,LastLockReason,LastUnlockedBy,LastUnlockTime,LastLoginTime,AccessFailedCount,IsDefaultPassword,IsCompanyRepresentative,CreatedBy,CreatedTime,ExpiryDate")] User users)
        {
            if (id != users.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendorExists(users.UserId))
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
           
            return View(users);
        }

        // GET: Vendors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var vendor = await _context.Users
              
                .FirstOrDefaultAsync(m => m.UserId == id);
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
            if (_context.Users == null)
            {
                return Problem("Entity set 'iVatContext.Users'  is null.");
            }
            var users = await _context.Users.FindAsync(id);
            if (users != null)
            {
                _context.Users.Remove(users);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendorExists(int id)
        {
            return (_context.Users?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
