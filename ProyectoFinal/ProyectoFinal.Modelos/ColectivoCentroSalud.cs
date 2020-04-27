using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Modelos
{
    public class ColectivoCentroSalud
    {
        public int CentroSaludId { get; set; }

        public int ColectivoId { get; set; }

        public CentroSalud CentroSalud { get; set; }

        public Colectivo Colectivo { get; set; }
    }
}
