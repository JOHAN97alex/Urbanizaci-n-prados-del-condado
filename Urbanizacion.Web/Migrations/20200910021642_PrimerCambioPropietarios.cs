using Microsoft.EntityFrameworkCore.Migrations;

namespace Urbanizacion.Web.Migrations
{
    public partial class PrimerCambioPropietarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TBL_PROPIETARIO_PRO_IDENTIFICACION",
                table: "TBL_PROPIETARIO");

            migrationBuilder.AlterColumn<string>(
                name: "PRO_TIPO",
                table: "TBL_PROPIETARIO",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRO_TELEFONOFAMILIAR",
                table: "TBL_PROPIETARIO",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRO_TELEFONO",
                table: "TBL_PROPIETARIO",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PRO_IDENTIFICACION",
                table: "TBL_PROPIETARIO",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PRO_ESTADO",
                table: "TBL_PROPIETARIO",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PROPIETARIO_PRO_IDENTIFICACION",
                table: "TBL_PROPIETARIO",
                column: "PRO_IDENTIFICACION",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TBL_PROPIETARIO_PRO_IDENTIFICACION",
                table: "TBL_PROPIETARIO");

            migrationBuilder.AlterColumn<string>(
                name: "PRO_TIPO",
                table: "TBL_PROPIETARIO",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PRO_TELEFONOFAMILIAR",
                table: "TBL_PROPIETARIO",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PRO_TELEFONO",
                table: "TBL_PROPIETARIO",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PRO_IDENTIFICACION",
                table: "TBL_PROPIETARIO",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<bool>(
                name: "PRO_ESTADO",
                table: "TBL_PROPIETARIO",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_TBL_PROPIETARIO_PRO_IDENTIFICACION",
                table: "TBL_PROPIETARIO",
                column: "PRO_IDENTIFICACION",
                unique: true,
                filter: "[PRO_IDENTIFICACION] IS NOT NULL");
        }
    }
}
