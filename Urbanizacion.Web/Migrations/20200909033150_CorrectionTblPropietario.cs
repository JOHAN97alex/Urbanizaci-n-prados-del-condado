using Microsoft.EntityFrameworkCore.Migrations;

namespace Urbanizacion.Web.Migrations
{
    public partial class CorrectionTblPropietario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PRO_PASSWORD",
                table: "TBL_PROPIETARIO");

            migrationBuilder.RenameColumn(
                name: "PRO_PERFIL",
                table: "TBL_PROPIETARIO",
                newName: "PRO_TELEFONOINQUILINO");

            migrationBuilder.AlterColumn<string>(
                name: "VEH_PLACA",
                table: "TBL_VEHICULO",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "PRO_ESTADO",
                table: "TBL_PROPIETARIO",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "PRO_APELLIDOSINQUILINO",
                table: "TBL_PROPIETARIO",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PRO_NOMBRESINQUILINO",
                table: "TBL_PROPIETARIO",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PRO_APELLIDOSINQUILINO",
                table: "TBL_PROPIETARIO");

            migrationBuilder.DropColumn(
                name: "PRO_NOMBRESINQUILINO",
                table: "TBL_PROPIETARIO");

            migrationBuilder.RenameColumn(
                name: "PRO_TELEFONOINQUILINO",
                table: "TBL_PROPIETARIO",
                newName: "PRO_PERFIL");

            migrationBuilder.AlterColumn<string>(
                name: "VEH_PLACA",
                table: "TBL_VEHICULO",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<bool>(
                name: "PRO_ESTADO",
                table: "TBL_PROPIETARIO",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "PRO_PASSWORD",
                table: "TBL_PROPIETARIO",
                nullable: true);
        }
    }
}
