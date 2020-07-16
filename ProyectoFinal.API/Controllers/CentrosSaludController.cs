using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.API.DTOs;
using ProyectoFinal.BD;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/centrossalud")]
    [ApiController]
    public class CentrosSaludController : ControllerBase
    {
        private readonly CentrosSaludContext _context;

        public CentrosSaludController(CentrosSaludContext context)
        {
            _context = context;
        }

        // GET: api/centrossalud
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CentroSaludDTO>>> GetCentrosSalud()
        {
            return await _context.CentrosSalud.Select(c => Helper.CentroSaludToDTO(c)).ToListAsync();
        }        

        // GET: api/centrossalud/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CentroSaludDTO>> GetCentroSalud(int id)
        {
            var centroSalud = await _context.CentrosSalud.FindAsync(id); 

            if (centroSalud == null)
            {
                return NotFound();
            }

            return Helper.CentroSaludToDTO(centroSalud);
        }

        // GET: api/centrossalud/5/especialidades
        [HttpGet("{id}/especialidades")]
        public async Task<ActionResult<IEnumerable<EspecialidadDTO>>> GetEspecialidades(int id)
        {
            var centroSalud = await _context.CentrosSalud.FindAsync(id);

            if (centroSalud == null)
            {
                return NotFound();
            }
            var especialidades = await _context.EspecialidadesCentrosSalud.
                Where(ecs => ecs.CentroSaludId == id).
                Select(ecs => Helper.EspecialidadToDTO(ecs.Especialidad)).
                ToListAsync();

            return especialidades;
        }

        // POST: api/centrossalud/filtro
        [HttpPost("filtro")]
        public async Task<ActionResult<IEnumerable<CentroSaludDTO>>> GetCentrosSaludUsandoFiltros(FiltroDTO filtro)
        {
            var centrosSalud = await _context.CentrosSalud.
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

        private bool CapsContieneEspecialidades(List<string> especialidades, CentroSaludDTO centroSalud)
        {
            var especialidadesCentroSalud =  _context.EspecialidadesCentrosSalud.
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
