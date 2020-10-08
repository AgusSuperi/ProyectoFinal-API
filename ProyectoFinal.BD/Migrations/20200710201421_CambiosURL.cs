using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class CambiosURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 1,
                column: "URLPagina",
                value: "hospitalpenna.com.ar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HospitalesPublicos",
                keyColumn: "Id",
                keyValue: 1,
                column: "URLPagina",
                value: "www.hospitalpenna.com.ar");
        }
    }
}
