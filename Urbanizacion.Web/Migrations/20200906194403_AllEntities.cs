using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Urbanizacion.Web.Migrations
{
    public partial class AllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_CONJUNTO",
                columns: table => new
                {
                    CON_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CON_NOMBRE = table.Column<string>(maxLength: 100, nullable: false),
                    CON_IDENTIFICACION = table.Column<string>(maxLength: 13, nullable: false),
                    CON_TELEFONO = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CONJUNTO", x => x.CON_ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_SERVICIO",
                columns: table => new
                {
                    SER_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SER_NOMBRE = table.Column<string>(nullable: true),
                    SER_DESRIPCION = table.Column<string>(nullable: true),
                    SER_FECHACREACION = table.Column<DateTime>(nullable: false),
                    SER_ESTADO = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_SERVICIO", x => x.SER_ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_ROL",
                columns: table => new
                {
                    ROL_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ROL_DESCRIPCION = table.Column<string>(nullable: true),
                    ROL_FECHACREACION = table.Column<DateTime>(nullable: false),
                    ROL_ESTADO = table.Column<string>(nullable: false),
                    ServicioSER_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_ROL", x => x.ROL_ID);
                    table.ForeignKey(
                        name: "FK_TBL_ROL_TBL_SERVICIO_ServicioSER_ID",
                        column: x => x.ServicioSER_ID,
                        principalTable: "TBL_SERVICIO",
                        principalColumn: "SER_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PROPIETARIO",
                columns: table => new
                {
                    PRO_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PRO_LOTE = table.Column<string>(maxLength: 4, nullable: false),
                    PRO_TIPO = table.Column<string>(nullable: true),
                    PRO_NOMBRES = table.Column<string>(maxLength: 50, nullable: false),
                    PRO_APELLIDOS = table.Column<string>(maxLength: 50, nullable: false),
                    PRO_OBSERVACIONES = table.Column<string>(nullable: true),
                    PRO_TELEFONO = table.Column<string>(nullable: false),
                    PRO_EMAIL = table.Column<string>(nullable: false),
                    PRO_TIPOIDENTIFICACION = table.Column<string>(nullable: false),
                    PRO_IDENTIFICACION = table.Column<string>(nullable: true),
                    PRO_NOMBREFAMILIAR = table.Column<string>(nullable: true),
                    PRO_APELLIDOFAMILIAR = table.Column<string>(nullable: true),
                    PRO_TELEFONOFAMILIAR = table.Column<string>(nullable: true),
                    PRO_NOMENCLATURA = table.Column<string>(nullable: true),
                    PRO_PASSWORD = table.Column<string>(nullable: true),
                    PRO_PERFIL = table.Column<string>(nullable: true),
                    PRO_FECHAINGRESOBASE = table.Column<DateTime>(nullable: false),
                    PRO_FECHASALIDABASE = table.Column<DateTime>(nullable: false),
                    PRO_INQUILINOS = table.Column<bool>(nullable: false),
                    PRO_FECHACREACIONBASE = table.Column<DateTime>(nullable: false),
                    PRO_ESTADO = table.Column<bool>(nullable: false),
                    ConjuntoCON_ID = table.Column<int>(nullable: true),
                    ROL_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PROPIETARIO", x => x.PRO_ID);
                    table.ForeignKey(
                        name: "FK_TBL_PROPIETARIO_TBL_CONJUNTO_ConjuntoCON_ID",
                        column: x => x.ConjuntoCON_ID,
                        principalTable: "TBL_CONJUNTO",
                        principalColumn: "CON_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TBL_PROPIETARIO_TBL_ROL_ROL_ID",
                        column: x => x.ROL_ID,
                        principalTable: "TBL_ROL",
                        principalColumn: "ROL_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_NEGOCIO",
                columns: table => new
                {
                    NEG_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NEG_NOMBRE = table.Column<string>(nullable: true),
                    NEG_DESCRIPCION = table.Column<string>(nullable: true),
                    NEG_TELEFONO = table.Column<string>(nullable: true),
                    NEG_DIRECCION = table.Column<string>(nullable: true),
                    NEG_EMAIL = table.Column<string>(nullable: true),
                    NEG_FECHACREACION = table.Column<DateTime>(nullable: false),
                    NEG_ESTADO = table.Column<string>(nullable: false),
                    PropietarioPRO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_NEGOCIO", x => x.NEG_ID);
                    table.ForeignKey(
                        name: "FK_TBL_NEGOCIO_TBL_PROPIETARIO_PropietarioPRO_ID",
                        column: x => x.PropietarioPRO_ID,
                        principalTable: "TBL_PROPIETARIO",
                        principalColumn: "PRO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PAGO",
                columns: table => new
                {
                    PAG_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PAG_TOTAL = table.Column<string>(nullable: true),
                    PAG_PAGADO = table.Column<string>(nullable: true),
                    PAG_FECHAPAGADO = table.Column<DateTime>(nullable: false),
                    PAG_VALOR = table.Column<string>(nullable: true),
                    PAG_FECHACREACION = table.Column<DateTime>(nullable: false),
                    PAG_ESTADO = table.Column<string>(nullable: false),
                    PropietarioPRO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PAGO", x => x.PAG_ID);
                    table.ForeignKey(
                        name: "FK_TBL_PAGO_TBL_PROPIETARIO_PropietarioPRO_ID",
                        column: x => x.PropietarioPRO_ID,
                        principalTable: "TBL_PROPIETARIO",
                        principalColumn: "PRO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_VEHICULO",
                columns: table => new
                {
                    VEH_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VEH_CODIGO = table.Column<string>(nullable: true),
                    VEH_PLACA = table.Column<string>(nullable: true),
                    VEH_FECHACREACION = table.Column<DateTime>(nullable: false),
                    VEH_ESTADO = table.Column<string>(nullable: false),
                    PropietarioPRO_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_VEHICULO", x => x.VEH_ID);
                    table.ForeignKey(
                        name: "FK_TBL_VEHICULO_TBL_PROPIETARIO_PropietarioPRO_ID",
                        column: x => x.PropietarioPRO_ID,
                        principalTable: "TBL_PROPIETARIO",
                        principalColumn: "PRO_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PRODUCTO",
                columns: table => new
                {
                    PRO_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PRO_NOMBRE = table.Column<string>(nullable: true),
                    PRO_PRECIO = table.Column<string>(nullable: true),
                    PRO_FECHACREACION = table.Column<DateTime>(nullable: false),
                    PRO_ESTADO = table.Column<string>(nullable: false),
                    NegocioNEG_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PRODUCTO", x => x.PRO_ID);
                    table.ForeignKey(
                        name: "FK_TBL_PRODUCTO_TBL_NEGOCIO_NegocioNEG_ID",
                        column: x => x.NegocioNEG_ID,
                        principalTable: "TBL_NEGOCIO",
                        principalColumn: "NEG_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_VALOR",
                columns: table => new
                {
                    VAL_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VAL_VALOR = table.Column<string>(nullable: true),
                    VAL_FECHAINICIO = table.Column<DateTime>(nullable: false),
                    VAL_FECHAFIN = table.Column<DateTime>(nullable: false),
                    VAL_FECHACREACION = table.Column<DateTime>(nullable: false),
                    VAL_ESTADO = table.Column<DateTime>(nullable: false),
                    PagoPAG_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_VALOR", x => x.VAL_ID);
                    table.ForeignKey(
                        name: "FK_TBL_VALOR_TBL_PAGO_PagoPAG_ID",
                        column: x => x.PagoPAG_ID,
                        principalTable: "TBL_PAGO",
                        principalColumn: "PAG_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_NEGOCIO_PropietarioPRO_ID",
                table: "TBL_NEGOCIO",
                column: "PropietarioPRO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PAGO_PropietarioPRO_ID",
                table: "TBL_PAGO",
                column: "PropietarioPRO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PRODUCTO_NegocioNEG_ID",
                table: "TBL_PRODUCTO",
                column: "NegocioNEG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PROPIETARIO_ConjuntoCON_ID",
                table: "TBL_PROPIETARIO",
                column: "ConjuntoCON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PROPIETARIO_PRO_EMAIL",
                table: "TBL_PROPIETARIO",
                column: "PRO_EMAIL",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PROPIETARIO_PRO_IDENTIFICACION",
                table: "TBL_PROPIETARIO",
                column: "PRO_IDENTIFICACION",
                unique: true,
                filter: "[PRO_IDENTIFICACION] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PROPIETARIO_ROL_ID",
                table: "TBL_PROPIETARIO",
                column: "ROL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_ROL_ServicioSER_ID",
                table: "TBL_ROL",
                column: "ServicioSER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_VALOR_PagoPAG_ID",
                table: "TBL_VALOR",
                column: "PagoPAG_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_VEHICULO_PropietarioPRO_ID",
                table: "TBL_VEHICULO",
                column: "PropietarioPRO_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_PRODUCTO");

            migrationBuilder.DropTable(
                name: "TBL_VALOR");

            migrationBuilder.DropTable(
                name: "TBL_VEHICULO");

            migrationBuilder.DropTable(
                name: "TBL_NEGOCIO");

            migrationBuilder.DropTable(
                name: "TBL_PAGO");

            migrationBuilder.DropTable(
                name: "TBL_PROPIETARIO");

            migrationBuilder.DropTable(
                name: "TBL_CONJUNTO");

            migrationBuilder.DropTable(
                name: "TBL_ROL");

            migrationBuilder.DropTable(
                name: "TBL_SERVICIO");
        }
    }
}
