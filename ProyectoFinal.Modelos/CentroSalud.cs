using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelos
{
    public class CentroSalud
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

        [Required]
        public double Latitud { get; set; }

        [Required]
        public double Longitud { get; set; }

        [Required, StringLength(80)]
        public string Barrio { get; set; }

        public virtual IEnumerable<EspecialidadCentroSalud> EspecialidadesCentroSalud { get; set; } = new List<EspecialidadCentroSalud>();
    }
}
