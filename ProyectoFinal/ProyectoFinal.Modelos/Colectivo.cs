using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProyectoFinal.Modelos
{
    public class Colectivo
    {
        public int Id { get; set; }

        [Required, StringLength(25)]
        public string Linea { get; set; }

        public virtual IEnumerable<ColectivoCentroSalud> ColectivosCentroSalud { get; set; } = new List<ColectivoCentroSalud>();
    }
}
