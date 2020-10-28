using ProyectoFinal.DTO;
using ProyectoFinal.IServicios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Servicios
{
    public class ServicioEspecialidades : IServicioEspecialidades
    {
        public Task<IEnumerable<CentroSaludDTO>> GetCentrosSaludPorEspecialidadId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<string>> GetEspecialidades()
        {
            throw new System.NotImplementedException();
        }

        public Task<EspecialidadDTO> GetEspecialidadPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
