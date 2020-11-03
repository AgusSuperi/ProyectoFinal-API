using ProyectoFinal.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.IServicios
{
    public interface IServicioEspecialidades
    {
        public Task<IEnumerable<string>> GetEspecialidades();

        public Task<Especialidad> GetEspecialidadPorId(int id);

        public Task<IEnumerable<CentroSalud>> GetCentrosSaludPorEspecialidadId(int id);
    }
}
