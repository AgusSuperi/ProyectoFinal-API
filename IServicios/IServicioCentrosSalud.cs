using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.DTO;

namespace ProyectoFinal.IServicios
{
    public interface IServicioCentrosSalud
    {
        public Task<IEnumerable<CentroSaludDTO>> GetCentrosSaludAsync();

        public Task<CentroSaludDTO> GetCentroSaludPorIdAsync(int id);

        public Task<IEnumerable<EspecialidadDTO>> GetEspecialidadesPorCentroSaludIdAsync(int id);

        public Task<IEnumerable<CentroSaludDTO>> GetCentrosSaludPorFiltro(FiltroDTO filtro);
    }
}
