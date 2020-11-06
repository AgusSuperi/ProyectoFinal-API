using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class CambiosEnLasDirecciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                column: "Direccion",
                value: "Leopoldo Marechal 1712, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                column: "Direccion",
                value: "Humboldt 3758, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Barrio", "Direccion", "Latitud", "Longitud" },
                values: new object[] { "General Daniel Cerri", "25 de Mayo 396, Gral Daniel Cerri, Provincia de Buenos Aires", -38.718364000000001, -62.391708000000001 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 4,
                column: "Direccion",
                value: "Los Adobes 424, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 5,
                column: "Direccion",
                value: "3 de Febrero 1658, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 6,
                column: "Direccion",
                value: "Nicaragua 2953, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                column: "Direccion",
                value: "Lugones 46, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                column: "Direccion",
                value: "Chiclana 1974, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 9,
                column: "Direccion",
                value: "Charcas 906, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                column: "Direccion",
                value: "Alberti 215, Cabildo, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                column: "Direccion",
                value: "Esmeralda 1450, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 12,
                column: "Direccion",
                value: "O’Higgins 1637, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 13,
                column: "Direccion",
                value: "D`Orbigny 2578, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14,
                column: "Direccion",
                value: "Avda. General Arias 1730, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 16,
                column: "Direccion",
                value: "La Rioja 5700, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                column: "Direccion",
                value: "Maldonado 671, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 18,
                column: "Direccion",
                value: "Humboldt 56, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Barrio", "Direccion" },
                values: new object[] { "General Daniel Cerri", "Francisco de Gurruchaga 40, Gral Daniel Cerri, Provincia de Buenos Aires" });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 20,
                column: "Direccion",
                value: "Adrián Veres 2050, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                column: "Direccion",
                value: "Harris 3599, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22,
                column: "Direccion",
                value: "Félix Frías 850, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 23,
                column: "Direccion",
                value: "Enrique Julio 806, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24,
                column: "Direccion",
                value: "Gral. Pablo Richieri 2535, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 25,
                column: "Direccion",
                value: "Mendoza 1250, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 26,
                column: "Direccion",
                value: "Laudelino Cruz 1892, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 27,
                column: "Direccion",
                value: "19 de Mayo 769, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 28,
                column: "Direccion",
                value: "Líbano 589, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                column: "Direccion",
                value: "Vieytes 2616, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 30,
                column: "Direccion",
                value: "Witcomb 3900, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 31,
                column: "Direccion",
                value: "Jujuy 946, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 32,
                column: "Direccion",
                value: "Lauquen 356, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 33,
                column: "Direccion",
                value: "Misiones 754, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 34,
                column: "Direccion",
                value: "Estados Unidos 503, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 35,
                column: "Direccion",
                value: "Venezuela 296, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                column: "Direccion",
                value: "Reconquista 2045, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37,
                column: "Direccion",
                value: "Manuel Alberti 477, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38,
                column: "Direccion",
                value: "Pacifico 154, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39,
                column: "Direccion",
                value: "Reconquista 3084, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40,
                column: "Direccion",
                value: "Bermudez 1580, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 41,
                column: "Direccion",
                value: "Pellegrini 638, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 42,
                column: "Direccion",
                value: "Uruguay 463, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44,
                column: "Direccion",
                value: "Juan Larrea 5450, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 45,
                column: "Direccion",
                value: "Juana Azurduy 1345, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46,
                column: "Direccion",
                value: "Berutti 2980, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 47,
                column: "Direccion",
                value: "José Ingenieros 2235, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48,
                column: "Direccion",
                value: "Ricardo Rojas 4898, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49,
                column: "Direccion",
                value: "Salinas Chicas 4150, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 50,
                column: "Direccion",
                value: "Washington 232, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 51,
                column: "Direccion",
                value: "Pilcaniyen 259, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 52,
                column: "Direccion",
                value: "Pacifico 1925, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 53,
                column: "Direccion",
                value: "Misiones 1570, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 54,
                column: "Direccion",
                value: "Libertad 1955, Bahía Blanca, Provincia de Buenos Aires");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 55,
                column: "Direccion",
                value: "Tarija 1350, Bahía Blanca, Provincia de Buenos Aires");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                column: "Direccion",
                value: "Leopoldo Marechal 1712");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                column: "Direccion",
                value: "Humboldt 3758");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Barrio", "Direccion", "Latitud", "Longitud" },
                values: new object[] { "Pedro Pico", "25 de Mayo 396", -38.729410000000001, -62.262650000000001 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 4,
                column: "Direccion",
                value: "Los Adobes 424");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 5,
                column: "Direccion",
                value: "3 de Febrero 1658");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 6,
                column: "Direccion",
                value: "Nicaragua 2953");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                column: "Direccion",
                value: "Lugones 46");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                column: "Direccion",
                value: "Chiclana 1974");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 9,
                column: "Direccion",
                value: "Charcas 906");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                column: "Direccion",
                value: "Alberti 215");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                column: "Direccion",
                value: "Esmeralda 1450");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 12,
                column: "Direccion",
                value: "O’Higgins 1637");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 13,
                column: "Direccion",
                value: "D`Orbigny 2578");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14,
                column: "Direccion",
                value: "Avda. General Arias 1730");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 16,
                column: "Direccion",
                value: "La Rioja 5700");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                column: "Direccion",
                value: "Maldonado 671");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 18,
                column: "Direccion",
                value: "Humboldt 56");

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
                column: "Direccion",
                value: "Adrián Veres y Martin Gil");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                column: "Direccion",
                value: "Lautaro y Paul Harris");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22,
                column: "Direccion",
                value: "Félix Frías 850");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 23,
                column: "Direccion",
                value: "Enrique Julio 806");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24,
                column: "Direccion",
                value: "Gral. Pablo Richieri 2535");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 25,
                column: "Direccion",
                value: "Mendoza 1250");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 26,
                column: "Direccion",
                value: "Laudelino Cruz 1892");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 27,
                column: "Direccion",
                value: "19 de Mayo 769");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 28,
                column: "Direccion",
                value: "Líbano 589");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                column: "Direccion",
                value: "Vieytes 2616");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 30,
                column: "Direccion",
                value: "Witcomb 3900");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 31,
                column: "Direccion",
                value: "Jujuy 946");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 32,
                column: "Direccion",
                value: "Lauquen 356");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 33,
                column: "Direccion",
                value: "Misiones 754");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 34,
                column: "Direccion",
                value: "Estados Unidos 503");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 35,
                column: "Direccion",
                value: "Venezuela 296");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                column: "Direccion",
                value: "Reconquista 2045");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37,
                column: "Direccion",
                value: "Manuel Alberti 477");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38,
                column: "Direccion",
                value: "Pacifico 154");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39,
                column: "Direccion",
                value: "Reconquista 3084");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40,
                column: "Direccion",
                value: "Bermudez 1580");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 41,
                column: "Direccion",
                value: "Pellegrini 638");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 42,
                column: "Direccion",
                value: "Uruguay 463");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44,
                column: "Direccion",
                value: "Juan Larrea 5450");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 45,
                column: "Direccion",
                value: "Juana Azurduy 1345");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46,
                column: "Direccion",
                value: "Berutti 2980");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 47,
                column: "Direccion",
                value: "José Ingenieros 2235");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48,
                column: "Direccion",
                value: "Ricardo Rojas 4898");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49,
                column: "Direccion",
                value: "Salinas Chicas 4150");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 50,
                column: "Direccion",
                value: "Washington 232");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 51,
                column: "Direccion",
                value: "Pilcaniyen 259");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 52,
                column: "Direccion",
                value: "Pacifico 1925");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 53,
                column: "Direccion",
                value: "Misiones 1570");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 54,
                column: "Direccion",
                value: "Libertad 1955");

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 55,
                column: "Direccion",
                value: "Tarija 1350");
        }
    }
}
