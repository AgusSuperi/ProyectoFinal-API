using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class CambiosCapsNorte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 15, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 15, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 15, 19 });

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "Estomba", "Vieytes 2616" });

            migrationBuilder.InsertData(
                table: "EspecialidadesCentrosSalud",
                columns: new[] { "CentroSaludId", "EspecialidadId" },
                values: new object[,]
                {
                    { 29, 4 },
                    { 29, 7 },
                    { 29, 8 },
                    { 29, 10 },
                    { 29, 11 },
                    { 29, 13 },
                    { 29, 18 },
                    { 29, 19 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 29, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 29, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 29, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 29, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 29, 19 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "Pacífico", "Vieytes 1616" });

            migrationBuilder.InsertData(
                table: "CentrosSalud",
                columns: new[] { "Id", "Barrio", "Direccion", "HorarioAtencion", "ImagenURL", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { 15, "Coronel Estomba", "Viamonte 2853", "08:00 a 18:00", "estomba.png", -38.699939999999998, -62.301450000000003, "Estomba", "(291) 4889026" });

            migrationBuilder.InsertData(
                table: "EspecialidadesCentrosSalud",
                columns: new[] { "CentroSaludId", "EspecialidadId" },
                values: new object[,]
                {
                    { 15, 4 },
                    { 15, 7 },
                    { 15, 8 },
                    { 15, 10 },
                    { 15, 11 },
                    { 15, 13 },
                    { 15, 18 },
                    { 15, 19 }
                });
        }
    }
}
