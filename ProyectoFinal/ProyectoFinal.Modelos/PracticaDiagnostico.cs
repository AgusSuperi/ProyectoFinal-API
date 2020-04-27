using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProyectoFinal.Modelos
{
    public class PracticaDiagnostico
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Nombre { get; set; }

        public virtual IEnumerable<PracticaDiagnosticoCentroSalud> PracticasDiagnosticoCentroSalud { get; set; } = new List<PracticaDiagnosticoCentroSalud>();
    }
}
