using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urbanizacion.Web.Contexts;
using Urbanizacion.Web.Data.Entities;
using Urbanizacion.Web.Helpers;
using Urbanizacion.Web.Models;

namespace Urbanizacion.Web.Controllers
{
    public class PropietariosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IImageHelper _imageHelper;
        private readonly IConverterHelper _converterHelper;

        public PropietariosController(
            AppDbContext context,
            IImageHelper imageHelper,
            IConverterHelper converterHelper)
        {
            _context = context;
            _imageHelper = imageHelper;
            _converterHelper = converterHelper;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context
                .TBL_PROPIETARIO
                .Include(t => t.Vehiculo)
                //.Include(t => t.Pago)
                //.Include(t => t.Negocio)
                .OrderBy(t => t.PRO_LOTE)
                .ToListAsync());
        }

        //METODO PARA CREAR

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PropietarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                var propietario = _converterHelper.ToTBL_PROPIETARIO(model, true);
                _context.Add(propietario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        //METODO PARA EDITAR
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TBL_PROPIETARIO propietarioEntity = await _context.TBL_PROPIETARIO.FindAsync(id);
            if (propietarioEntity == null)
            {
                return NotFound();
            }

            PropietarioViewModel model = _converterHelper.ToPropietarioViewModel(propietarioEntity);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PropietarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                TBL_PROPIETARIO propietarioEntity = _converterHelper.ToTBL_PROPIETARIO(model, false);
                _context.Update(propietarioEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }


        //METODO PARA ELIMINAR
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           TBL_PROPIETARIO tbl_Propietario = await _context.TBL_PROPIETARIO
                .FirstOrDefaultAsync(m => m.PRO_ID == id);
            if (tbl_Propietario == null)
            {
                return NotFound();
            }

            _context.TBL_PROPIETARIO.Remove(tbl_Propietario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
