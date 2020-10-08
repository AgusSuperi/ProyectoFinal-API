using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class CambioDeNombresCAPS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Leopoldo Marechal 1712", "08:00 a 18:00", -38.717370000000003, -62.227370000000001, "9 de Noviembre", 4822622 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Humboldt 3758", -38.739649999999997, -62.212719999999997, "12 de Octubre", 4811397 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "25 de Mayo 396", "Las 24 hs", -38.729410000000001, -62.262650000000001, "A. Menghini", 4840157 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Los Adobes 424", -38.682989999999997, -62.215170000000001, "Aldea Romana", 4862444 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "3 de Febrero 1658", -38.724510000000002, -62.237690000000001, "Anchorena", 4815400 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Nicaragua 2953", -38.690530000000003, -62.293439999999997, "Avellaneda", 4888350 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Charcas 906", -38.715159999999997, -62.24924, "Bella Vista", 4565569 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Lugones 46", "08:00 a 14:00", -38.690689999999996, -62.304180000000002, "Bº Latino", 4889859 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Alberti 215", "Las 24 hs", -38.700319999999998, -62.284280000000003, "Cabildo", 4918250 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Esmeralda 1450", -38.748260000000002, -62.245559999999998, "CIC Spurr", 4511862 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "O’Higgins 1637", "08:00 a 14:00", -38.734250000000003, -62.283949999999997, "Colon", 4554524 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "D`Orbigny 2578", "08:00 a 14:00", -38.72907, -62.223500000000001, "Don Bosco", 4814880 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Avda. Arias 1730", -38.750830000000001, -62.268889999999999, "Enrique Julio", 4556898 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Viamonte 2853", -38.699939999999998, -62.301450000000003, "Estomba", 4889026 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "La Rioja 5700", "08:00 a 18:00", -38.752609999999997, -62.176259999999999, "Grünbein", 4810938 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Maldonado 671", -38.710299999999997, -62.293860000000002, "Kilómetro 5", 4565567 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Adrián Veres y Martin Gil", -38.719299999999997, -62.315089999999998, "Leandro Piñeiro", 4546309 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Lautaro y Paul Harris", "Las 24 hs", -38.775539999999999, -62.27122, "Leonor Capelli - Ing. White", 4573132 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Felix Frías 850", "08:00 a 14:00", -38.747889999999998, -62.285899999999998, "Loma Paraguaya", 4565592 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Enrique Julio 806", -38.708060000000003, -62.299720000000001, "Lujan", 4888351 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Richieri 2535", -38.71734, -62.319479999999999, "Maldonado", 4550257 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Mendoza 1250", -38.720500000000001, -62.293309999999998, "Mariano Moreno", 4552088 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Laudelino Cruz 1892", "08:00 a 18:00", -38.708684599999998, -62.237235699999999, "Miramar", 4552417 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "19 de Mayo 769", -38.708269999999999, -62.26052, "Naposta (ext)", 4565562 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Líbano 589", -38.726959999999998, -62.289850000000001, "Noroeste", 4556878 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Vieytes 1616", "08:00 a 18:00", -38.717370000000003, -62.227370000000001, "Norte", 4888267 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Witcomb 3900", "08:00 a 14:00", -38.676279999999998, -62.296109999999999, "Nueva Belgrano", 4888268 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Jujuy 946", -38.725650000000002, -62.296169999999996, "Pampa Central", 4556939 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Lauquen 356", -38.697719999999997, -62.211730000000003, "Patagonia", 4862440 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Misiones 754", -38.73527, -62.263350000000003, "Pedro Pico", 4565559 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Estados Unidos 503", -38.738199999999999, -62.253799999999998, "Rivadavia", 4556927 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Venezuela 296", -38.739150000000002, -62.245719999999999, "Rosario Sur", 4821625 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Reconquista 2045", -38.770603999999999, -62.245449999999998, "Saladero", 4570427 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Alberti 477", -38.696959999999997, -62.280160000000002, "San Cayetano", 4888366 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Pacifico 154", -38.736339999999998, -62.292070000000002, "San Dionisio (Ext.)", 4550211 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Reconquista 3084", -38.779440000000001, -62.256219999999999, "San Jose Obrero", 4570474 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Bermudez 1580", "extensión CS 9 de noviembre", -38.720199999999998, -62.235520000000001, "Sanchez Elia", 4815419 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Pellegrini 638", "08:00 a 14:00", -38.721600000000002, -62.250210000000003, "Tiro Federal", 4554598 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Uruguay 463", -38.701560000000001, -62.274769999999997, "Universitario", 4565581 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Humboldt 56", -38.708159999999999, -62.253019999999999, "Vacunatorio - La Falda", 4554626 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Gurruchaga 40", -38.705910000000003, -62.413710000000002, "Vacunatorio - Laureano Muñiz", 4847220 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Larrea 5450", -38.714779999999998, -62.311369999999997, "Villa Bordeu", 4885679 });

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
                values: new object[] { "Juana Azurduy 1345", "08:00 a 14:00", -38.750140000000002, -62.275770000000001, "Villa Delfina", 4552271 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Berutti 2980", -38.729419999999998, -62.2605, "Villa Esperanza", 4813677 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "José Ingenieros 2235", -38.69153, -62.263590000000001, "Villa Floresta", 4888365 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Rojas 4898", -38.74982, -62.191670000000002, "Villa Gloria", 4817321 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Salinas Chicas 4150", -38.714480000000002, -62.189450000000001, "Villa H. Green", 4862447 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Washington 232", -38.730409999999999, -62.24653, "Villa Mitre", 4817261 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Chiclana 1974", -38.747190000000003, -62.229520000000001, "Villa Mitre - B. Obrero", 4821674 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Humboldt 3758", "08:00 a 14:00", -38.739649999999997, -62.212719999999997, "12 de Octubre", 4811397 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Los Adobes 424", -38.682989999999997, -62.215170000000001, "Aldea Romana", 4862444 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "3 de Febrero 1658", "08:00 a 14:00", -38.724510000000002, -62.237690000000001, "Anchorena", 4815400 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Nicaragua 2953", -38.690530000000003, -62.293439999999997, "Avellaneda", 4888350 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Chiclana 1974", -38.747190000000003, -62.229520000000001, "B.Obrero V.Mitre", 4821674 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Charcas 906", -38.715159999999997, -62.24924, "Bella Vista", 4565569 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Lugones 46", -38.690689999999996, -62.304180000000002, "Bº Latino", 4889859 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Alberti 215", "Atencion las 24 horas", -38.700319999999998, -62.284280000000003, "Cabildo", 4918250 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "25 de Mayo 396", "Atencion las 24 horas", -38.729410000000001, -62.262650000000001, "Centro de Salud “A. Menghini” Gral Daniel Cerri", 4840157 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Adrián Veres y Martin Gil", -38.719299999999997, -62.315089999999998, "Centro de Salud “Leandro Piñeiro”", 4546309 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Lautaro y Paul Harris", "Atencion las 24 horas", -38.775539999999999, -62.27122, "Centro de Salud “Leonor Capelli” de Ing. White", 4573132 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Leopoldo Marechal 1712", "08:00 a 18:00", -38.717370000000003, -62.227370000000001, "Centro de Salud 9 de Noviembre", 4822622 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Vieytes 1616", -38.717370000000003, -62.227370000000001, "Centro de Salud Norte", 4888267 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Esmeralda 1450", -38.748260000000002, -62.245559999999998, "CIC Spurr", 4511862 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "O’Higgins 1637", "08:00 a 14:00", -38.734250000000003, -62.283949999999997, "Colon", 4554524 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "D`Orbigny 2578", -38.72907, -62.223500000000001, "Don Bosco", 4814880 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Avda. Arias 1730", -38.750830000000001, -62.268889999999999, "Enrique Julio", 4556898 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Viamonte 2853", "08:00 a 18:00", -38.699939999999998, -62.301450000000003, "Estomba", 4889026 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "La Rioja 5700", "08:00 a 18:00", -38.752609999999997, -62.176259999999999, "Grünbein", 4810938 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Maldonado 671", -38.710299999999997, -62.293860000000002, "Kilómetro 5", 4565567 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Felix Frías 850", -38.747889999999998, -62.285899999999998, "Loma Paraguaya", 4565592 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Enrique Julio 806", -38.708060000000003, -62.299720000000001, "Lujan", 4888351 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Richieri 2535", "08:00 a 14:00", -38.71734, -62.319479999999999, "Maldonado", 4550257 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Mendoza 1250", -38.720500000000001, -62.293309999999998, "Mariano Moreno", 4552088 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Laudelino Cruz 1892", -38.708684599999998, -62.237235699999999, "Miramar", 4552417 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "19 de Mayo 769", "08:00 a 14:00", -38.708269999999999, -62.26052, "Naposta (ext)", 4565562 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Líbano 589", "08:00 a 18:00", -38.726959999999998, -62.289850000000001, "Noroeste", 4556878 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Witcomb 3900", -38.676279999999998, -62.296109999999999, "Nueva Belgrano", 4888268 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Jujuy 946", -38.725650000000002, -62.296169999999996, "Pampa Central", 4556939 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Lauquen 356", -38.697719999999997, -62.211730000000003, "Patagonia", 4862440 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Misiones 754", -38.73527, -62.263350000000003, "Pedro Pico", 4565559 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Estados Unidos 503", -38.738199999999999, -62.253799999999998, "Rivadavia", 4556927 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Venezuela 296", -38.739150000000002, -62.245719999999999, "Rosario Sur", 4821625 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Reconquista 2045", -38.770603999999999, -62.245449999999998, "Saladero", 4570427 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Alberti 477", -38.696959999999997, -62.280160000000002, "San Cayetano", 4888366 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Pacifico 154", -38.736339999999998, -62.292070000000002, "San Dionisio (Ext.)", 4550211 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Reconquista 3084", "08:00 a 14:00", -38.779440000000001, -62.256219999999999, "San Jose Obrero", 4570474 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Bermudez 1580", "extensión CS 9 de noviembre", -38.720199999999998, -62.235520000000001, "Sanchez Elia", 4815419 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Pellegrini 638", -38.721600000000002, -62.250210000000003, "Tiro Federal", 4554598 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Uruguay 463", -38.701560000000001, -62.274769999999997, "Universitario", 4565581 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Humboldt 56", -38.708159999999999, -62.253019999999999, "Vacunatorio Municipal “La Falda” ", 4554626 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Gurruchaga 40", -38.705910000000003, -62.413710000000002, "Vacunatorio Municipal “Laureano Muñiz”", 4847220 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Larrea 5450", "08:00 a 14:00", -38.714779999999998, -62.311369999999997, "Villa Bordeu", 4885679 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Direccion", "HorarioAtencion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Fournier 1809", "extensión CS 9 de noviembre", -38.723370000000003, -62.226770000000002, "Villa Amaducci", 4810155 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Juana Azurduy 1345", -38.750140000000002, -62.275770000000001, "Villa Delfina", 4552271 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Berutti 2980", -38.729419999999998, -62.2605, "Villa Esperanza", 4813677 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "José Ingenieros 2235", -38.69153, -62.263590000000001, "Villa Floresta", 4888365 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Rojas 4898", -38.74982, -62.191670000000002, "Villa Gloria", 4817321 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Salinas Chicas 4150", -38.714480000000002, -62.189450000000001, "Villa Harding Green", 4862447 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Direccion", "Latitud", "Longitud", "Nombre", "Telefono" },
                values: new object[] { "Washington 232", -38.730409999999999, -62.24653, "Villa Mitre", 4817261 });
        }
    }
}
