using ProyectoFinal.DTO;
using ProyectoFinal.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.IServicios
{
    public interface IServicioFiltros
    {
        public Task<IEnumerable<CentroSalud>> GetCentrosSaludPorFiltro(FiltroDTO filtro);
    }
}
