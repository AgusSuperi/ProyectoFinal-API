using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class CambiosEnAlgunosCaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 43, 7 });

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Barrio", "Direccion", "Latitud", "Longitud" },
                values: new object[] { "Cabildo", "Alberti 215", -38.489272999999997, -61.896659 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Barrio", "Latitud", "Longitud" },
                values: new object[] { "Los Almendros", -38.698551000000002, -62.297645000000003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Barrio", "Direccion", "Latitud", "Longitud" },
                values: new object[] { "San Cayetano", "Manuel Alberti 215", -38.700319999999998, -62.284280000000003 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Barrio", "Latitud", "Longitud" },
                values: new object[] { "Estomba", -38.705806000000003, -62.287013999999999 });

            migrationBuilder.InsertData(
                table: "CentrosSalud",
                columns: new[] { "Id", "Barrio", "Direccion", "HorarioAtencion", "ImagenURL", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { 43, "Villa Amaducci", "Rastreador Fournier 1809", "08:00 a 18:00", "villaamaducci.png", -38.723370000000003, -62.226770000000002, "Villa Amaducci", "(291) 4810155" });

            migrationBuilder.InsertData(
                table: "EspecialidadesCentrosSalud",
                columns: new[] { "CentroSaludId", "EspecialidadId" },
                values: new object[] { 43, 7 });
        }
    }
}
