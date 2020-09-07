using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Urbanizacion.Web.Migrations
{
    public partial class AddDataanottationsvehyvalor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VEH_FECHACREACION",
                table: "TBL_VEHICULO",
                newName: "VEH_FECHACREACIONBASE");

            migrationBuilder.RenameColumn(
                name: "VAL_FECHAINICIO",
                table: "TBL_VALOR",
                newName: "VAL_FECHAINICIOBASE");

            migrationBuilder.RenameColumn(
                name: "VAL_FECHAFIN",
                table: "TBL_VALOR",
                newName: "VAL_FECHAFINBASE");

            migrationBuilder.RenameColumn(
                name: "VAL_FECHACREACION",
                table: "TBL_VALOR",
                newName: "VAL_FECHACREACIONBASE");

            migrationBuilder.AlterColumn<string>(
                name: "VEH_PLACA",
                table: "TBL_VEHICULO",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VEH_CODIGO",
                table: "TBL_VEHICULO",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VAL_ESTADO",
                table: "TBL_VALOR",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VEH_FECHACREACIONBASE",
                table: "TBL_VEHICULO",
                newName: "VEH_FECHACREACION");

            migrationBuilder.RenameColumn(
                name: "VAL_FECHAINICIOBASE",
                table: "TBL_VALOR",
                newName: "VAL_FECHAINICIO");

            migrationBuilder.RenameColumn(
                name: "VAL_FECHAFINBASE",
                table: "TBL_VALOR",
                newName: "VAL_FECHAFIN");

            migrationBuilder.RenameColumn(
                name: "VAL_FECHACREACIONBASE",
                table: "TBL_VALOR",
                newName: "VAL_FECHACREACION");

            migrationBuilder.AlterColumn<string>(
                name: "VEH_PLACA",
                table: "TBL_VEHICULO",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "VEH_CODIGO",
                table: "TBL_VEHICULO",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VAL_ESTADO",
                table: "TBL_VALOR",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
