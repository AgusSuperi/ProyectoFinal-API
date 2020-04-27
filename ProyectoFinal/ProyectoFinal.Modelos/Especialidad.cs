using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProyectoFinal.Modelos
{
    public class Especialidad
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Nombre { get; set; }

        public virtual IEnumerable<EspecialidadCentroSalud> EspecialidadesCentroSalud { get; set; } = new List<EspecialidadCentroSalud>();
    }
}
