using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class CambioDePaginaWebHospitalMilitar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 3,
                column: "URLPagina",
                value: "sanidad.ejercito.mil.ar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 3,
                column: "URLPagina",
                value: "");
        }
    }
}
