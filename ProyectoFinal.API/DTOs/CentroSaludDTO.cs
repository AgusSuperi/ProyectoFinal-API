using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.API.DTOs
{
    public class CentroSaludDTO
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Nombre { get; set; }

        [Required]
        public int Telefono { get; set; }

        [Required, StringLength(80)]
        public string Direccion { get; set; }

        [Required, StringLength(80)]
        public string HorarioAtencion { get; set; }

        [Required, StringLength(200)]
        public string RestriccionEdad { get; set; }

        public ICollection<EspecialidadDTO> Especialidades { get; set; } = new List<EspecialidadDTO>();

        public ICollection<ColectivoDTO> Colectivos { get; set; } = new List<ColectivoDTO>();

        public ICollection<PracticaDiagnosticoDTO> PracticasDiagnostico { get; set; } = new List<PracticaDiagnosticoDTO>();
    }
}
