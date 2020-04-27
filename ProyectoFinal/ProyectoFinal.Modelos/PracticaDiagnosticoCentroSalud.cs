using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Modelos
{
    public class PracticasDiagnosticoCentroSalud
    {
        public int CentroSaludId { get; set; }

        public int PracticaDiagnosticoId { get; set; }

        public CentroSalud CentroSalud { get; set; }

        public PracticaDiagnostico PracticaDiagnostico { get; set; }
    }
}
