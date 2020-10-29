using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.DTO;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.IServicios
{
    public interface IServicioCentrosSalud
    {
        public Task<IEnumerable<CentroSalud>> GetCentrosSalud();

        public Task<CentroSalud> GetCentroSaludPorId(int id);

        public Task<IEnumerable<Especialidad>> GetEspecialidadesPorCentroSaludId(int id);

        public Task<IEnumerable<CentroSalud>> GetCentrosSaludPorFiltro(FiltroDTO filtro);
    }
}
