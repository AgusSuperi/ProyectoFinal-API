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
                    Nombre = "9 de Noviembre",
                    Direccion = "Leopoldo Marechal 1712",
                    Telefono = 4822622,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                    Latitud = -38.717370,
                    Longitud = -62.227370,
                },

                new CentroSalud
                {
                    Id = 2,
                    Nombre = "12 de Octubre",
                    Direccion = "Humboldt 3758",
                    Telefono = 4811397,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.739650,
                    Longitud = -62.212720,
                },

                new CentroSalud
                {
                    Id = 3,
                    Nombre = "A. Menghini",
                    Direccion = "25 de Mayo 396",
                    Telefono = 4840157,
                    HorarioAtencion = "Las 24 hs",
                    RestriccionEdad = "",
                    Latitud = -38.729410,
                    Longitud = -62.262650,
                },

                new CentroSalud
                {
                    Id = 4,
                    Nombre = "Aldea Romana",
                    Direccion = "Los Adobes 424",
                    Telefono = 4862444,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.682990,
                    Longitud = -62.215170,
                },

                new CentroSalud
                {
                    Id = 5,
                    Nombre = "Anchorena",
                    Direccion = "3 de Febrero 1658",
                    Telefono = 4815400,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.724510,
                    Longitud = -62.237690,
                },

                new CentroSalud
                {
                    Id = 6,
                    Nombre = "Avellaneda",
                    Direccion = "Nicaragua 2953",
                    Telefono = 4888350,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.690530,
                    Longitud = -62.293440,
                },

                new CentroSalud
                {
                    Id = 7,
                    Nombre = "Barrio Latino",
                    Direccion = "Lugones 46",
                    Telefono = 4889859,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.690690,
                    Longitud = -62.304180,
                },

                new CentroSalud
                {
                    Id = 8,
                    Nombre = "Barrio Obrero",
                    Direccion = "Chiclana 1974",
                    Telefono = 4821674,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.74719,
                    Longitud = -62.229520,
                },

                new CentroSalud
                {
                    Id = 9,
                    Nombre = "Bella Vista",
                    Direccion = "Charcas 906",
                    Telefono = 4565569,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.715160,
                    Longitud = -62.249240,
                },                

                new CentroSalud
                {
                    Id = 10,
                    Nombre = "Cabildo",
                    Direccion = "Alberti 215",
                    Telefono = 4918250,
                    HorarioAtencion = "Las 24 hs",
                    RestriccionEdad = "",
                    Latitud = -38.700320,
                    Longitud = -62.284280,
                },               

                new CentroSalud
                {
                    Id = 11,
                    Nombre = "CIC Spurr",
                    Direccion = "Esmeralda 1450",
                    Telefono = 4511862,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                    Latitud = -38.748260,
                    Longitud = -62.245560,
                },

                new CentroSalud
                {
                    Id = 12,
                    Nombre = "Colón",
                    Direccion = "O’Higgins 1637",
                    Telefono = 4554524,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.734250,
                    Longitud = -62.283950,
                },

                new CentroSalud
                {
                    Id = 13,
                    Nombre = "Don Bosco",
                    Direccion = "D`Orbigny 2578",
                    Telefono = 4814880,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.729070,
                    Longitud = -62.223500,
                },

                new CentroSalud
                {
                    Id = 14,
                    Nombre = "Enrique Julio",
                    Direccion = "Avda. Arias 1730",
                    Telefono = 4556898,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                    Latitud = -38.750830,
                    Longitud = -62.268890,
                },

                new CentroSalud
                {
                    Id = 15,
                    Nombre = "Estomba",
                    Direccion = "Viamonte 2853",
                    Telefono = 4889026,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                    Latitud = -38.699940,
                    Longitud = -62.301450,
                },

                new CentroSalud
                {
                    Id = 16,
                    Nombre = "Grünbein",
                    Direccion = "La Rioja 5700",
                    Telefono = 4810938,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                    Latitud = -38.752610,
                    Longitud = -62.176260,
                },

                new CentroSalud
                {
                    Id = 17,
                    Nombre = "Kilómetro 5",
                    Direccion = "Maldonado 671",
                    Telefono = 4565567,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.710300,
                    Longitud = -62.293860,
                },

                new CentroSalud
                {
                    Id = 18,
                    Nombre = "La Falda - Vacunatorio",
                    Direccion = "Humboldt 56",
                    Telefono = 4554626,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.708160,
                    Longitud = -62.253020,
                },

                new CentroSalud
                {
                    Id = 19,
                    Nombre = "Laureano Muñiz - Vacunatorio",
                    Direccion = "Gurruchaga 40",
                    Telefono = 4847220,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.705910,
                    Longitud = -62.413710,
                },

                new CentroSalud
                {
                    Id = 20,
                    Nombre = "Leandro Piñeiro",
                    Direccion = "Adrián Veres y Martin Gil",
                    Telefono = 4546309,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                    Latitud = -38.719300,
                    Longitud = -62.315090,
                },

                new CentroSalud
                {
                    Id = 21,
                    Nombre = "Leonor Capelli",
                    Direccion = "Lautaro y Paul Harris",
                    Telefono = 4573132,
                    HorarioAtencion = "Las 24 hs",
                    RestriccionEdad = "",
                    Latitud = -38.775540,
                    Longitud = -62.271220,
                },

                new CentroSalud
                {
                    Id = 22,
                    Nombre = "Loma Paraguaya",
                    Direccion = "Felix Frías 850",
                    Telefono = 4565592,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.747890,
                    Longitud = -62.285900,
                },

                new CentroSalud
                {
                    Id = 23,
                    Nombre = "Lujan",
                    Direccion = "Enrique Julio 806",
                    Telefono = 4888351,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.708060,
                    Longitud = -62.299720,
                },

                new CentroSalud
                {
                    Id = 24,
                    Nombre = "Maldonado",
                    Direccion = "Richieri 2535",
                    Telefono = 4550257,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.717340,
                    Longitud = -62.319480,
                },

                new CentroSalud
                {
                    Id = 25,
                    Nombre = "Mariano Moreno",
                    Direccion = "Mendoza 1250",
                    Telefono = 4552088,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.720500,
                    Longitud = -62.293310,
                },

                new CentroSalud
                {
                    Id = 26,
                    Nombre = "Miramar",
                    Direccion = "Laudelino Cruz 1892",
                    Telefono = 4552417,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                    Latitud = -38.7086846,
                    Longitud = -62.2372357,
                },

                new CentroSalud
                {
                    Id = 27,
                    Nombre = "Naposta",
                    Direccion = "19 de Mayo 769",
                    Telefono = 4565562,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.708270,
                    Longitud = -62.260520,
                },

                new CentroSalud
                {
                    Id = 28,
                    Nombre = "Noroeste",
                    Direccion = "Líbano 589",
                    Telefono = 4556878,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                    Latitud = -38.726960,
                    Longitud = -62.289850,
                },

                new CentroSalud
                {
                    Id = 29,
                    Nombre = "Norte",
                    Direccion = "Vieytes 1616",
                    Telefono = 4888267,
                    HorarioAtencion = "08:00 a 18:00",
                    RestriccionEdad = "",
                    Latitud = -38.717370,
                    Longitud = -62.227370,
                },

                new CentroSalud
                {
                    Id = 30,
                    Nombre = "Nueva Belgrano",
                    Direccion = "Witcomb 3900",
                    Telefono = 4888268,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.676280,
                    Longitud = -62.296110,
                },

                new CentroSalud
                {
                    Id = 31,
                    Nombre = "Pampa Central",
                    Direccion = "Jujuy 946",
                    Telefono = 4556939,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.725650,
                    Longitud = -62.296170,
                },

                new CentroSalud
                {
                    Id = 32,
                    Nombre = "Patagonia",
                    Direccion = "Lauquen 356",
                    Telefono = 4862440,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.697720,
                    Longitud = -62.211730,
                },

                new CentroSalud
                {
                    Id = 33,
                    Nombre = "Pedro Pico",
                    Direccion = "Misiones 754",
                    Telefono = 4565559,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.735270,
                    Longitud = -62.263350,
                },

                new CentroSalud
                {
                    Id = 34,
                    Nombre = "Rivadavia",
                    Direccion = "Estados Unidos 503",
                    Telefono = 4556927,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.738200,
                    Longitud = -62.253800,
                },

                new CentroSalud
                {
                    Id = 35,
                    Nombre = "Rosario Sur",
                    Direccion = "Venezuela 296",
                    Telefono = 4821625,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.739150,
                    Longitud = -62.245720,
                },

                new CentroSalud
                {
                    Id = 36,
                    Nombre = "Saladero",
                    Direccion = "Reconquista 2045",
                    Telefono = 4570427,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.770604,
                    Longitud = -62.245450,
                },

                new CentroSalud
                {
                    Id = 37,
                    Nombre = "San Cayetano",
                    Direccion = "Alberti 477",
                    Telefono = 4888366,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.696960,
                    Longitud = -62.280160,
                },

                new CentroSalud
                {
                    Id = 38,
                    Nombre = "San Dionisio",
                    Direccion = "Pacifico 154",
                    Telefono = 4550211,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.736340,
                    Longitud = -62.292070,
                },

                new CentroSalud
                {
                    Id = 39,
                    Nombre = "San Jose Obrero",
                    Direccion = "Reconquista 3084",
                    Telefono = 4570474,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.779440,
                    Longitud = -62.256220,
                },

                new CentroSalud
                {
                    Id = 40,
                    Nombre = "Sanchez Elia",
                    Direccion = "Bermudez 1580",
                    Telefono = 4815419,
                    HorarioAtencion = "extensión CS 9 de noviembre",
                    RestriccionEdad = "",
                    Latitud = -38.720200,
                    Longitud = -62.235520,
                },

                new CentroSalud
                {
                    Id = 41,
                    Nombre = "Tiro Federal",
                    Direccion = "Pellegrini 638",
                    Telefono = 4554598,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.721600,
                    Longitud = -62.250210,
                },

                new CentroSalud
                {
                    Id = 42,
                    Nombre = "Universitario",
                    Direccion = "Uruguay 463",
                    Telefono = 4565581,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.701560,
                    Longitud = -62.274770,
                },               

                new CentroSalud
                {
                    Id = 43,
                    Nombre = "Villa Bordeu",
                    Direccion = "Larrea 5450",
                    Telefono = 4885679,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.714780,
                    Longitud = -62.311370,
                },

                new CentroSalud
                {
                    Id = 44,
                    Nombre = "Villa Amaducci",
                    Direccion = "Fournier 1809",
                    Telefono = 4810155,
                    HorarioAtencion = "extensión CS 9 de noviembre",
                    RestriccionEdad = "",
                    Latitud = -38.723370,
                    Longitud = -62.226770,
                },

                new CentroSalud
                {
                    Id = 45,
                    Nombre = "Villa Delfina",
                    Direccion = "Juana Azurduy 1345",
                    Telefono = 4552271,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.750140,
                    Longitud = -62.275770,
                },

                new CentroSalud
                {
                    Id = 46,
                    Nombre = "Villa Esperanza",
                    Direccion = "Berutti 2980",
                    Telefono = 4813677,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.729420,
                    Longitud = -62.260500,
                },

                new CentroSalud
                {
                    Id = 47,
                    Nombre = "Villa Floresta",
                    Direccion = "José Ingenieros 2235",
                    Telefono = 4888365,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.691530,
                    Longitud = -62.263590,
                },

                new CentroSalud
                {
                    Id = 48,
                    Nombre = "Villa Gloria",
                    Direccion = "Rojas 4898",
                    Telefono = 4817321,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.749820,
                    Longitud = -62.191670,
                },

                new CentroSalud
                {
                    Id = 49,
                    Nombre = "Villa H. Green",
                    Direccion = "Salinas Chicas 4150",
                    Telefono = 4862447,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.714480,
                    Longitud = -62.189450,
                },

                new CentroSalud
                {
                    Id = 50,
                    Nombre = "Villa Mitre",
                    Direccion = "Washington 232",
                    Telefono = 4817261,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.730410,
                    Longitud = -62.246530,
                },                

                new CentroSalud
                {
                    Id = 51,
                    Nombre = "Villa Muñiz",
                    Direccion = "Pilcaniyen 259",
                    Telefono = 4811080,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.746100,
                    Longitud = -62.225990,
                },

                new CentroSalud
                {
                    Id = 52,
                    Nombre = "Villa Nocito",
                    Direccion = "Pacifico 1925",
                    Telefono = 4550240,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.721700,
                    Longitud = -62.312210,
                },

                new CentroSalud
                {
                    Id = 53,
                    Nombre = "Villa Ressia",
                    Direccion = "Misiones 1570",
                    Telefono = 4565591,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.742670,
                    Longitud = -62.272080,
                },

                new CentroSalud
                {
                    Id = 54,
                    Nombre = "Villa Rosas",
                    Direccion = "Libertad 1955",
                    Telefono = 4552418,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.755940,
                    Longitud = -62.261400,
                },

                new CentroSalud
                {
                    Id = 55,
                    Nombre = "Villa Serra",
                    Direccion = "Tarija 1350",
                    Telefono = 4560139,
                    HorarioAtencion = "08:00 a 14:00",
                    RestriccionEdad = "",
                    Latitud = -38.757880,
                    Longitud = -62.246610,
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
