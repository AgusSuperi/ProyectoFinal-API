using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class RestriccionEdadEliminada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "RestriccionEdad",
                table: "CentrosSalud");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Fournier 1809", "extensión CS 9 de noviembre", -38.723370000000003, -62.226770000000002, "Villa Amaducci", 4810155 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Larrea 5450", "08:00 a 14:00", -38.714779999999998, -62.311369999999997, "Villa Bordeu", 4885679 });

            migrationBuilder.InsertData(
                table: "EspecialidadesCentrosSalud",
                columns: new[] { "CentroSaludId", "EspecialidadId" },
                values: new object[,]
                {
                    { 55, 11 },
                    { 47, 8 },
                    { 47, 10 },
                    { 47, 17 },
                    { 47, 19 },
                    { 48, 4 },
                    { 48, 7 },
                    { 48, 8 },
                    { 48, 9 },
                    { 48, 10 },
                    { 48, 15 },
                    { 48, 17 },
                    { 49, 1 },
                    { 49, 4 },
                    { 49, 7 },
                    { 49, 8 },
                    { 49, 9 },
                    { 49, 10 },
                    { 47, 7 },
                    { 49, 12 },
                    { 46, 19 },
                    { 46, 17 },
                    { 45, 4 },
                    { 45, 7 },
                    { 45, 8 },
                    { 45, 9 },
                    { 45, 10 },
                    { 45, 12 },
                    { 45, 13 },
                    { 45, 15 },
                    { 45, 17 },
                    { 45, 18 },
                    { 45, 19 },
                    { 46, 4 },
                    { 46, 7 },
                    { 46, 8 },
                    { 46, 9 },
                    { 46, 10 },
                    { 46, 15 },
                    { 46, 18 },
                    { 49, 13 },
                    { 49, 15 },
                    { 45, 1 },
                    { 53, 10 },
                    { 53, 11 },
                    { 53, 13 },
                    { 53, 15 },
                    { 53, 17 },
                    { 53, 19 },
                    { 54, 4 },
                    { 54, 7 },
                    { 54, 8 },
                    { 54, 10 },
                    { 54, 13 },
                    { 54, 15 },
                    { 54, 19 },
                    { 55, 4 },
                    { 55, 7 },
                    { 55, 8 },
                    { 55, 10 },
                    { 53, 9 },
                    { 53, 8 },
                    { 53, 7 },
                    { 53, 4 },
                    { 49, 18 },
                    { 49, 19 },
                    { 50, 1 },
                    { 50, 7 },
                    { 50, 17 },
                    { 51, 4 },
                    { 51, 7 },
                    { 51, 8 },
                    { 55, 17 },
                    { 51, 9 },
                    { 51, 15 },
                    { 51, 17 },
                    { 52, 7 },
                    { 52, 8 },
                    { 52, 15 },
                    { 52, 16 },
                    { 52, 17 },
                    { 52, 19 },
                    { 51, 10 },
                    { 49, 17 },
                    { 44, 20 },
                    { 44, 17 },
                    { 33, 19 },
                    { 34, 4 },
                    { 34, 7 },
                    { 34, 8 },
                    { 34, 10 },
                    { 34, 15 },
                    { 34, 17 },
                    { 34, 18 },
                    { 34, 19 },
                    { 35, 7 },
                    { 35, 8 },
                    { 35, 10 },
                    { 35, 13 },
                    { 35, 15 },
                    { 35, 16 },
                    { 35, 17 },
                    { 35, 19 },
                    { 33, 18 },
                    { 33, 17 },
                    { 33, 15 },
                    { 33, 12 },
                    { 31, 8 },
                    { 31, 10 },
                    { 31, 16 },
                    { 31, 17 },
                    { 31, 19 },
                    { 32, 4 },
                    { 32, 7 },
                    { 32, 8 },
                    { 36, 4 },
                    { 32, 9 },
                    { 32, 11 },
                    { 32, 15 },
                    { 32, 17 },
                    { 32, 19 },
                    { 33, 1 },
                    { 33, 4 },
                    { 33, 7 },
                    { 33, 10 },
                    { 32, 10 },
                    { 36, 7 },
                    { 36, 8 },
                    { 36, 10 },
                    { 41, 4 },
                    { 41, 7 },
                    { 41, 10 },
                    { 41, 15 },
                    { 41, 17 },
                    { 41, 19 },
                    { 42, 4 },
                    { 42, 7 },
                    { 40, 17 },
                    { 42, 10 },
                    { 42, 19 },
                    { 43, 7 },
                    { 44, 3 },
                    { 44, 7 },
                    { 44, 8 },
                    { 44, 10 },
                    { 44, 11 },
                    { 44, 15 },
                    { 42, 15 },
                    { 44, 19 },
                    { 40, 9 },
                    { 40, 1 },
                    { 36, 11 },
                    { 37, 7 },
                    { 37, 10 },
                    { 38, 4 },
                    { 38, 7 },
                    { 38, 8 },
                    { 38, 10 },
                    { 38, 12 },
                    { 40, 7 },
                    { 38, 13 },
                    { 38, 16 },
                    { 38, 17 },
                    { 38, 18 },
                    { 38, 19 },
                    { 39, 7 },
                    { 39, 8 },
                    { 39, 10 },
                    { 39, 13 },
                    { 38, 15 },
                    { 31, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 31, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 31, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 31, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 31, 16 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 31, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 31, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 32, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 32, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 32, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 32, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 32, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 32, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 32, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 32, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 33, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 33, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 33, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 33, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 33, 12 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 33, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 33, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 33, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 33, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 34, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 34, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 34, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 34, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 34, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 34, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 34, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 35, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 35, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 35, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 35, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 35, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 35, 16 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 35, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 35, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 36, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 36, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 36, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 36, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 36, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 37, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 37, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 12 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 16 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 38, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 39, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 39, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 39, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 39, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 40, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 40, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 40, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 41, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 41, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 41, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 41, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 41, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 41, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 42, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 42, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 42, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 42, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 42, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 43, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 44, 3 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 44, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 44, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 44, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 44, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 44, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 44, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 44, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 44, 20 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 12 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 45, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 46, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 46, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 46, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 46, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 46, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 46, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 46, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 46, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 46, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 47, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 47, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 47, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 47, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 47, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 48, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 48, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 48, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 48, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 48, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 48, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 48, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 12 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 49, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 50, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 50, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 51, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 51, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 51, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 51, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 51, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 51, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 51, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 52, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 52, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 52, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 52, 16 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 52, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 52, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 53, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 53, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 53, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 53, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 53, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 53, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 53, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 53, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 53, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 53, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 54, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 54, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 54, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 54, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 54, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 54, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 54, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 55, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 55, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 55, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 55, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 55, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 55, 17 });

            migrationBuilder.AddColumn<string>(
                name: "RestriccionEdad",
                table: "CentrosSalud",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 3,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 4,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 5,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 6,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 9,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 12,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 13,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 15,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 16,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 18,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 19,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 20,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 23,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 25,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 26,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 27,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 28,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 30,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 31,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 32,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 33,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 34,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 35,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 41,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 42,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "RestriccionEdad", "Telefono" },
                values: new object[] { "Larrea 5450", "08:00 a 14:00", -38.714779999999998, -62.311369999999997, "Villa Bordeu", "", 4885679 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "RestriccionEdad", "Telefono" },
                values: new object[] { "Fournier 1809", "extensión CS 9 de noviembre", -38.723370000000003, -62.226770000000002, "Villa Amaducci", "", 4810155 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 45,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 47,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 50,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 51,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 52,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 53,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 54,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 55,
                column: "RestriccionEdad",
                value: "");

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 5, "Dermatología" });
        }
    }
}
