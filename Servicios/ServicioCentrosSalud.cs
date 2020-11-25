using ProyectoFinal.IServicios;
using ProyectoFinal.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.BD;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.Servicios
{
    public class ServicioCentrosSalud : IServicioCentrosSalud
    {
        private readonly CentrosSaludContext centrosSaludContext;

        public ServicioCentrosSalud(CentrosSaludContext centrosSaludContext)
        {
            this.centrosSaludContext = centrosSaludContext;
        }        

        public async Task<IEnumerable<CentroSalud>> GetCentrosSalud()
        {
            return await centrosSaludContext.CentrosSalud.ToListAsync();
        }

        public async Task<CentroSalud> GetCentroSaludPorId(int id)
        {
            return await centrosSaludContext.CentrosSalud.FindAsync(id);
        }

        public async Task<IEnumerable<Especialidad>> GetEspecialidadesPorCentroSaludId(int id)
        {
            var centroSalud = await centrosSaludContext.CentrosSalud.FindAsync(id);

            if (centroSalud == null)
            {
                return null;
            }

            var especialidades = await centrosSaludContext.EspecialidadesCentrosSalud.
                Where(ecs => ecs.CentroSaludId == id).
                Select(ecs => ecs.Especialidad).
                ToListAsync();

            return especialidades;
        }
    }
}
