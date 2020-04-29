using ProyectoFinal.Modelos;

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
                RestriccionEdad = centroSalud.RestriccionEdad
            };
        }

        public static ColectivoDTO ColectivoToDTO (Colectivo colectivo)
        {
            return new ColectivoDTO
            {
                Id = colectivo.Id,
                Linea=colectivo.Linea
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

        public static PracticaDiagnosticoDTO PracticaDiagnosticoToDTO(PracticaDiagnostico practicaDiagnostico)
        {
            return new PracticaDiagnosticoDTO
            {
                Id = practicaDiagnostico.Id,
                Nombre = practicaDiagnostico.Nombre
            };
        }
    }
}
