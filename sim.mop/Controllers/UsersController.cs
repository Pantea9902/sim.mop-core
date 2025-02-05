using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sim.mop.Models;
using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace sim.mop.Controllers
{
    public class UsersController : Controller
    {
        private readonly MopContext _context;

        public UsersController(MopContext context)
        {
            _context = context;
        }
		[HttpGet]
		public IActionResult Login()
		{
            TblUser user = new TblUser();
            return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login( TblUser User)
		{
			//[Bind("fldId,fldMGCode,fldName,fldUserName,fldPassword,fldIsActive,fldPermission")]


			if (ModelState.IsValid)
			{
				var Person = from m in _context.TblUsers select m;
			
				Person = Person.Where(s => s.fldUserName.Contains(User.fldUserName));

                if (Person.Count() != 0)
				{
					if (Person.First().fldPassword == User.fldPassword)
					{
					
						HttpContext.Session.SetString("fldUserName", User.fldUserName);
						HttpContext.Session.SetString("fldName", Person.First().fldName??"");

						string name = HttpContext.Session.GetString("fldUserName");
						//HttpContext.Session.SetString("fldName", User.fldName);
						string Name = HttpContext.Session.GetString("fldName");
						return RedirectToAction("Index", "Home");
                        
					}
				}

			}
            ViewBag.Message = "اطلاعات ورود نادرست است.";
            return View("_Message");

        }



		// GET: TblUsers
		public async Task<IActionResult> Index()
        {
            return View(await _context.TblUsers.ToListAsync());
        }

        // GET: TblUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblUser = await _context.TblUsers
                .FirstOrDefaultAsync(m => m.fldId == id);
            if (tblUser == null)
            {
                return NotFound();
            }

            return View(tblUser);
        }

        // GET: TblUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FldId,FldMgCode,FldName,FldUserName,FldPassword,FldIsActive,FldPermission")] TblUser tblUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblUser);
        }

        // GET: TblUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblUser = await _context.TblUsers.FindAsync(id);
            if (tblUser == null)
            {
                return NotFound();
            }
            return View(tblUser);
        }

        // POST: TblUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FldId,FldMgCode,FldName,FldUserName,FldPassword,FldIsActive,FldPermission")] TblUser tblUser)
        {
            if (id != tblUser.fldId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblUserExists(tblUser.fldId))
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
            return View(tblUser);
        }

        // GET: TblUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblUser = await _context.TblUsers
                .FirstOrDefaultAsync(m => m.fldId == id);
            if (tblUser == null)
            {
                return NotFound();
            }

            return View(tblUser);
        }

        // POST: TblUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblUser = await _context.TblUsers.FindAsync(id);
            if (tblUser != null)
            {
                _context.TblUsers.Remove(tblUser);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblUserExists(int id)
        {
            return _context.TblUsers.Any(e => e.fldId == id);
        }
    }
}
