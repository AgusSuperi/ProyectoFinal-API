using ProyectoFinal.BD;
using ProyectoFinal.IServicios;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinal.Servicios
{
    public class ServicioBarrios : IServicioBarrios
    {
        private readonly CentrosSaludContext centrosSaludContext;

        public ServicioBarrios(CentrosSaludContext  centrosSaludContext)
        {
            this.centrosSaludContext = centrosSaludContext;
        }

        public IEnumerable<string> GetBarrios()
        {
            HashSet<string> barrios = new HashSet<string>();

            foreach (var centroSalud in centrosSaludContext.CentrosSalud)
            {
                barrios.Add(centroSalud.Barrio);
            }

            var barriosOrdenados = barrios.ToList();
            barriosOrdenados.Sort();

            return barriosOrdenados;
        }
    }
}
