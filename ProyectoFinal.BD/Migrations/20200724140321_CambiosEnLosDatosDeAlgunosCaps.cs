using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class CambiosEnLosDatosDeAlgunosCaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                column: "Barrio",
                value: "Barrio Latino");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                column: "Barrio",
                value: "Barrio Obrero");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                column: "Barrio",
                value: "Villa Moresino");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                column: "Barrio",
                value: "Kilómetro 5");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Barrio", "Nombre" },
                values: new object[] { "Ingeniero White", "Leonor Capelli" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Latitud", "Longitud" },
                values: new object[] { -38.705806000000003, -62.287013999999999 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38,
                column: "Barrio",
                value: "Noroeste");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39,
                column: "Barrio",
                value: "Juan B. Justo");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Barrio", "HorarioAtencion" },
                values: new object[] { "Sanchez Elia", "08:00 a 18:00" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43,
                column: "HorarioAtencion",
                value: "08:00 a 18:00");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                column: "Barrio",
                value: "Latino");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                column: "Barrio",
                value: "Obrero");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                column: "Barrio",
                value: "Spurr");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                column: "Barrio",
                value: "Pacífico");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Barrio", "Nombre" },
                values: new object[] { "", "Leonor Capelli (Ingeniero White)" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Latitud", "Longitud" },
                values: new object[] { -38.717370000000003, -62.227370000000001 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38,
                column: "Barrio",
                value: "San Blas");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39,
                column: "Barrio",
                value: "Boulevard Juan B. Justo");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Barrio", "HorarioAtencion" },
                values: new object[] { "Villa Sanchez Elia", "extensión CS 9 de noviembre" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43,
                column: "HorarioAtencion",
                value: "extensión CS 9 de noviembre");
        }
    }
}
