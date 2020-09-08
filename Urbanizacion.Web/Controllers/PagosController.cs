using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urbanizacion.Web.Contexts;
using Urbanizacion.Web.Helpers;

namespace Urbanizacion.Web.Controllers
{
    public class PagosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IImageHelper _imageHelper;
        private readonly IConverterHelper _converterHelper;

        public PagosController(
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
                .TBL_PAGO
                .Include(t => t.Propietario)
                .OrderBy(t => t.PAG_FECHAPAGADO)
                .ToListAsync());
        }
    }
}
