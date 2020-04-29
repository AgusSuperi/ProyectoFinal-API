
namespace ProyectoFinal.Modelos
{
    public class PracticaDiagnosticoCentroSalud
    {
        public int CentroSaludId { get; set; }

        public int PracticaDiagnosticoId { get; set; }

        public CentroSalud CentroSalud { get; set; }

        public PracticaDiagnostico PracticaDiagnostico { get; set; }
    }
}
