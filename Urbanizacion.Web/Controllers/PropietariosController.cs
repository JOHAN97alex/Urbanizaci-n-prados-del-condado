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

    }
}
