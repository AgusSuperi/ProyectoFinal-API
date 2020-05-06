using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class ProbandoMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CentrosSalud",
                columns: new[] { "Id", "Direccion", "HorarioAtencion", "Nombre", "RestriccionEdad", "Telefono" },
                values: new object[] { 2, "Humboldt 3758", "08:00 a 14:00", "12 de Octubre", "", 4811397 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
