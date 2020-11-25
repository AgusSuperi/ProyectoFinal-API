using Microsoft.EntityFrameworkCore;
using ProyectoFinal.BD;
using ProyectoFinal.DTO;
using ProyectoFinal.IServicios;
using ProyectoFinal.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Servicios
{
    public class ServicioFiltros : IServicioFiltros
    {
        private readonly CentrosSaludContext centrosSaludContext;

        public ServicioFiltros(CentrosSaludContext centrosSaludContext)
        {
            this.centrosSaludContext = centrosSaludContext;
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
