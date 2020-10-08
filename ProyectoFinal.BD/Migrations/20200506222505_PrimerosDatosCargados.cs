using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal.BD.Migrations
{
    public partial class PrimerosDatosCargados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Direccion", "HorarioAtencion", "Nombre", "RestriccionEdad", "Telefono" },
                values: new object[] { "Humboldt 3758", "08:00 a 14:00", "12 de Octubre", "", 4811397 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Direccion", "Nombre", "Telefono" },
                values: new object[] { "Los Adobes 424", "Aldea Romana", 4862444 });

            migrationBuilder.InsertData(
                table: "CentrosSalud",
                columns: new[] { "Id", "Direccion", "HorarioAtencion", "Nombre", "RestriccionEdad", "Telefono" },
                values: new object[,]
                {
                    { 33, "Venezuela 296", "08:00 a 14:00", "Rosario Sur", "", 4821625 },
                    { 34, "Reconquista 2045", "08:00 a 14:00", "Saladero", "", 4570427 },
                    { 35, "Alberti 477", "08:00 a 14:00", "San Cayetano", "", 4888366 },
                    { 36, "Pacifico 154", "08:00 a 14:00", "San Dionisio (Ext.)", "", 4550211 },
                    { 37, "Reconquista 3084", "08:00 a 14:00", "San Jose Obrero", "", 4570474 },
                    { 38, "Bermudez 1580", "extensión CS 9 de noviembre", "Sanchez Elia", "", 4815419 },
                    { 39, "Pellegrini 638", "08:00 a 14:00", "Tiro Federal", "", 4554598 },
                    { 40, "Uruguay 463", "08:00 a 14:00", "Universitario", "", 4565581 },
                    { 41, "Salinas Chicas 4150", "08:00 a 14:00", "V. Harding Green", "", 4862447 },
                    { 42, "Humboldt 56", "08:00 a 14:00", "Vacunatorio Municipal “La Falda” ", "", 4554626 },
                    { 43, "Gurruchaga 40", "08:00 a 14:00", "Vacunatorio Municipal “Laureano Muñiz”", "", 4847220 },
                    { 44, "Larrea 5450", "08:00 a 14:00", "Villa Bordeu", "", 4885679 },
                    { 45, "Fournier 1809", "extensión CS 9 de noviembre", "Villa Amaducci", "", 4810155 },
                    { 46, "Juana Azurduy 1345", "08:00 a 14:00", "Villa Delfina", "", 4552271 },
                    { 47, "Berutti 2980", "08:00 a 14:00", "Villa Esperanza", "", 4813677 },
                    { 48, "José Ingenieros 2235", "08:00 a 14:00", "Villa Floresta", "", 4888365 },
                    { 49, "Rojas 4898", "08:00 a 14:00", "Villa Gloria", "", 4817321 },
                    { 50, "Washington 232", "08:00 a 14:00", "Villa Mitre", "", 4817261 },
                    { 51, "Pilcaniyen 259", "08:00 a 14:00", "Villa Muñiz", "", 4811080 },
                    { 52, "Pacifico 1925", "08:00 a 14:00", "Villa Nocito", "", 4550240 },
                    { 53, "Misiones 1570", "08:00 a 14:00", "Villa Ressia", "", 4565591 },
                    { 54, "Libertad 1955", "08:00 a 14:00", "Villa Rosas", "", 4552418 },
                    { 55, "Tarija 1350", "08:00 a 14:00", "Villa Serra", "", 4560139 },
                    { 32, "Estados Unidos 503", "08:00 a 14:00", "Rivadavia", "", 4556927 },
                    { 31, "Misiones 754", "08:00 a 14:00", "Pedro Pico", "", 4565559 },
                    { 3, "3 de Febrero 1658", "08:00 a 14:00", "Anchorena", "", 4815400 },
                    { 29, "Jujuy 946", "08:00 a 14:00", "Pampa Central", "", 4556939 },
                    { 4, "Nicaragua 2953", "08:00 a 14:00", "Avellaneda", "", 4888350 },
                    { 30, "Lauquen 356", "08:00 a 14:00", "Patagonia", "", 4862440 },
                    { 5, "Chiclana 1974", "08:00 a 14:00", "B.Obrero V.Mitre", "", 4821674 },
                    { 6, "Charcas 906", "08:00 a 14:00", "Bella Vista", "", 4565569 },
                    { 7, "Lugones 46", "08:00 a 14:00", "Bº Latino", "", 4889859 },
                    { 8, "Alberti 215", "Atencion las 24 horas", "Cabildo", "", 4918250 },
                    { 9, "25 de Mayo 396", "Atencion las 24 horas", "Centro de Salud “A. Menghini” Gral Daniel Cerri", "", 4840157 },
                    { 10, "Adrián Veres y Martin Gil", "08:00 a 18:00", "Centro de Salud “Leandro Piñeiro”", "", 4546309 },
                    { 11, "Lautaro y Paul Harris", "Atencion las 24 horas", "Centro de Salud “Leonor Capelli” de Ing. White", "", 4573132 },
                    { 13, "Vieytes 1616", "08:00 a 18:00", "Centro de Salud Norte", "", 4888267 },
                    { 14, "Esmeralda 1450", "08:00 a 18:00", "CIC Spurr", "", 4511862 },
                    { 15, "O’Higgins 1637", "08:00 a 14:00", "Colon", "", 4554524 },
                    { 12, "Leopoldo Marechal 1712", "08:00 a 18:00", "Centro de Salud 9 de Noviembre", "", 4822622 },
                    { 17, "Avda. Arias 1730", "08:00 a 18:00", "Enrique Julio", "", 4556898 },
                    { 28, "Witcomb 3900", "08:00 a 14:00", "Nueva Belgrano", "", 4888268 },
                    { 27, "Líbano 589", "08:00 a 18:00", "Noroeste", "", 4556878 },
                    { 16, "D`Orbigny 2578", "08:00 a 14:00", "Don Bosco", "", 4814880 },
                    { 25, "Laudelino Cruz 1892", "08:00 a 18:00", "Miramar", "", 4552417 },
                    { 24, "Mendoza 1250", "08:00 a 14:00", "Mariano Moreno", "", 4552088 },
                    { 23, "Richieri 2535", "08:00 a 14:00", "Maldonado", "", 4550257 },
                    { 26, "19 de Mayo 769", "08:00 a 14:00", "Naposta (ext)", "", 4565562 },
                    { 21, "Felix Frías 850", "08:00 a 14:00", "Loma Paraguaya", "", 4565592 },
                    { 20, "Maldonado 671", "08:00 a 14:00", "Kilometro 5", "", 4565567 },
                    { 19, "La Rioja 5700", "08:00 a 18:00", "Grünbein", "", 4810938 },
                    { 18, "Viamonte 2853", "08:00 a 18:00", "Estomba", "", 4889026 },
                    { 22, "Enrique Julio 806", "08:00 a 14:00", "Lujan", "", 4888351 }
                });

            migrationBuilder.UpdateData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Linea",
                value: "319");

            migrationBuilder.InsertData(
                table: "Colectivos",
                columns: new[] { "Id", "Linea" },
                values: new object[,]
                {
                    { 13, "514" },
                    { 18, "519 A" },
                    { 17, "519" },
                    { 16, "518" },
                    { 15, "517" },
                    { 14, "516" },
                    { 12, "513 EX" },
                    { 19, "520" },
                    { 10, "512" },
                    { 2, "500" },
                    { 11, "513" },
                    { 3, "502" },
                    { 4, "503" },
                    { 5, "504" },
                    { 7, "506" },
                    { 9, "509" },
                    { 6, "505" },
                    { 8, "507" }
                });

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Alergia");

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 20, "Nutrición" },
                    { 21, "Obstetricia" },
                    { 23, "Oftalmología" },
                    { 24, "Oncología" },
                    { 26, "Pediatría" },
                    { 27, "Psicología" },
                    { 28, "Psicopedagogía" },
                    { 29, "Trabajo Social" },
                    { 30, "Traumatología y Ortopedia" },
                    { 31, "Urología" },
                    { 25, "Otorrinolaringología" },
                    { 18, "Neurocirugía" },
                    { 22, "Odontología" },
                    { 16, "Nefrología" },
                    { 2, "Cardiología" },
                    { 3, "Clínica Médica" },
                    { 17, "Neumonología" },
                    { 5, "Endocrinología" },
                    { 6, "Enfermería" },
                    { 7, "Estimulación Temprana" },
                    { 8, "Fonoaudiología" },
                    { 4, "Dermatología" },
                    { 10, "Ginecología" },
                    { 15, "Medicina Familiar" },
                    { 14, "Kinesiología" },
                    { 9, "Gastroenterología" },
                    { 19, "Neurología" },
                    { 13, "Inmunizaciones" },
                    { 12, "Infectología" },
                    { 11, "Hematología" }
                });

            migrationBuilder.UpdateData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Ecografías");

            migrationBuilder.InsertData(
                table: "PracticasDiagnosticos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 3, "Electroencefalogramas" },
                    { 4, "Endoscopías" },
                    { 5, "Laboratorio de Análisis Clínicos" },
                    { 7, "Laboratorio de Hematología" },
                    { 8, "Radiografías" },
                    { 9, "Tomografías" },
                    { 2, "Electrocardiogramas" },
                    { 6, "Laboratorio de Anatomía Patológica" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 20);

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

            migrationBuilder.DeleteData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Direccion", "HorarioAtencion", "Nombre", "RestriccionEdad", "Telefono" },
                values: new object[] { "en la loma del culo", "no trabja nunca", "Matias", "ancianas", 294 });

            migrationBuilder.UpdateData(
                table: "CentrosSalud",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Direccion", "Nombre", "Telefono" },
                values: new object[] { "Humboldt 3758", "12 de Octubre", 4811397 });

            migrationBuilder.UpdateData(
                table: "Colectivos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Linea",
                value: "503");

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "verdulero");

            migrationBuilder.UpdateData(
                table: "PracticasDiagnosticos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "prostata");
        }
    }
}
