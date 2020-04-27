using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Modelos
{
    public class EspecialidadCentroSalud
    {
        public int CentroSaludId { get; set; }

        public int EspecialidadId { get; set; }

        public CentroSalud CentroSalud { get; set; }

        public Especialidad Especialidad { get; set; }
    }
}
