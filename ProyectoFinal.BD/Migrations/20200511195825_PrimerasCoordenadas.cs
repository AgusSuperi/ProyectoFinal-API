using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class PrimerasCoordenadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitud",
                table: "CentrosSalud",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitud",
                table: "CentrosSalud",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitud", "Longitud" },
                values: new object[] { -38.739649999999997, -62.212719999999997 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "CentrosSalud");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "CentrosSalud");
        }
    }
}
