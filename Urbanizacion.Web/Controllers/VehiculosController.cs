using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Urbanizacion.Web.Contexts;
using Urbanizacion.Web.Data.Entities;
using Urbanizacion.Web.Helpers;
using Urbanizacion.Web.Models;

namespace Urbanizacion.Web.Controllers
{
    public class VehiculosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IImageHelper _imageHelper;
        private readonly IConverterHelper _converterHelper;

        public VehiculosController(
            AppDbContext context,
            IImageHelper imageHelper,
            IConverterHelper converterHelper)
        {
            _context = context;
            _imageHelper = imageHelper;
            _converterHelper = converterHelper;
        }

        // GET: Vehiculos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TBL_VEHICULO.ToListAsync());
        }

        // GET: Vehiculos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TBL_VEHICULO tBL_VEHICULO = await _context.TBL_VEHICULO
                .FirstOrDefaultAsync(m => m.VEH_ID == id);
            if (tBL_VEHICULO == null)
            {
                return NotFound();
            }

            return View(tBL_VEHICULO);
        }

        // GET: Vehiculos/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VEH_ID,VEH_CODIGO,VEH_PLACA,VEH_FECHACREACIONBASE,VEH_ESTADO")] VehiculoViewModel vehiculoViewModel)
        {
            if (ModelState.IsValid)
            {
                TBL_VEHICULO vehiculoEntity = _converterHelper.ToTBL_VEHICULO(vehiculoViewModel, true);

                _context.Add(vehiculoEntity);
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "Ese codigo de TAG ya existe. Por favor ingrese otro");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                    }
                }
            }
            return View(vehiculoViewModel);
        }

        // GET: Vehiculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TBL_VEHICULO tBL_VEHICULO = await _context.TBL_VEHICULO.FindAsync(id);
            if (tBL_VEHICULO == null)
            {
                return NotFound();
            }
            VehiculoViewModel vehiculoViewModel = _converterHelper.ToVehiculoViewModel(tBL_VEHICULO);
            return View(vehiculoViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VEH_ID,VEH_CODIGO,VEH_PLACA,VEH_FECHACREACIONBASE,VEH_ESTADO")] VehiculoViewModel vehiculoViewModel)
        {
            if (id != vehiculoViewModel.VEH_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(vehiculoViewModel);
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "Ese codigo de TAG ya existe. Por favor ingrese otro");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                    }
                }
            }

            return View(vehiculoViewModel);
        }

        // GET: Vehiculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TBL_VEHICULO tBL_VEHICULO = await _context.TBL_VEHICULO
                .FirstOrDefaultAsync(m => m.VEH_ID == id);
            if (tBL_VEHICULO == null)
            {
                return NotFound();
            }

            _context.TBL_VEHICULO.Remove(tBL_VEHICULO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
