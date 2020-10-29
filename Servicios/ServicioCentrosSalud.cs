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

        public async Task<IEnumerable<CentroSalud>> GetCentrosSaludPorFiltro(FiltroDTO filtro)
        {
            var centrosSalud = await centrosSaludContext.CentrosSalud.
                Where(c => (filtro.Horarios.Count > 0 ? filtro.Horarios.Contains(c.HorarioAtencion) : true) &&
                (filtro.Barrios.Count > 0 ? filtro.Barrios.Contains(c.Barrio) : true)).
                Include(c => c.EspecialidadesCentroSalud).
                ToListAsync();

            List<CentroSalud> result = new List<CentroSalud>();

            if (filtro.Especialidades.Count > 0)
            {
                foreach (var centroSalud in centrosSalud)
                {
                    if (await CapsContieneEspecialidades(filtro.Especialidades, centroSalud))
                    {
                        result.Add(centroSalud);
                    }
                }

                return result;
            }
            else
            {
                return centrosSalud;
            }
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

        private async Task<bool> CapsContieneEspecialidades(List<string> especialidades, CentroSalud centroSalud)
        {
            var especialidadesCentroSalud = await centrosSaludContext.EspecialidadesCentrosSalud.
                Where(e => e.CentroSaludId == centroSalud.Id).
                Select(e => e.Especialidad.Nombre).
                ToListAsync();

            foreach (var especialidad in especialidades)
            {
                if (!especialidadesCentroSalud.Contains(especialidad))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
