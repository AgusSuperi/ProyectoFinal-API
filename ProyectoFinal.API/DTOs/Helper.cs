using ProyectoFinal.Modelos;
using System.Collections.Generic;

namespace ProyectoFinal.API.DTOs
{
    public static class Helper
    {
        public static CentroSaludDTO CentroSaludToDTO (CentroSalud centroSalud)
        {
            return new CentroSaludDTO
            {
                Id = centroSalud.Id,
                Nombre = centroSalud.Nombre,
                Telefono = centroSalud.Telefono,
                Direccion = centroSalud.Direccion,
                HorarioAtencion = centroSalud.HorarioAtencion,
                Latitud = centroSalud.Latitud,
                Longitud = centroSalud.Longitud,
                Barrio = centroSalud.Barrio,
            };
        }

        public static EspecialidadDTO EspecialidadToDTO (Especialidad especialidad)
        {
            return new EspecialidadDTO
            {
                Id = especialidad.Id,
                Nombre = especialidad.Nombre
            };
        }

        public static HospitalPublicoDTO HospitalPublicoToDTO(HospitalPublico hospitalPublico)
        {
            return new HospitalPublicoDTO
            {
                Id = hospitalPublico.Id,
                Nombre = hospitalPublico.Nombre,
                Telefono= hospitalPublico.Telefono,
                Direccion= hospitalPublico.Direccion,
                URLPagina= hospitalPublico.URLPagina,
                Restriccion= hospitalPublico.Restriccion
            };
        }

    }
}
