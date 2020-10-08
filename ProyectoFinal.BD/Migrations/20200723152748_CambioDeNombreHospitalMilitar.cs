using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class CambioDeNombreHospitalMilitar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Hospital Militar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Hospital Militar Bahía Blanca");
        }
    }
}
