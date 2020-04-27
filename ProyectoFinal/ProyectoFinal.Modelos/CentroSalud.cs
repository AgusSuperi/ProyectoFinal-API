using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

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

        [Required, StringLength(200)]
        public string RestriccionEdad { get; set; }

        public virtual IEnumerable<EspecialidadCentroSalud> EspecialidadesCentroSalud { get; set; } = new List<EspecialidadCentroSalud>();

        public virtual IEnumerable<PracticaDiagnosticoCentroSalud> PracticasDiagnosticoCentroSalud { get; set; } = new List<PracticaDiagnosticoCentroSalud>();

        public virtual IEnumerable<ColectivoCentroSalud> ColectivosCentroSalud { get; set; } = new List<ColectivoCentroSalud>();

        //ver lo de las imagenes
        //public string Turno { get; set; }
    }
}
