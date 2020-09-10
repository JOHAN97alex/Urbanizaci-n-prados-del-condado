using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Urbanizacion.Web.Contexts;
using Urbanizacion.Web.Data.Entities;

namespace Urbanizacion.Web.Controllers
{
    public class TBL_ROLController : Controller
    {
        private readonly AppDbContext _context;

        public TBL_ROLController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TBL_ROL
        public async Task<IActionResult> Index()
        {
            return View(await _context.TBL_ROL.ToListAsync());
        }

        // GET: TBL_ROL/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_ROL = await _context.TBL_ROL
                .FirstOrDefaultAsync(m => m.ROL_ID == id);
            if (tBL_ROL == null)
            {
                return NotFound();
            }

            return View(tBL_ROL);
        }

        // GET: TBL_ROL/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TBL_ROL/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ROL_ID,ROL_DESCRIPCION,ROL_FECHACREACION,ROL_ESTADO")] TBL_ROL tBL_ROL)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBL_ROL);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBL_ROL);
        }

        // GET: TBL_ROL/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_ROL = await _context.TBL_ROL.FindAsync(id);
            if (tBL_ROL == null)
            {
                return NotFound();
            }
            return View(tBL_ROL);
        }

        // POST: TBL_ROL/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ROL_ID,ROL_DESCRIPCION,ROL_FECHACREACION,ROL_ESTADO")] TBL_ROL tBL_ROL)
        {
            if (id != tBL_ROL.ROL_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBL_ROL);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBL_ROLExists(tBL_ROL.ROL_ID))
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
            return View(tBL_ROL);
        }

        // GET: TBL_ROL/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_ROL = await _context.TBL_ROL
                .FirstOrDefaultAsync(m => m.ROL_ID == id);
            if (tBL_ROL == null)
            {
                return NotFound();
            }

            return View(tBL_ROL);
        }

        // POST: TBL_ROL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tBL_ROL = await _context.TBL_ROL.FindAsync(id);
            _context.TBL_ROL.Remove(tBL_ROL);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBL_ROLExists(int id)
        {
            return _context.TBL_ROL.Any(e => e.ROL_ID == id);
        }
    }
}
