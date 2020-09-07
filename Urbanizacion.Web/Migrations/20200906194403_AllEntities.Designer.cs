﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Urbanizacion.Web.Contexts;

namespace Urbanizacion.Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200906194403_AllEntities")]
    partial class AllEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_CONJUNTO", b =>
                {
                    b.Property<int>("CON_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CON_IDENTIFICACION")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<string>("CON_NOMBRE")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CON_TELEFONO")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("CON_ID");

                    b.ToTable("TBL_CONJUNTO");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_NEGOCIO", b =>
                {
                    b.Property<int>("NEG_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NEG_DESCRIPCION");

                    b.Property<string>("NEG_DIRECCION");

                    b.Property<string>("NEG_EMAIL");

                    b.Property<string>("NEG_ESTADO")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("NEG_FECHACREACION");

                    b.Property<string>("NEG_NOMBRE");

                    b.Property<string>("NEG_TELEFONO");

                    b.Property<int?>("PropietarioPRO_ID");

                    b.HasKey("NEG_ID");

                    b.HasIndex("PropietarioPRO_ID");

                    b.ToTable("TBL_NEGOCIO");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_PAGO", b =>
                {
                    b.Property<int>("PAG_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PAG_ESTADO")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("PAG_FECHACREACION");

                    b.Property<DateTime>("PAG_FECHAPAGADO");

                    b.Property<string>("PAG_PAGADO");

                    b.Property<string>("PAG_TOTAL");

                    b.Property<string>("PAG_VALOR");

                    b.Property<int?>("PropietarioPRO_ID");

                    b.HasKey("PAG_ID");

                    b.HasIndex("PropietarioPRO_ID");

                    b.ToTable("TBL_PAGO");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_PRODUCTO", b =>
                {
                    b.Property<int>("PRO_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NegocioNEG_ID");

                    b.Property<string>("PRO_ESTADO")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("PRO_FECHACREACION");

                    b.Property<string>("PRO_NOMBRE");

                    b.Property<string>("PRO_PRECIO");

                    b.HasKey("PRO_ID");

                    b.HasIndex("NegocioNEG_ID");

                    b.ToTable("TBL_PRODUCTO");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_PROPIETARIO", b =>
                {
                    b.Property<int>("PRO_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConjuntoCON_ID");

                    b.Property<string>("PRO_APELLIDOFAMILIAR");

                    b.Property<string>("PRO_APELLIDOS")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PRO_EMAIL")
                        .IsRequired();

                    b.Property<bool>("PRO_ESTADO");

                    b.Property<DateTime>("PRO_FECHACREACIONBASE");

                    b.Property<DateTime>("PRO_FECHAINGRESOBASE");

                    b.Property<DateTime>("PRO_FECHASALIDABASE");

                    b.Property<string>("PRO_IDENTIFICACION");

                    b.Property<bool>("PRO_INQUILINOS");

                    b.Property<string>("PRO_LOTE")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.Property<string>("PRO_NOMBREFAMILIAR");

                    b.Property<string>("PRO_NOMBRES")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PRO_NOMENCLATURA");

                    b.Property<string>("PRO_OBSERVACIONES");

                    b.Property<string>("PRO_PASSWORD");

                    b.Property<string>("PRO_PERFIL");

                    b.Property<string>("PRO_TELEFONO")
                        .IsRequired();

                    b.Property<string>("PRO_TELEFONOFAMILIAR");

                    b.Property<string>("PRO_TIPO");

                    b.Property<string>("PRO_TIPOIDENTIFICACION")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int?>("ROL_ID");

                    b.HasKey("PRO_ID");

                    b.HasIndex("ConjuntoCON_ID");

                    b.HasIndex("PRO_EMAIL")
                        .IsUnique();

                    b.HasIndex("PRO_IDENTIFICACION")
                        .IsUnique()
                        .HasFilter("[PRO_IDENTIFICACION] IS NOT NULL");

                    b.HasIndex("ROL_ID");

                    b.ToTable("TBL_PROPIETARIO");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_ROL", b =>
                {
                    b.Property<int>("ROL_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ROL_DESCRIPCION");

                    b.Property<string>("ROL_ESTADO")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("ROL_FECHACREACION");

                    b.Property<int?>("ServicioSER_ID");

                    b.HasKey("ROL_ID");

                    b.HasIndex("ServicioSER_ID");

                    b.ToTable("TBL_ROL");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_SERVICIO", b =>
                {
                    b.Property<int>("SER_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SER_DESRIPCION");

                    b.Property<string>("SER_ESTADO")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("SER_FECHACREACION");

                    b.Property<string>("SER_NOMBRE");

                    b.HasKey("SER_ID");

                    b.ToTable("TBL_SERVICIO");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_VALOR", b =>
                {
                    b.Property<int>("VAL_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PagoPAG_ID");

                    b.Property<DateTime>("VAL_ESTADO");

                    b.Property<DateTime>("VAL_FECHACREACION");

                    b.Property<DateTime>("VAL_FECHAFIN");

                    b.Property<DateTime>("VAL_FECHAINICIO");

                    b.Property<string>("VAL_VALOR");

                    b.HasKey("VAL_ID");

                    b.HasIndex("PagoPAG_ID");

                    b.ToTable("TBL_VALOR");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_VEHICULO", b =>
                {
                    b.Property<int>("VEH_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PropietarioPRO_ID");

                    b.Property<string>("VEH_CODIGO");

                    b.Property<string>("VEH_ESTADO")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<DateTime>("VEH_FECHACREACION");

                    b.Property<string>("VEH_PLACA");

                    b.HasKey("VEH_ID");

                    b.HasIndex("PropietarioPRO_ID");

                    b.ToTable("TBL_VEHICULO");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_NEGOCIO", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.TBL_PROPIETARIO", "Propietario")
                        .WithMany("Negocio")
                        .HasForeignKey("PropietarioPRO_ID");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_PAGO", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.TBL_PROPIETARIO", "Propietario")
                        .WithMany("Pago")
                        .HasForeignKey("PropietarioPRO_ID");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_PRODUCTO", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.TBL_NEGOCIO", "Negocio")
                        .WithMany("Producto")
                        .HasForeignKey("NegocioNEG_ID");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_PROPIETARIO", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.TBL_CONJUNTO", "Conjunto")
                        .WithMany("Propietario")
                        .HasForeignKey("ConjuntoCON_ID");

                    b.HasOne("Urbanizacion.Web.Data.Entities.TBL_ROL", "Rol")
                        .WithMany("Propietario")
                        .HasForeignKey("ROL_ID");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_ROL", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.TBL_SERVICIO", "Servicio")
                        .WithMany("Rol")
                        .HasForeignKey("ServicioSER_ID");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_VALOR", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.TBL_PAGO", "Pago")
                        .WithMany("Valor")
                        .HasForeignKey("PagoPAG_ID");
                });

            modelBuilder.Entity("Urbanizacion.Web.Data.Entities.TBL_VEHICULO", b =>
                {
                    b.HasOne("Urbanizacion.Web.Data.Entities.TBL_PROPIETARIO", "Propietario")
                        .WithMany("Vehiculo")
                        .HasForeignKey("PropietarioPRO_ID");
                });
#pragma warning restore 612, 618
        }
    }
}
