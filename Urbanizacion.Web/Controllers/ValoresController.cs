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
    public class ValoresController : Controller
    {
        private readonly AppDbContext _context;

        public ValoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Valores
        public async Task<IActionResult> Index()
        {
            return View(await _context.TBL_VALOR.ToListAsync());
        }

        // GET: Valores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_VALOR = await _context.TBL_VALOR
                .FirstOrDefaultAsync(m => m.VAL_ID == id);
            if (tBL_VALOR == null)
            {
                return NotFound();
            }

            return View(tBL_VALOR);
        }

        // GET: Valores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Valores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VAL_ID,VAL_VALOR,VAL_FECHAINICIO,VAL_FECHAFIN,VAL_FECHACREACION,VAL_ESTADO")] TBL_VALOR tBL_VALOR)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tBL_VALOR);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tBL_VALOR);
        }

        // GET: Valores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_VALOR = await _context.TBL_VALOR.FindAsync(id);
            if (tBL_VALOR == null)
            {
                return NotFound();
            }
            return View(tBL_VALOR);
        }

        // POST: Valores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VAL_ID,VAL_VALOR,VAL_FECHAINICIO,VAL_FECHAFIN,VAL_FECHACREACION,VAL_ESTADO")] TBL_VALOR tBL_VALOR)
        {
            if (id != tBL_VALOR.VAL_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tBL_VALOR);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TBL_VALORExists(tBL_VALOR.VAL_ID))
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
            return View(tBL_VALOR);
        }

        // GET: Valores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tBL_VALOR = await _context.TBL_VALOR
                .FirstOrDefaultAsync(m => m.VAL_ID == id);
            if (tBL_VALOR == null)
            {
                return NotFound();
            }

            return View(tBL_VALOR);
        }

        // POST: Valores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tBL_VALOR = await _context.TBL_VALOR.FindAsync(id);
            _context.TBL_VALOR.Remove(tBL_VALOR);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TBL_VALORExists(int id)
        {
            return _context.TBL_VALOR.Any(e => e.VAL_ID == id);
        }
    }
}
