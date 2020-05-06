using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.BD
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CentroSalud>().HasData(
                new CentroSalud
                {
                    Id = 1,
                    Nombre = "12 de Octubre",
                    Direccion = "Humboldt 3758",
                    Telefono = 4811397,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 2,
                    Nombre = "Aldea Romana",
                    Direccion = "Los Adobes 424",
                    Telefono = 4862444,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 3,
                    Nombre = "Anchorena",
                    Direccion = "3 de Febrero 1658",
                    Telefono = 4815400,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 4,
                    Nombre = "Avellaneda",
                    Direccion = "Nicaragua 2953",
                    Telefono = 4888350,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 5,
                    Nombre = "B.Obrero V.Mitre",
                    Direccion = "Chiclana 1974",
                    Telefono = 4821674,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 6,
                    Nombre = "Bella Vista",
                    Direccion = "Charcas 906",
                    Telefono = 4565569,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 7,
                    Nombre = "Bº Latino",
                    Direccion = "Lugones 46",
                    Telefono = 4889859,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 8,
                    Nombre = "Cabildo",
                    Direccion = "Alberti 215",
                    Telefono = 4918250,
                    HorarioAtencion = "Atencion las 24 horas",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 9,
                    Nombre = "Centro de Salud “A. Menghini” Gral Daniel Cerri",
                    Direccion = "25 de Mayo 396",
                    Telefono = 4840157,
                    HorarioAtencion = "Atencion las 24 horas",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 10,
                    Nombre = "Centro de Salud “Leandro Piñeiro”",
                    Direccion = "Adrián Veres y Martin Gil",
                    Telefono = 4546309,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 11,
                    Nombre = "Centro de Salud “Leonor Capelli” de Ing. White",
                    Direccion = "Lautaro y Paul Harris",
                    Telefono = 4573132,
                    HorarioAtencion = "Atencion las 24 horas",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 12,
                    Nombre = "Centro de Salud 9 de Noviembre",
                    Direccion = "Leopoldo Marechal 1712",
                    Telefono = 4822622,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 13,
                    Nombre = "Centro de Salud Norte",
                    Direccion = "Vieytes 1616",
                    Telefono = 4888267,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 14,
                    Nombre = "CIC Spurr",
                    Direccion = "Esmeralda 1450",
                    Telefono = 4511862,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 15,
                    Nombre = "Colon",
                    Direccion = "O’Higgins 1637",
                    Telefono = 4554524,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 16,
                    Nombre = "Don Bosco",
                    Direccion = "D`Orbigny 2578",
                    Telefono = 4814880,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 17,
                    Nombre = "Enrique Julio",
                    Direccion = "Avda. Arias 1730",
                    Telefono = 4556898,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 18,
                    Nombre = "Estomba",
                    Direccion = "Viamonte 2853",
                    Telefono = 4889026,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 19,
                    Nombre = "Grünbein",
                    Direccion = "La Rioja 5700",
                    Telefono = 4810938,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 20,
                    Nombre = "Kilometro 5",
                    Direccion = "Maldonado 671",
                    Telefono = 4565567,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 21,
                    Nombre = "Loma Paraguaya",
                    Direccion = "Felix Frías 850",
                    Telefono = 4565592,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 22,
                    Nombre = "Lujan",
                    Direccion = "Enrique Julio 806",
                    Telefono = 4888351,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 23,
                    Nombre = "Maldonado",
                    Direccion = "Richieri 2535",
                    Telefono = 4550257,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 24,
                    Nombre = "Mariano Moreno",
                    Direccion = "Mendoza 1250",
                    Telefono = 4552088,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 25,
                    Nombre = "Miramar",
                    Direccion = "Laudelino Cruz 1892",
                    Telefono = 4552417,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 26,
                    Nombre = "Naposta (ext)",
                    Direccion = "19 de Mayo 769",
                    Telefono = 4565562,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 27,
                    Nombre = "Noroeste",
                    Direccion = "Líbano 589",
                    Telefono = 4556878,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 28,
                    Nombre = "Nueva Belgrano",
                    Direccion = "Witcomb 3900",
                    Telefono = 4888268,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 29,
                    Nombre = "Pampa Central",
                    Direccion = "Jujuy 946",
                    Telefono = 4556939,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 30,
                    Nombre = "Patagonia",
                    Direccion = "Lauquen 356",
                    Telefono = 4862440,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 31,
                    Nombre = "Pedro Pico",
                    Direccion = "Misiones 754",
                    Telefono = 4565559,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 32,
                    Nombre = "Rivadavia",
                    Direccion = "Estados Unidos 503",
                    Telefono = 4556927,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 33,
                    Nombre = "Rosario Sur",
                    Direccion = "Venezuela 296",
                    Telefono = 4821625,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 34,
                    Nombre = "Saladero",
                    Direccion = "Reconquista 2045",
                    Telefono = 4570427,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 35,
                    Nombre = "San Cayetano",
                    Direccion = "Alberti 477",
                    Telefono = 4888366,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 36,
                    Nombre = "San Dionisio (Ext.)",
                    Direccion = "Pacifico 154",
                    Telefono = 4550211,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 37,
                    Nombre = "San Jose Obrero",
                    Direccion = "Reconquista 3084",
                    Telefono = 4570474,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 38,
                    Nombre = "Sanchez Elia",
                    Direccion = "Bermudez 1580",
                    Telefono = 4815419,
                    HorarioAtencion = "extensión CS 9 de noviembre",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 39,
                    Nombre = "Tiro Federal",
                    Direccion = "Pellegrini 638",
                    Telefono = 4554598,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 40,
                    Nombre = "Universitario",
                    Direccion = "Uruguay 463",
                    Telefono = 4565581,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 41,
                    Nombre = "V. Harding Green",
                    Direccion = "Salinas Chicas 4150",
                    Telefono = 4862447,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 42,
                    Nombre = "Vacunatorio Municipal “La Falda” ",
                    Direccion = "Humboldt 56",
                    Telefono = 4554626,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 43,
                    Nombre = "Vacunatorio Municipal “Laureano Muñiz”",
                    Direccion = "Gurruchaga 40",
                    Telefono = 4847220,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 44,
                    Nombre = "Villa Bordeu",
                    Direccion = "Larrea 5450",
                    Telefono = 4885679,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 45,
                    Nombre = "Villa Amaducci",
                    Direccion = "Fournier 1809",
                    Telefono = 4810155,
                    HorarioAtencion = "extensión CS 9 de noviembre",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 46,
                    Nombre = "Villa Delfina",
                    Direccion = "Juana Azurduy 1345",
                    Telefono = 4552271,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 47,
                    Nombre = "Villa Esperanza",
                    Direccion = "Berutti 2980",
                    Telefono = 4813677,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 48,
                    Nombre = "Villa Floresta",
                    Direccion = "José Ingenieros 2235",
                    Telefono = 4888365,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 49,
                    Nombre = "Villa Gloria",
                    Direccion = "Rojas 4898",
                    Telefono = 4817321,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 50,
                    Nombre = "Villa Mitre",
                    Direccion = "Washington 232",
                    Telefono = 4817261,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 51,
                    Nombre = "Villa Muñiz",
                    Direccion = "Pilcaniyen 259",
                    Telefono = 4811080,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 52,
                    Nombre = "Villa Nocito",
                    Direccion = "Pacifico 1925",
                    Telefono = 4550240,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 53,
                    Nombre = "Villa Ressia",
                    Direccion = "Misiones 1570",
                    Telefono = 4565591,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 54,
                    Nombre = "Villa Rosas",
                    Direccion = "Libertad 1955",
                    Telefono = 4552418,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                },

                new CentroSalud
                {
                    Id = 55,
                    Nombre = "Villa Serra",
                    Direccion = "Tarija 1350",
                    Telefono = 4560139,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                });

            modelBuilder.Entity<Colectivo>().HasData(
                new Colectivo
                {
                    Id = 1,
                    Linea = "319"
                },

                new Colectivo
                {
                    Id = 2,
                    Linea = "500"
                },

                new Colectivo
                {
                    Id = 3,
                    Linea = "502"
                },

                new Colectivo
                {
                    Id = 4,
                    Linea = "503"
                },

                new Colectivo
                {
                    Id = 5,
                    Linea = "504"
                },

                new Colectivo
                {
                    Id = 6,
                    Linea = "505"
                },

                new Colectivo
                {
                    Id = 7,
                    Linea = "506"
                },

                new Colectivo
                {
                    Id = 8,
                    Linea = "507"
                },

                new Colectivo
                {
                    Id = 9,
                    Linea = "509"
                },

               new Colectivo
                {
                    Id = 10,
                    Linea = "512"
                },

                new Colectivo
                {
                    Id = 11,
                    Linea = "513"
                },

                new Colectivo
                {
                    Id = 12,
                    Linea = "513 EX"
                },

                new Colectivo
                {
                    Id = 13,
                    Linea = "514"
                },

                new Colectivo
                {
                    Id = 14,
                    Linea = "516"
                },

                new Colectivo
                {
                    Id = 15,
                    Linea = "517"
                },

                new Colectivo
                {
                    Id = 16,
                    Linea = "518"
                },

                new Colectivo
                {
                    Id = 17,
                    Linea = "519"
                },

                new Colectivo
                {
                    Id = 18,
                    Linea = "519 A"
                },

                new Colectivo
                {
                    Id = 19,
                    Linea = "520"
                });

            modelBuilder.Entity<Especialidad>().HasData(
                new Especialidad
                {
                    Id = 1,
                    Nombre = "Alergia"
                },

                new Especialidad
                {
                    Id = 2,
                    Nombre = "Cardiología"
                },

                new Especialidad
                {
                    Id = 3,
                    Nombre = "Clínica Médica"
                },

                new Especialidad
                {
                    Id = 4,
                    Nombre = "Dermatología"
                },

                new Especialidad
                {
                    Id = 5,
                    Nombre = "Endocrinología"
                },

                new Especialidad
                {
                    Id = 6,
                    Nombre = "Enfermería"
                },

                new Especialidad
                {
                    Id = 7,
                    Nombre = "Estimulación Temprana"
                },

                new Especialidad
                {
                    Id = 8,
                    Nombre = "Fonoaudiología"
                },

                new Especialidad
                {
                    Id = 9,
                    Nombre = "Gastroenterología"
                },

                new Especialidad
                {
                    Id = 10,
                    Nombre = "Ginecología"
                },

                new Especialidad
                {
                    Id = 11,
                    Nombre = "Hematología"
                },

                new Especialidad
                {
                    Id = 12,
                    Nombre = "Infectología"
                },

                 new Especialidad
                 {
                     Id = 13,
                     Nombre = "Inmunizaciones"
                 },

                new Especialidad
                {
                    Id = 14,
                    Nombre = "Kinesiología"
                },

                new Especialidad
                {
                    Id = 15,
                    Nombre = "Medicina Familiar"
                },

                new Especialidad
                {
                    Id = 16,
                    Nombre = "Nefrología"
                },

                new Especialidad
                {
                    Id = 17,
                    Nombre = "Neumonología"
                },

                new Especialidad
                {
                    Id = 18,
                    Nombre = "Neurocirugía"
                },

                new Especialidad
                {
                    Id = 19,
                    Nombre = "Neurología"
                },

                new Especialidad
                {
                    Id = 20,
                    Nombre = "Nutrición"
                },

                new Especialidad
                {
                    Id = 21,
                    Nombre = "Obstetricia"
                },

                new Especialidad
                {
                    Id = 22,
                    Nombre = "Odontología"
                },

                new Especialidad
                {
                    Id = 23,
                    Nombre = "Oftalmología"
                },

                new Especialidad
                {
                    Id = 24,
                    Nombre = "Oncología"
                },

                new Especialidad
                {
                    Id = 25,
                    Nombre = "Otorrinolaringología"
                },

                new Especialidad
                {
                    Id = 26,
                    Nombre = "Pediatría"
                },

                new Especialidad
                {
                    Id = 27,
                    Nombre = "Psicología"
                },

                new Especialidad
                {
                    Id = 28,
                    Nombre = "Psicopedagogía"
                },

                new Especialidad
                {
                    Id = 29,
                    Nombre = "Trabajo Social"
                },

                new Especialidad
                {
                    Id = 30,
                    Nombre = "Traumatología y Ortopedia"
                },

                new Especialidad
                {
                    Id = 31,
                    Nombre = "Urología"
                });

            modelBuilder.Entity<PracticaDiagnostico>().HasData(
                new PracticaDiagnostico
                {
                    Id = 1,
                    Nombre = "Ecografías"
                },

                new PracticaDiagnostico
                {
                    Id = 2,
                    Nombre = "Electrocardiogramas"
                },

                new PracticaDiagnostico
                {
                    Id = 3,
                    Nombre = "Electroencefalogramas"
                },

                new PracticaDiagnostico
                {
                    Id = 4,
                    Nombre = "Endoscopías"
                },

                new PracticaDiagnostico
                {
                    Id = 5,
                    Nombre = "Laboratorio de Análisis Clínicos"
                },

                new PracticaDiagnostico
                {
                    Id = 6,
                    Nombre = "Laboratorio de Anatomía Patológica"
                },

                new PracticaDiagnostico
                {
                    Id = 7,
                    Nombre = "Laboratorio de Hematología"
                },

                new PracticaDiagnostico
                {
                    Id = 8,
                    Nombre = "Radiografías"
                },

                new PracticaDiagnostico
                {
                    Id = 9,
                    Nombre = "Tomografías"
                });

            modelBuilder.Entity<ColectivoCentroSalud>().HasData(
                new ColectivoCentroSalud
                {
                    ColectivoId = 1,
                    CentroSaludId = 1,
                });

            modelBuilder.Entity<EspecialidadCentroSalud>().HasData(
                new EspecialidadCentroSalud
                {
                    EspecialidadId = 1,
                    CentroSaludId = 1,
                });

            modelBuilder.Entity<PracticaDiagnosticoCentroSalud>().HasData(
                new PracticaDiagnosticoCentroSalud
                {
                    PracticaDiagnosticoId = 1,
                    CentroSaludId = 1,
                });
        }
    }
}
