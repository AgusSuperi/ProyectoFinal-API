using ProyectoFinal.Modelos;

namespace ProyectoFinal.DTO
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
                ImagenURL = centroSalud.ImagenURL,
            };
        }

        public static EspecialidadDTO EspecialidadToDTO (Especialidad especialidad)
        {
            return new EspecialidadDTO
            {
                Id = especialidad.Id,
                Nombre = especialidad.Nombre,
            };
        }
    }
}
