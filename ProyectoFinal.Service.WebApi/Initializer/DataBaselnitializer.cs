using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinal.Service.WebApi.Initializer
{
    public static class DataBaselnitializer
    {
        public static void Initialize(ProyectoFinalContext context)
        {
            context.Database.Migrate();

            if (!context.MedicalCenters.Any())
            {
                context.MedicalCenters.AddRange(InitializeMedicalCenters());
                context.SaveChanges();
            }                       
        }

        private static List<MedicalCenter> InitializeMedicalCenters()
        {
            //Specialities 
            var communityActivity = new Speciality("Actividad Comunitaria");
            var allergy = new Speciality("Alergia");
            var pathologicalAnatomy = new Speciality("Anatomia Patológica");
            var medicalClinic = new Speciality("Clínica Médica");
            var diagnosticImaging = new Speciality("Diagnóstico por imagen");
            var nursing = new Speciality("Enfermería");
            var generalFamily = new Speciality("Familia / General");
            var speechTherapy = new Speciality("Fonoaudiología");
            var gynecologyObstetrics = new Speciality("Ginecología / Obstetricia");
            var medicalGuard = new Speciality("Guardia Médica");
            var nutrition = new Speciality("Nutrición");
            var odontology = new Speciality("Odontología");
            var ophthalmology = new Speciality("Oftalmología");
            var pediatrics = new Speciality("Pediatría");
            var healthPromoter = new Speciality("Promotor de salud");
            var psychology = new Speciality("Psicología");
            var psychopedagogy = new Speciality("Psicopedagogía");
            var socialWork = new Speciality("Trabajo social");
            var pharmacyTechnician = new Speciality("Técnico en farmacia");

            //Medical Centers
            var medicalCenters = new List<MedicalCenter> 
            {
                new MedicalCenter
                {
                    Name = "9 de Noviembre",
                    Address = "Leopoldo Marechal 1712, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4822622",
                    OpeningHours = "08:00 a 18:00",
                    Latitude = -38.717370,
                    Longitude = -62.227370,
                    Neighborhood = "Altos Sánchez",
                    ImageURL = "9denoviembre.png",
                    Specialities = new List<Speciality>()
                    {
                        communityActivity,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        odontology,
                        pediatrics,
                        healthPromoter,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "12 de Octubre",
                    Address = "Humboldt 3758, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4811397",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.739650,
                    Longitude = -62.212720,
                    Neighborhood = "12 de Octubre",
                    ImageURL = "12deoctubre.png",
                    Specialities = new List<Speciality>()
                    {
                        communityActivity,
                        generalFamily,
                        gynecologyObstetrics,
                        nutrition,
                        psychology,
                    },
                },

                new MedicalCenter
                {
                    Name = "A. Menghini",
                    Address = "25 de Mayo 396, Gral Daniel Cerri, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4840157",
                    OpeningHours = "Las 24 hs",
                    Latitude = -38.718364,
                    Longitude = -62.391708,
                    Neighborhood = "General Daniel Cerri",
                    ImageURL = "amenghini.png",
                    Specialities = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        medicalGuard,
                        nutrition,
                        odontology,
                        pediatrics,
                        healthPromoter,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Aldea Romana",
                    Address = "Los Adobes 424, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4862444",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.682990,
                    Longitude = -62.215170,
                    Neighborhood = "Aldea Romana",
                    ImageURL = "aldearomana.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        odontology,
                        pediatrics,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Anchorena",
                    Address = "3 de Febrero 1658, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4815400",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.724510,
                    Longitude = -62.237690,
                    Neighborhood = "Anchorena",
                    ImageURL = "anchorena.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        speechTherapy,
                        gynecologyObstetrics,
                        odontology,
                        pediatrics,
                        healthPromoter,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Avellaneda",
                    Address = "Nicaragua 2953, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4888350",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.690530,
                    Longitude = -62.293440,
                    Neighborhood = "Avellaneda",
                    ImageURL = "avellaneda.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        medicalGuard,
                        odontology,
                        pediatrics,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Barrio Latino",
                    Address = "Lugones 46, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4889859",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.690690,
                    Longitude = -62.304180,
                    Neighborhood = "Barrio Latino",
                    ImageURL = "barriolatino.png",
                    Specialities  = new List<Speciality>()
                    {
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        pediatrics,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Barrio Obrero",
                    Address = "Chiclana 1974, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4821674",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.74719,
                    Longitude = -62.229520,
                    Neighborhood = "Barrio Obrero",
                    ImageURL = "barrioobrero.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        pediatrics,
                        psychology,
                    },
                },

                new MedicalCenter
                {
                    Name = "Bella Vista",
                    Address = "Charcas 906, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4565569",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.715160,
                    Longitude = -62.249240,
                    Neighborhood = "Bella Vista",
                    ImageURL = "bellavista.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        gynecologyObstetrics,
                        odontology,
                        pediatrics,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Cabildo",
                    Address = "Alberti 215, Cabildo, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4918250",
                    OpeningHours = "Las 24 hs",
                    Latitude = -38.489273,
                    Longitude = -61.896659,
                    Neighborhood = "Cabildo",
                    ImageURL = "cabildo.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        medicalGuard,
                        odontology,
                        pediatrics,
                        psychology,
                    },
                },

                new MedicalCenter
                {
                    Name = "CIC Spurr",
                    Address = "Esmeralda 1450, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4511862",
                    OpeningHours = "08:00 a 18:00",
                    Latitude = -38.748260,
                    Longitude = -62.245560,
                    Neighborhood = "Villa Moresino",
                    ImageURL = "cicspurr.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        medicalGuard,
                        odontology,
                        pediatrics,
                        psychology,
                        socialWork,
                    },

                },

                new MedicalCenter
                {
                    Name = "Colón",
                    Address = "O’Higgins 1637, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4554524",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.734250,
                    Longitude = -62.283950,
                    Neighborhood = "Colón",
                    ImageURL = "colon.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        allergy,
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        odontology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Don Bosco",
                    Address = "D`Orbigny 2578, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4814880",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.729070,
                    Longitude = -62.223500,
                    Neighborhood = "Villa Don Bosco",
                    ImageURL = "donbosco.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Enrique Julio",
                    Address = "Avda. General Arias 1730, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4556898",
                    OpeningHours = "08:00 a 18:00",
                    Latitude = -38.750830,
                    Longitude = -62.268890,
                    Neighborhood = "Enrique Julio",
                    ImageURL = "enriquejulio.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        nutrition,
                        odontology,
                        pediatrics,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Grünbein",
                    Address = "La Rioja 5700, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4810938",
                    OpeningHours = "08:00 a 18:00",
                    Latitude = -38.752610,
                    Longitude = -62.176260,
                    Neighborhood = "Grünbein",
                    ImageURL = "grunbein.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        odontology,
                        pediatrics,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Kilómetro 5",
                    Address = "Maldonado 671, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4565567",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.710300,
                    Longitude = -62.293860,
                    Neighborhood = "Kilómetro 5",
                    ImageURL = "kilometro5.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        psychology,
                        psychopedagogy,
                    },
                },

                new MedicalCenter
                {
                    Name = "La Falda - Vacunatorio",
                    Address = "Humboldt 56, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4554626",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.708160,
                    Longitude = -62.253020,
                    Neighborhood = "La Falda",
                    ImageURL = "lafalda.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Laureano Muñiz - Vacunatorio",
                    Address = "Francisco de Gurruchaga 40, Gral Daniel Cerri, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4847220",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.705910,
                    Longitude = -62.413710,
                    Neighborhood = "General Daniel Cerri",
                    ImageURL = "laureanomuñiz.png",
                    Specialities = new List<Speciality>()
                },

                new MedicalCenter
                {
                    Name = "Leandro Piñeiro",
                    Address = "Adrián Veres 2050, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4546309",
                    OpeningHours = "08:00 a 18:00",
                    Latitude = -38.719300,
                    Longitude = -62.315090,
                    Neighborhood = "Vista Alegre",
                    ImageURL = "leandropiñeiro.png",
                    Specialities  = new List<Speciality>()
                    {
                        pathologicalAnatomy,
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        nutrition,
                        odontology,
                        pediatrics,
                        psychology,
                        socialWork,
                        pharmacyTechnician,
                    },
                },

                new MedicalCenter
                {
                    Name = "Leonor Capelli",
                    Address = "Harris 3599, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4573132",
                    OpeningHours = "Las 24 hs",
                    Latitude = -38.775540,
                    Longitude = -62.271220,
                    Neighborhood = "Ingeniero White",
                    ImageURL = "leonorcapelli.png",
                    Specialities  = new List<Speciality>()
                    {
                        allergy,
                        medicalClinic,
                        diagnosticImaging,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        medicalGuard,
                        ophthalmology,
                        pediatrics,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Loma Paraguaya",
                    Address = "Félix Frías 850, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4565592",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.747890,
                    Longitude = -62.285900,
                    Neighborhood = "Loma Paraguaya",
                    ImageURL = "lomaparaguaya.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        medicalGuard,
                        healthPromoter,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Lujan",
                    Address = "Enrique Julio 806, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4888351",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.708060,
                    Longitude = -62.299720,
                    Neighborhood = "Lujan",
                    ImageURL = "lujan.png",
                    Specialities  = new List<Speciality>()
                    {
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        pediatrics,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Maldonado",
                    Address = "Gral. Pablo Richieri 2535, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4550257",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.717340,
                    Longitude = -62.319480,
                    Neighborhood = "Coronel Maldonado",
                    ImageURL = "maldonado.png",
                    Specialities  = new List<Speciality>()
                    {
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        psychology,
                    },
                },

                new MedicalCenter
                {
                    Name = "Mariano Moreno",
                    Address = "Mendoza 1250, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4552088",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.720500,
                    Longitude = -62.293310,
                    Neighborhood = "Mariano Moreno",
                    ImageURL = "marianomoreno.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        odontology,
                        pediatrics,
                        psychology,
                    },
                },

                new MedicalCenter
                {
                    Name = "Miramar",
                    Address = "Laudelino Cruz 1892, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4552417",
                    OpeningHours = "08:00 a 18:00",
                    Latitude = -38.7086846,
                    Longitude = -62.2372357,
                    Neighborhood = "Villa Miramar",
                    ImageURL = "miramar.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        gynecologyObstetrics,
                        nutrition,
                        odontology,
                        pediatrics,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Naposta",
                    Address = "19 de Mayo 769, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4565562",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.708270,
                    Longitude = -62.260520,
                    Neighborhood = "Naposta",
                    ImageURL = "naposta.png",
                    Specialities  = new List<Speciality>()
                    {
                        nursing,
                    },
                },

                new MedicalCenter
                {
                    Name = "Noroeste",
                    Address = "Líbano 589, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4556878",
                    OpeningHours = "08:00 a 18:00",
                    Latitude = -38.726960,
                    Longitude = -62.289850,
                    Neighborhood = "Noroeste",
                    ImageURL = "noroeste.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        odontology,
                        pediatrics,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Norte",
                    Address = "Vieytes 2616, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4888267",
                    OpeningHours = "08:00 a 18:00",
                    Latitude = -38.698551,
                    Longitude = -62.297645,
                    Neighborhood = "Los Almendros",
                    ImageURL = "norte.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        medicalGuard,
                        odontology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Nueva Belgrano",
                    Address = "Witcomb 3900, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4888268",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.676280,
                    Longitude = -62.296110,
                    Neighborhood = "Nueva Belgrano",
                    ImageURL = "nuevabelgrano.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        pediatrics,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Pampa Central",
                    Address = "Jujuy 946, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4556939",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.725650,
                    Longitude = -62.296170,
                    Neighborhood = "Pampa Central",
                    ImageURL = "pampacentral.png",
                    Specialities  = new List<Speciality>()
                    {
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        healthPromoter,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Patagonia",
                    Address = "Lauquen 356, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4862440",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.697720,
                    Longitude = -62.211730,
                    Neighborhood = "Patagonia",
                    ImageURL = "patagonia.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        medicalGuard,
                        pediatrics,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Pedro Pico",
                    Address = "Misiones 754, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4565559",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.735270,
                    Longitude = -62.263350,
                    Neighborhood = "Pedro Pico",
                    ImageURL = "pedropico.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        gynecologyObstetrics,
                        nutrition,
                        pediatrics,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Rivadavia",
                    Address = "Estados Unidos 503, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4556927",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.738200,
                    Longitude = -62.253800,
                    Neighborhood = "Rivadavia",
                    ImageURL = "rivadavia.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        pediatrics,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Rosario Sur",
                    Address = "Venezuela 296, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4821625",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.739150,
                    Longitude = -62.245720,
                    Neighborhood = "Rosario Sur",
                    ImageURL = "rosariosur.png",
                    Specialities  = new List<Speciality>()
                    {
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        odontology,
                        pediatrics,
                        healthPromoter,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Saladero",
                    Address = "Reconquista 2045, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4570427",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.770061,
                    Longitude = -62.244759,
                    Neighborhood = "Saladero",
                    ImageURL = "saladero.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        medicalGuard,
                    },
                },

                new MedicalCenter
                {
                    Name = "San Cayetano",
                    Address = "Manuel Alberti 477, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4888366",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.696960,
                    Longitude = -62.280160,
                    Neighborhood = "San Cayetano",
                    ImageURL = "sancayetano.png",
                    Specialities  = new List<Speciality>()
                    {
                        nursing,
                        gynecologyObstetrics,
                    },
                },

                new MedicalCenter
                {
                    Name = "San Dionisio",
                    Address = "Pacifico 154, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4550211",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.736340,
                    Longitude = -62.292070,
                    Neighborhood = "Noroeste",
                    ImageURL = "sandionisio.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        nutrition,
                        odontology,
                        pediatrics,
                        healthPromoter,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "San Jose Obrero",
                    Address = "Reconquista 3084, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4570474",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.779440,
                    Longitude = -62.256220,
                    Neighborhood = "Juan B. Justo",
                    ImageURL = "sanjoseobrero.png",
                    Specialities  = new List<Speciality>()
                    {
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        odontology,
                    },
                },

                new MedicalCenter
                {
                    Name = "Sanchez Elia",
                    Address = "Bermudez 1580, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4815419",
                    OpeningHours = "08:00 a 18:00",
                    Latitude = -38.720200,
                    Longitude = -62.235520,
                    Neighborhood = "Sanchez Elia",
                    ImageURL = "sanchezelia.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        nursing,
                        speechTherapy,
                        psychology,
                    },
                },

                new MedicalCenter
                {
                    Name = "Tiro Federal",
                    Address = "Pellegrini 638, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4554598",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.721600,
                    Longitude = -62.250210,
                    Neighborhood = "Tiro Federal",
                    ImageURL = "tirofederal.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        gynecologyObstetrics,
                        pediatrics,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Universitario",
                    Address = "Uruguay 463, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4565581",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.701560,
                    Longitude = -62.274770,
                    Neighborhood = "Universitario",
                    ImageURL = "universitario.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        gynecologyObstetrics,
                        pediatrics,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Bordeu",
                    Address = "Juan Larrea 5450, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4885679",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.688405,
                    Longitude = -62.345480,
                    Neighborhood = "Villa Bordeu",
                    ImageURL = "villabordeu.png",
                    Specialities  = new List<Speciality>()
                    {
                        pathologicalAnatomy,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        medicalGuard,
                        pediatrics,
                        psychology,
                        socialWork,
                        pharmacyTechnician,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Delfina",
                    Address = "Juana Azurduy 1345, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4552271",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.750140,
                    Longitude = -62.275770,
                    Neighborhood = "Villa Delfina",
                    ImageURL = "villadelfina.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        nutrition,
                        odontology,
                        pediatrics,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Esperanza",
                    Address = "Berutti 2980, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4813677",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.746873,
                    Longitude = -62.237961,
                    Neighborhood = "Rosario Sur",
                    ImageURL = "villaesperanza.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        pediatrics,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Floresta",
                    Address = "José Ingenieros 2235, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4888365",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.691530,
                    Longitude = -62.263590,
                    Neighborhood = "Villa Floresta",
                    ImageURL = "villafloresta.png",
                    Specialities  = new List<Speciality>()
                    {
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Gloria",
                    Address = "Ricardo Rojas 4898, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4817321",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.749820,
                    Longitude = -62.191670,
                    Neighborhood = "Villa Cerrito",
                    ImageURL = "villagloria.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        pediatrics,
                        psychology,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Harding Green",
                    Address = "Salinas Chicas 4150, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4862447",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.714480,
                    Longitude = -62.189450,
                    Neighborhood = "Villa Harding Green",
                    ImageURL = "villahardinggreen.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        nutrition,
                        odontology,
                        pediatrics,
                        psychology,
                        psychopedagogy,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Mitre",
                    Address = "Washington 232, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4817261",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.730410,
                    Longitude = -62.246530,
                    Neighborhood = "Villa Mitre",
                    ImageURL = "villamitre.png",
                    Specialities  = new List<Speciality>()
                    {
                        communityActivity,
                        nursing,
                        psychology,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Muñiz",
                    Address = "Pilcaniyen 259, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4811080",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.746100,
                    Longitude = -62.225990,
                    Neighborhood = "Villa Muñiz",
                    ImageURL = "villamuñiz.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        pediatrics,
                        psychology,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Nocito",
                    Address = "Pacifico 1925, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4550240",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.721700,
                    Longitude = -62.312210,
                    Neighborhood = "Villa Nocito",
                    ImageURL = "villanocito.png",
                    Specialities  = new List<Speciality>()
                    {
                        nursing,
                        generalFamily,
                        pediatrics,
                        healthPromoter,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Ressia",
                    Address = "Misiones 1570, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4565591",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.742670,
                    Longitude = -62.272080,
                    Neighborhood = "Villa Ressia",
                    ImageURL = "villaressia.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        speechTherapy,
                        gynecologyObstetrics,
                        medicalGuard,
                        odontology,
                        pediatrics,
                        psychology,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Rosas",
                    Address = "Libertad 1955, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4552418",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.755940,
                    Longitude = -62.261400,
                    Neighborhood = "Villa Rosas",
                    ImageURL = "villarosas.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        odontology,
                        pediatrics,
                        socialWork,
                    },
                },

                new MedicalCenter
                {
                    Name = "Villa Serra",
                    Address = "Tarija 1350, Bahía Blanca, Provincia de Buenos Aires",
                    PhoneNumber = "(291) 4560139",
                    OpeningHours = "08:00 a 14:00",
                    Latitude = -38.757880,
                    Longitude = -62.246610,
                    Neighborhood = "Villa Serra",
                    ImageURL = "villaserra.png",
                    Specialities  = new List<Speciality>()
                    {
                        medicalClinic,
                        nursing,
                        generalFamily,
                        gynecologyObstetrics,
                        medicalGuard,
                        psychology,
                    },
                }
            };

            return medicalCenters;
        }
    }
}