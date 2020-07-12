using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class URLUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 1,
                column: "URLPagina",
                value: "www.hospitalpenna.com.ar");

            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 2,
                column: "URLPagina",
                value: "hmabb.gov.ar");

            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 4,
                column: "URLPagina",
                value: "hospital-menor-ing-white.negocio.site");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 1,
                column: "URLPagina",
                value: "http://www.hospitalpenna.com.ar/");

            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 2,
                column: "URLPagina",
                value: "http://www.hmabb.gov.ar/");

            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 4,
                column: "URLPagina",
                value: "https://hospital-menor-ing-white.negocio.site/");
        }
    }
}
