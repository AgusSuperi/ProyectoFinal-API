using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class BarriosCaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barrio",
                table: "CentrosSalud",
                maxLength: 80,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                column: "Barrio",
                value: "Altos Sánchez");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                column: "Barrio",
                value: "12 de Octubre");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 3,
                column: "Barrio",
                value: "Pedro Pico");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 4,
                column: "Barrio",
                value: "Aldea Romana");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 5,
                column: "Barrio",
                value: "Anchorena");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 6,
                column: "Barrio",
                value: "Avellaneda");

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
                keyValue: 9,
                column: "Barrio",
                value: "Bella Vista");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "San Cayetano", "Manuel Alberti 215" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                column: "Barrio",
                value: "Spurr");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 12,
                column: "Barrio",
                value: "Colón");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 13,
                column: "Barrio",
                value: "Villa Don Bosco");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "Enrique Julio", "Avda. General Arias 1730" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 15,
                column: "Barrio",
                value: "Coronel Estomba");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 16,
                column: "Barrio",
                value: "Grünbein");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                column: "Barrio",
                value: "Pacífico");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 18,
                column: "Barrio",
                value: "La Falda");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "General Cerri", "Francisco de Gurruchaga 40" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 20,
                column: "Barrio",
                value: "Vista Alegre");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                column: "Barrio",
                value: "ksyo");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "Loma Paraguaya", "Félix Frías 850" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 23,
                column: "Barrio",
                value: "Lujan");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "Coronel Maldonado", "Gral. Pablo Richieri 2535" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 25,
                column: "Barrio",
                value: "Mariano Moreno");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 26,
                column: "Barrio",
                value: "Villa Miramar");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 27,
                column: "Barrio",
                value: "Naposta");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 28,
                column: "Barrio",
                value: "Noroeste");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                column: "Barrio",
                value: "Altos Sánchez");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 30,
                column: "Barrio",
                value: "Nueva Belgrano");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 31,
                column: "Barrio",
                value: "Pampa Central");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 32,
                column: "Barrio",
                value: "Patagonia");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 33,
                column: "Barrio",
                value: "Pedro Pico");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 34,
                column: "Barrio",
                value: "Rivadavia");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 35,
                column: "Barrio",
                value: "Rosario Sur");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                column: "Barrio",
                value: "Saladero");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "San Cayetano", "Manuel Alberti 477" });

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
                column: "Barrio",
                value: "Villa Sanchez Elia");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 41,
                column: "Barrio",
                value: "Tiro Federal");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 42,
                column: "Barrio",
                value: "Universitario");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "Villa Amaducci", "Rastreador Fournier 1809" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Barrio", "Direccion", "Latitud", "Longitud" },
                values: new object[] { "Villa Bordeu", "Juan Larrea 5450", -38.688405000000003, -62.345480000000002 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 45,
                column: "Barrio",
                value: "Villa Delfina");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Barrio", "Latitud", "Longitud" },
                values: new object[] { "Rosario Sur", -38.746873000000001, -62.237960999999999 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 47,
                column: "Barrio",
                value: "Villa Floresta");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "Villa Cerrito", "Rufino Rojas 4898" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Barrio", "Nombre" },
                values: new object[] { "Villa Harding Green", "Villa Harding Green" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 50,
                column: "Barrio",
                value: "Villa Mitre");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 51,
                column: "Barrio",
                value: "Villa Muñiz");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 52,
                column: "Barrio",
                value: "Villa Nocito");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 53,
                column: "Barrio",
                value: "Villa Ressia");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 54,
                column: "Barrio",
                value: "Villa Rosas");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 55,
                column: "Barrio",
                value: "Villa Serra");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barrio",
                table: "CentrosSalud");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                column: "Direccion",
                value: "Alberti 215");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14,
                column: "Direccion",
                value: "Avda. Arias 1730");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 19,
                column: "Direccion",
                value: "Gurruchaga 40");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22,
                column: "Direccion",
                value: "Felix Frías 850");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24,
                column: "Direccion",
                value: "Richieri 2535");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37,
                column: "Direccion",
                value: "Alberti 477");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43,
                column: "Direccion",
                value: "Fournier 1809");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Direccion", "Latitud", "Longitud" },
                values: new object[] { "Larrea 5450", -38.714779999999998, -62.311369999999997 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Latitud", "Longitud" },
                values: new object[] { -38.729419999999998, -62.2605 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48,
                column: "Direccion",
                value: "Rojas 4898");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49,
                column: "Nombre",
                value: "Villa H. Green");
        }
    }
}
