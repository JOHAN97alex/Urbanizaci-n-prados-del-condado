using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Urbanizacion.Web.Migrations
{
    public partial class Prueba1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PRO_APELLIDOFAMILIAR",
                table: "TBL_PROPIETARIO");

            migrationBuilder.DropColumn(
                name: "PRO_FECHAINGRESOBASE",
                table: "TBL_PROPIETARIO");

            migrationBuilder.DropColumn(
                name: "PRO_FECHASALIDABASE",
                table: "TBL_PROPIETARIO");

            migrationBuilder.DropColumn(
                name: "PRO_INQUILINOS",
                table: "TBL_PROPIETARIO");

            migrationBuilder.DropColumn(
                name: "PRO_NOMBREFAMILIAR",
                table: "TBL_PROPIETARIO");

            migrationBuilder.DropColumn(
                name: "PRO_NOMENCLATURA",
                table: "TBL_PROPIETARIO");

            migrationBuilder.DropColumn(
                name: "PRO_PASSWORD",
                table: "TBL_PROPIETARIO");

            migrationBuilder.DropColumn(
                name: "PRO_PERFIL",
                table: "TBL_PROPIETARIO");

            migrationBuilder.DropColumn(
                name: "PRO_TELEFONOFAMILIAR",
                table: "TBL_PROPIETARIO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PRO_APELLIDOFAMILIAR",
                table: "TBL_PROPIETARIO",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PRO_FECHAINGRESOBASE",
                table: "TBL_PROPIETARIO",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PRO_FECHASALIDABASE",
                table: "TBL_PROPIETARIO",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "PRO_INQUILINOS",
                table: "TBL_PROPIETARIO",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PRO_NOMBREFAMILIAR",
                table: "TBL_PROPIETARIO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRO_NOMENCLATURA",
                table: "TBL_PROPIETARIO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRO_PASSWORD",
                table: "TBL_PROPIETARIO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRO_PERFIL",
                table: "TBL_PROPIETARIO",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PRO_TELEFONOFAMILIAR",
                table: "TBL_PROPIETARIO",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
