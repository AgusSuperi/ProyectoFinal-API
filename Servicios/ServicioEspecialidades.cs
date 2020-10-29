using Microsoft.EntityFrameworkCore;
using ProyectoFinal.BD;
using ProyectoFinal.DTO;
using ProyectoFinal.IServicios;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Servicios
{
    public class ServicioEspecialidades : IServicioEspecialidades
    {
        private readonly CentrosSaludContext centroSaludContext;

        public ServicioEspecialidades(CentrosSaludContext centroSaludContext)
        {
            this.centroSaludContext = centroSaludContext;
        }

        public async Task<IEnumerable<string>> GetEspecialidades()
        {
            return await centroSaludContext.Especialidades.Select(e => e.Nombre).ToListAsync();
        }

        public async Task<EspecialidadDTO> GetEspecialidadPorId(int id)
        {
            var especialidad = await centroSaludContext.Especialidades.FindAsync(id);

            if (especialidad == null)
            {
                return null;
            }

            return Helper.EspecialidadToDTO(especialidad);
        }

        public async Task<IEnumerable<CentroSaludDTO>> GetCentrosSaludPorEspecialidadId(int id)
        {
            var especialidad = await centroSaludContext.Especialidades.FindAsync(id);

            if (especialidad == null)
            {
                return null;
            }

            var centrossalud = await centroSaludContext.EspecialidadesCentrosSalud.
                Where(ecs => ecs.EspecialidadId == id).
                Select(ecs => Helper.CentroSaludToDTO(ecs.CentroSalud)).
                ToListAsync();

            if (centrossalud == null)
            {
                return null;
            }

            return centrossalud;
        }       
    }
}
