using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class ActualizacionLatLomgSaladero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Latitud", "Longitud" },
                values: new object[] { -38.770060999999998, -62.244759000000002 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Latitud", "Longitud" },
                values: new object[] { -38.770603999999999, -62.245449999999998 });
        }
    }
}
