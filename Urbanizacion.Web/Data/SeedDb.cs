using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urbanizacion.Web.Contexts;

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
            await CheckValoresAsync();
        }

        private Task CheckValoresAsync()
        {
            throw new NotImplementedException();
        }

        private Task CheckVehiculosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
