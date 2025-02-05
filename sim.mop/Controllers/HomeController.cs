using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sim.mop.Models;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sim.mop.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private MopContext _context;

        public HomeController(MopContext context)
        {
            _context = context;
            //_context.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.NoTracking;
        }
		//public IActionResult Index()
		//{
		//    return View();
		//}

				public async Task<IActionResult> Index()

		{
			
			string name = HttpContext.Session.GetString("fldUserName");
			string Name = HttpContext.Session.GetString("fldName");
		
			//if (User == null)
			//{
			//	ViewBag.fldName = "Guest"; // Default value if session is not set  
			//}
			//else


			ViewBag.fldUserName = name;
			ViewBag.fldName = Name;
		




			return _context.VwDataTables != null ?
                           View(await _context.VwDataTables.ToListAsync()) :
                           Problem("Entity set 'mop.VwDataTables'  is null.");
		
		}

		

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

		// GET: TblTitles/Create
		public IActionResult Create()
		{
			return View();
		}
		public IActionResult Details()
		{
			return View();
		}
		// POST: TblTitles/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TblInternalConstruct tblInternalConstruct)
        //, [Bind("FldId,FldMgcode,FldMesc,FldUnit,FldMesccenter,FldType,FldRahbordi,FldPorMasraf,FldValue,FldInternalConstruct,FldDepth,FldConstructorName,FldConstructorId,FldConstructPlanYear,FldDescHeader,FldNeedOfYear,FldHasCert,FldCertRefrence,FldCertPlanYear,FldRegisterDate,FldRegUser")] Dlib D)
        {
			if (ModelState.IsValid)
			{
				string name = HttpContext.Session.GetString("fldUserName");
				tblInternalConstruct.fldRegUser=name;
				//_context.TblInternalConstructs.Add(newConstruct);
				_context.Add(tblInternalConstruct);
				await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            return View(Index);
        }


		[HttpGet]
		public IActionResult GetItem(int fldID)
		{
			var item = _context.TblInternalConstructs.Find(fldID);
			if (item == null)
			{
				return NotFound();
			}
			return Json(item);
		}

		public async Task<IActionResult> Edit(int? fldID)
		{
			if (fldID == null)
			{
				return NotFound();
			}

			var tblInternalConstruct = await _context.TblInternalConstructs.FindAsync(fldID);
			if (tblInternalConstruct == null)
			{
				return NotFound();
			}
			return View(tblInternalConstruct);
		}

		[HttpPost, ActionName("Edit")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Update(int fldID,TblInternalConstruct tblInternalConstruct)
		{
			
			if (fldID != tblInternalConstruct.fldID)
			{
				return NotFound();
			}
			if (ModelState.IsValid)
			{

				try
				{

					string modalName = tblInternalConstruct.fldConstructorName;

					_context.Update(tblInternalConstruct);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!TblInternalConstructExists(tblInternalConstruct.fldID))
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
			return View(tblInternalConstruct);
		}

		private bool TblInternalConstructExists(int fldID)
        {
            throw new NotImplementedException();
        }

		public async Task<IActionResult> Delete(int? fldID)
		{
			if (fldID == null || _context.TblInternalConstructs == null)
			{
				return NotFound();
			}

			var tblInternalConstruct = await _context.TblInternalConstructs
				.FirstOrDefaultAsync(m => m.fldID == fldID);
			if (tblInternalConstruct == null)
			{
				return NotFound();
			}

			return View(tblInternalConstruct);
		}


		//POST: TblTitles/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (_context.TblInternalConstructs == null)
			{
				return Problem("Entity set 'MopContext.TblInternalConstructs'  is null.");
			}
			var tblInternalConstruct = await _context.TblInternalConstructs.FindAsync(id);
			if (tblInternalConstruct != null)
			{
				_context.TblInternalConstructs.Remove(tblInternalConstruct);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}


	}
}
 