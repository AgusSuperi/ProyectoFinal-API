using ProyectoFinal.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.IServicios
{
    public interface IServicioEspecialidades
    {
        public Task<IEnumerable<string>> GetEspecialidades();

        public Task<EspecialidadDTO> GetEspecialidadPorId(int id);

        public Task<IEnumerable<CentroSaludDTO>> GetCentrosSaludPorEspecialidadId(int id);
    }
}
