using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class NuevasEspecialidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColectivosCentrosSalud");

            migrationBuilder.DropTable(
                name: "PracticasDiagnosticoCentrosSalud");

            migrationBuilder.DropTable(
                name: "Colectivos");

            migrationBuilder.DropTable(
                name: "PracticasDiagnosticos");

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                column: "Nombre",
                value: "Leonor Capelli (Ingeniero White)");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Actividad Comunitaria");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Alergia");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Anatomia Patológica");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nombre",
                value: "Clínica Médica");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nombre",
                value: "Dermatología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nombre",
                value: "Diagnóstico por imagen");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 7,
                column: "Nombre",
                value: "Enfermería");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 8,
                column: "Nombre",
                value: "Familia / General");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 9,
                column: "Nombre",
                value: "Fonoaudiología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 10,
                column: "Nombre",
                value: "Ginecología / Obstetricia");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 11,
                column: "Nombre",
                value: "Guardia");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 12,
                column: "Nombre",
                value: "Nutrición");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 13,
                column: "Nombre",
                value: "Odontología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 14,
                column: "Nombre",
                value: "Oftalmología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 15,
                column: "Nombre",
                value: "Pediatría");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 16,
                column: "Nombre",
                value: "Promotor de Salud");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 17,
                column: "Nombre",
                value: "Psicología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 18,
                column: "Nombre",
                value: "Psicopedagogía");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 19,
                column: "Nombre",
                value: "Trabajo Social");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 20,
                column: "Nombre",
                value: "Técnico en Farmacia");

            migrationBuilder.InsertData(
                table: "EspecialidadesCentrosSalud",
                columns: new[] { "CentroSaludId", "EspecialidadId" },
                values: new object[,]
                {
                    { 30, 15 },
                    { 18, 7 },
                    { 18, 19 },
                    { 20, 3 },
                    { 20, 4 },
                    { 20, 7 },
                    { 20, 8 },
                    { 20, 10 },
                    { 20, 12 },
                    { 20, 13 },
                    { 20, 15 },
                    { 20, 17 },
                    { 20, 19 },
                    { 20, 20 },
                    { 21, 2 },
                    { 21, 4 },
                    { 21, 6 },
                    { 21, 7 },
                    { 21, 8 },
                    { 21, 9 },
                    { 21, 10 },
                    { 21, 11 },
                    { 18, 4 },
                    { 17, 18 },
                    { 17, 17 },
                    { 17, 8 },
                    { 14, 19 },
                    { 15, 4 },
                    { 15, 7 },
                    { 15, 8 },
                    { 15, 10 },
                    { 15, 11 },
                    { 15, 13 },
                    { 15, 18 },
                    { 15, 19 },
                    { 16, 1 },
                    { 21, 14 },
                    { 16, 4 },
                    { 16, 8 },
                    { 16, 9 },
                    { 16, 10 },
                    { 16, 13 },
                    { 16, 15 },
                    { 16, 17 },
                    { 16, 18 },
                    { 16, 19 },
                    { 17, 4 },
                    { 17, 7 },
                    { 16, 7 },
                    { 30, 19 },
                    { 21, 15 },
                    { 21, 19 },
                    { 26, 4 },
                    { 26, 7 },
                    { 26, 10 },
                    { 26, 12 },
                    { 26, 13 },
                    { 26, 15 },
                    { 26, 17 },
                    { 26, 18 },
                    { 26, 19 },
                    { 27, 7 },
                    { 28, 4 },
                    { 28, 7 },
                    { 28, 8 },
                    { 28, 10 },
                    { 28, 13 },
                    { 28, 15 },
                    { 28, 19 },
                    { 30, 1 },
                    { 30, 7 },
                    { 30, 8 },
                    { 30, 10 },
                    { 25, 17 },
                    { 25, 15 },
                    { 25, 13 },
                    { 25, 10 },
                    { 22, 4 },
                    { 22, 7 },
                    { 22, 8 },
                    { 22, 10 },
                    { 22, 11 },
                    { 22, 16 },
                    { 22, 17 },
                    { 22, 18 },
                    { 14, 17 },
                    { 23, 7 },
                    { 21, 17 },
                    { 23, 8 },
                    { 23, 15 },
                    { 23, 19 },
                    { 24, 7 },
                    { 24, 8 },
                    { 24, 9 },
                    { 24, 10 },
                    { 24, 17 },
                    { 25, 4 },
                    { 25, 7 },
                    { 25, 8 },
                    { 23, 10 },
                    { 22, 19 },
                    { 14, 15 },
                    { 14, 12 },
                    { 4, 15 },
                    { 4, 17 },
                    { 4, 19 },
                    { 5, 1 },
                    { 5, 4 },
                    { 5, 7 },
                    { 5, 9 },
                    { 5, 10 },
                    { 5, 13 },
                    { 5, 15 },
                    { 5, 16 },
                    { 5, 19 },
                    { 4, 13 },
                    { 6, 1 },
                    { 6, 7 },
                    { 6, 8 },
                    { 6, 9 },
                    { 6, 10 },
                    { 6, 11 },
                    { 6, 13 },
                    { 6, 15 },
                    { 6, 17 },
                    { 6, 19 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 },
                    { 6, 4 },
                    { 4, 10 },
                    { 4, 9 },
                    { 4, 8 },
                    { 1, 8 },
                    { 1, 10 },
                    { 1, 13 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 19 },
                    { 2, 1 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 10 },
                    { 2, 12 },
                    { 2, 17 },
                    { 3, 4 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 19 },
                    { 4, 1 },
                    { 4, 4 },
                    { 4, 7 },
                    { 7, 10 },
                    { 7, 15 },
                    { 7, 17 },
                    { 7, 18 },
                    { 11, 11 },
                    { 11, 13 },
                    { 11, 15 },
                    { 11, 17 },
                    { 11, 19 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 4 },
                    { 12, 7 },
                    { 12, 8 },
                    { 12, 10 },
                    { 12, 13 },
                    { 12, 18 },
                    { 12, 19 },
                    { 13, 1 },
                    { 13, 4 },
                    { 13, 7 },
                    { 13, 8 },
                    { 13, 9 },
                    { 13, 10 },
                    { 13, 17 },
                    { 13, 19 },
                    { 14, 1 },
                    { 14, 4 },
                    { 14, 7 },
                    { 14, 8 },
                    { 14, 10 },
                    { 11, 10 },
                    { 14, 13 },
                    { 11, 9 },
                    { 11, 7 },
                    { 7, 19 },
                    { 8, 1 },
                    { 8, 4 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 9 },
                    { 8, 10 },
                    { 8, 15 },
                    { 8, 17 },
                    { 9, 1 },
                    { 9, 4 },
                    { 9, 7 },
                    { 9, 10 },
                    { 9, 13 },
                    { 9, 15 },
                    { 9, 17 },
                    { 9, 19 },
                    { 9, 18 },
                    { 10, 1 },
                    { 10, 7 },
                    { 10, 8 },
                    { 10, 10 },
                    { 10, 11 },
                    { 10, 13 },
                    { 10, 15 },
                    { 10, 17 },
                    { 11, 4 },
                    { 11, 8 },
                    { 1, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 2, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 7, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 8, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 8, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 9, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 9, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 9, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 10, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 10, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 11, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 11, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 11, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 11, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 12, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 12, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 12, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 13, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 13, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 13, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 13, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 14, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 14, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 14, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 14, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 14, 19 });

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
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 16, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 17, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 17, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 18, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 12 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 20, 20 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 6 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 14 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 21, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 22, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 22, 11 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 22, 16 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 22, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 22, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 22, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 23, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 23, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 23, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 23, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 24, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 24, 9 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 24, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 24, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 25, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 25, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 25, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 25, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 25, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 25, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 26, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 26, 12 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 26, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 26, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 26, 17 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 26, 18 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 26, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 28, 4 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 28, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 28, 13 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 28, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 28, 19 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 30, 7 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 30, 8 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 30, 10 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 30, 15 });

            migrationBuilder.DeleteData(
                table: "EspecialidadesCentrosSalud",
                keyColumns: new[] { "CentroSaludId", "EspecialidadId" },
                keyValues: new object[] { 30, 19 });

            migrationBuilder.CreateTable(
                name: "Colectivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Linea = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colectivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PracticasDiagnosticos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticasDiagnosticos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColectivosCentrosSalud",
                columns: table => new
                {
                    CentroSaludId = table.Column<int>(type: "int", nullable: false),
                    ColectivoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColectivosCentrosSalud", x => new { x.CentroSaludId, x.ColectivoId });
                    table.ForeignKey(
                        name: "FK_ColectivosCentrosSalud_CentrosSalud_CentroSaludId",
                        column: x => x.CentroSaludId,
                        principalTable: "CentrosSalud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColectivosCentrosSalud_Colectivos_ColectivoId",
                        column: x => x.ColectivoId,
                        principalTable: "Colectivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PracticasDiagnosticoCentrosSalud",
                columns: table => new
                {
                    CentroSaludId = table.Column<int>(type: "int", nullable: false),
                    PracticaDiagnosticoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticasDiagnosticoCentrosSalud", x => new { x.CentroSaludId, x.PracticaDiagnosticoId });
                    table.ForeignKey(
                        name: "FK_PracticasDiagnosticoCentrosSalud_CentrosSalud_CentroSaludId",
                        column: x => x.CentroSaludId,
                        principalTable: "CentrosSalud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PracticasDiagnosticoCentrosSalud_PracticasDiagnosticos_PracticaDiagnosticoId",
                        column: x => x.PracticaDiagnosticoId,
                        principalTable: "PracticasDiagnosticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                column: "Nombre",
                value: "Leonor Capelli");

            migrationBuilder.InsertData(
                table: "Colectivos",
                columns: new[] { "Id", "Linea" },
                values: new object[,]
                {
                    { 19, "520" },
                    { 18, "519 A" },
                    { 17, "519" },
                    { 16, "518" },
                    { 15, "517" },
                    { 14, "516" },
                    { 13, "514" },
                    { 12, "513 EX" },
                    { 11, "513" },
                    { 1, "319" },
                    { 9, "509" },
                    { 8, "507" },
                    { 7, "506" },
                    { 6, "505" },
                    { 5, "504" },
                    { 4, "503" },
                    { 3, "502" },
                    { 2, "500" },
                    { 10, "512" }
                });

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Alergia");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Cardiología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Clínica Médica");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nombre",
                value: "Dermatología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nombre",
                value: "Endocrinología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nombre",
                value: "Enfermería");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 7,
                column: "Nombre",
                value: "Estimulación Temprana");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 8,
                column: "Nombre",
                value: "Fonoaudiología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 9,
                column: "Nombre",
                value: "Gastroenterología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 10,
                column: "Nombre",
                value: "Ginecología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 11,
                column: "Nombre",
                value: "Hematología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 12,
                column: "Nombre",
                value: "Infectología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 13,
                column: "Nombre",
                value: "Inmunizaciones");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 14,
                column: "Nombre",
                value: "Kinesiología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 15,
                column: "Nombre",
                value: "Medicina Familiar");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 16,
                column: "Nombre",
                value: "Nefrología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 17,
                column: "Nombre",
                value: "Neumonología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 18,
                column: "Nombre",
                value: "Neurocirugía");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 19,
                column: "Nombre",
                value: "Neurología");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 20,
                column: "Nombre",
                value: "Nutrición");

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 31, "Urología" },
                    { 28, "Psicopedagogía" },
                    { 21, "Obstetricia" },
                    { 22, "Odontología" },
                    { 23, "Oftalmología" },
                    { 24, "Oncología" },
                    { 25, "Otorrinolaringología" },
                    { 26, "Pediatría" },
                    { 30, "Traumatología y Ortopedia" },
                    { 29, "Trabajo Social" },
                    { 27, "Psicología" }
                });

            migrationBuilder.InsertData(
                table: "PracticasDiagnosticos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 8, "Radiografías" },
                    { 1, "Ecografías" },
                    { 2, "Electrocardiogramas" },
                    { 3, "Electroencefalogramas" },
                    { 4, "Endoscopías" },
                    { 5, "Laboratorio de Análisis Clínicos" },
                    { 7, "Laboratorio de Hematología" },
                    { 9, "Tomografías" },
                    { 6, "Laboratorio de Anatomía Patológica" }
                });

            migrationBuilder.InsertData(
                table: "ColectivosCentrosSalud",
                columns: new[] { "CentroSaludId", "ColectivoId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "PracticasDiagnosticoCentrosSalud",
                columns: new[] { "CentroSaludId", "PracticaDiagnosticoId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ColectivosCentrosSalud_ColectivoId",
                table: "ColectivosCentrosSalud",
                column: "ColectivoId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticasDiagnosticoCentrosSalud_PracticaDiagnosticoId",
                table: "PracticasDiagnosticoCentrosSalud",
                column: "PracticaDiagnosticoId");
        }
    }
}
