using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urbanizacion.Web.Contexts;
using Urbanizacion.Web.Data.Entities;

namespace Urbanizacion.Web.Data
{
    public class SeedDb
    {
        private readonly AppDbContext _context;

        public SeedDb(AppDbContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckVehiculosAsync();
        }

        private async Task CheckVehiculosAsync()
        {
            if (!_context.TBL_VEHICULO.Any())
            {
                AddVehiculo("12411", "4376");
                AddVehiculo("12414", "1104");
                AddVehiculo("12418", "3041");
                AddVehiculo("12432", "0597");
                AddVehiculo("12448", "3973");
                AddVehiculo("12452", "7091");
                await _context.SaveChangesAsync();
            }
        }

        private void AddVehiculo(string VehCodigo, string VehPlaca)
        {
            _context.TBL_VEHICULO.Add(new TBL_VEHICULO { VEH_CODIGO = VehCodigo, VEH_PLACA = VehPlaca });
        }

    }
}
