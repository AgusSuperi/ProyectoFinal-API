using ProyectoFinal.IServicios;
using ProyectoFinal.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.BD;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.Servicios
{
    public class ServicioCentrosSalud : IServicioCentrosSalud
    {
        private readonly CentrosSaludContext centrosSaludContext;

        public ServicioCentrosSalud(CentrosSaludContext centrosSaludContext)
        {
            this.centrosSaludContext = centrosSaludContext;
        }        

        public async Task<IEnumerable<CentroSaludDTO>> GetCentrosSaludAsync()
        {
            return await centrosSaludContext.CentrosSalud.Select(c => Helper.CentroSaludToDTO(c)).ToListAsync();
        }

        public async Task<CentroSaludDTO> GetCentroSaludPorIdAsync(int id)
        {
            var centroSalud = await centrosSaludContext.CentrosSalud.FindAsync(id);

            if (centroSalud == null)
            {
                return null;
            }

            return Helper.CentroSaludToDTO(centroSalud);
        }

        public async Task<IEnumerable<CentroSaludDTO>> GetCentrosSaludPorFiltro(FiltroDTO filtro)
        {
            var centrosSalud = await centrosSaludContext.CentrosSalud.
                Where(c => (filtro.Horarios.Count > 0 ? filtro.Horarios.Contains(c.HorarioAtencion) : true) &&
                (filtro.Barrios.Count > 0 ? filtro.Barrios.Contains(c.Barrio) : true)).
                Include(c => c.EspecialidadesCentroSalud).
                Select(c => Helper.CentroSaludToDTO(c)).
                ToListAsync();

            List<CentroSaludDTO> result = new List<CentroSaludDTO>();

            if (filtro.Especialidades.Count > 0)
            {
                foreach (var centroSalud in centrosSalud)
                {
                    if (CapsContieneEspecialidades(filtro.Especialidades, centroSalud))
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

        public async Task<IEnumerable<EspecialidadDTO>> GetEspecialidadesPorCentroSaludIdAsync(int id)
        {
            var centroSalud = await centrosSaludContext.CentrosSalud.FindAsync(id);

            if (centroSalud == null)
            {
                return null;
            }

            var especialidades = await centrosSaludContext.EspecialidadesCentrosSalud.
                Where(ecs => ecs.CentroSaludId == id).
                Select(ecs => Helper.EspecialidadToDTO(ecs.Especialidad)).
                ToListAsync();

            return especialidades;
        }

        private bool CapsContieneEspecialidades(List<string> especialidades, CentroSaludDTO centroSalud)
        {
            var especialidadesCentroSalud = centrosSaludContext.EspecialidadesCentrosSalud.
                Where(e => e.CentroSaludId == centroSalud.Id).
                Select(e => e.Especialidad.Nombre).
                ToList();

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
