using Microsoft.EntityFrameworkCore.Migrations;

namespace Urbanizacion.Web.Migrations
{
    public partial class AddUnicoenVehiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TBL_VEHICULO_VEH_CODIGO",
                table: "TBL_VEHICULO",
                column: "VEH_CODIGO",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TBL_VEHICULO_VEH_CODIGO",
                table: "TBL_VEHICULO");
        }
    }
}
