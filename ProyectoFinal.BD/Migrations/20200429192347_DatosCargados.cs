using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class DatosCargados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CentrosSalud",
                columns: new[] { "Id", "Direccion", "HorarioAtencion", "Nombre", "RestriccionEdad", "Telefono" },
                values: new object[] { 1, "en la loma del culo", "no trabja nunca", "Matias", "ancianas", 294 });

            migrationBuilder.InsertData(
                table: "Colectivos",
                columns: new[] { "Id", "Linea" },
                values: new object[] { 1, "503" });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "verdulero" });

            migrationBuilder.InsertData(
                table: "PracticasDiagnosticos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "prostata" });

            migrationBuilder.InsertData(
                table: "ColectivosCentrosSalud",
                columns: new[] { "CentroSaludId", "ColectivoId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "EspecialidadesCentrosSalud",
                columns: new[] { "CentroSaludId", "EspecialidadId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "PracticasDiagnosticoCentrosSalud",
                columns: new[] { "CentroSaludId", "PracticaDiagnosticoId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ColectivosCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "ColectivoId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PracticasDiagnosticoCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "PracticaDiagnosticoId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
