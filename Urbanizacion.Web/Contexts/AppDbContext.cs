using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Urbanizacion.Web.Data.Entities;

namespace Urbanizacion.Web.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<TBL_CONJUNTO> TBL_CONJUNTO { get; set; }
        public DbSet<TBL_NEGOCIO> TBL_NEGOCIO { get; set; }
        public DbSet<TBL_PAGO> TBL_PAGO { get; set; }
        public DbSet<TBL_PRODUCTO> TBL_PRODUCTO { get; set; }
        public DbSet<TBL_PROPIETARIO> TBL_PROPIETARIO { get; set; }
        public DbSet<TBL_ROL> TBL_ROL { get; set; }
        public DbSet<TBL_SERVICIO> TBL_SERVICIO { get; set; }
        public DbSet<TBL_VALOR> TBL_VALOR { get; set; }
        public DbSet<TBL_VEHICULO> TBL_VEHICULO { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TBL_PROPIETARIO>()
                .HasIndex(t => t.PRO_IDENTIFICACION)
                .IsUnique();
            modelBuilder.Entity<TBL_PROPIETARIO>()
                .HasIndex(t => t.PRO_EMAIL)
                .IsUnique();
            modelBuilder.Entity<TBL_VEHICULO>()
                .HasIndex(t => t.VEH_CODIGO)
                .IsUnique();
        }        

    }
}
