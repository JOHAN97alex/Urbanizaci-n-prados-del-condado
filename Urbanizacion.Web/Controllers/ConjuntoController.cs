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
    public class ConjuntoController : Controller
    {
        private readonly AppDbContext _context;

        public ConjuntoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Conjunto
        public async Task<IActionResult> Index()
        {
            return View(await _context.TBL_CONJUNTO.ToListAsync());
        }

        // GET: Conjunto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_CONJUNTO = await _context.TBL_CONJUNTO
                .FirstOrDefaultAsync(m => m.CON_ID == id);
            if (tBL_CONJUNTO == null)
            {
                return NotFound();
            }

            return View(tBL_CONJUNTO);
        }

        // GET: Conjunto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Conjunto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CON_ID,CON_NOMBRE,CON_IDENTIFICACION,CON_TELEFONO")] TBL_CONJUNTO tBL_CONJUNTO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBL_CONJUNTO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBL_CONJUNTO);
        }

        // GET: Conjunto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_CONJUNTO = await _context.TBL_CONJUNTO.FindAsync(id);
            if (tBL_CONJUNTO == null)
            {
                return NotFound();
            }
            return View(tBL_CONJUNTO);
        }

        // POST: Conjunto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CON_ID,CON_NOMBRE,CON_IDENTIFICACION,CON_TELEFONO")] TBL_CONJUNTO tBL_CONJUNTO)
        {
            if (id != tBL_CONJUNTO.CON_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBL_CONJUNTO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBL_CONJUNTOExists(tBL_CONJUNTO.CON_ID))
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
            return View(tBL_CONJUNTO);
        }

        // GET: Conjunto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_CONJUNTO = await _context.TBL_CONJUNTO
                .FirstOrDefaultAsync(m => m.CON_ID == id);
            if (tBL_CONJUNTO == null)
            {
                return NotFound();
            }

            return View(tBL_CONJUNTO);
        }

        // POST: Conjunto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tBL_CONJUNTO = await _context.TBL_CONJUNTO.FindAsync(id);
            _context.TBL_CONJUNTO.Remove(tBL_CONJUNTO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBL_CONJUNTOExists(int id)
        {
            return _context.TBL_CONJUNTO.Any(e => e.CON_ID == id);
        }
    }
}
