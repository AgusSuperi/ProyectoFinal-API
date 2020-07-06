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
            var centrosSalud = await _context.CentrosSalud.Select(c => Helper.CentroSaludToDTO(c)).ToListAsync();
            centrosSalud.ForEach(c => GetEspecialidades(c));
            return centrosSalud;
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

        private void GetEspecialidades(CentroSaludDTO centroSalud)
        {
            var especialidades = _context.EspecialidadesCentrosSalud.
                Where(ecs => ecs.CentroSaludId == centroSalud.Id).
                Select(ecs => Helper.EspecialidadToDTO(ecs.Especialidad)).
                ToList();

            centroSalud.Especialidades = especialidades;
        }
    }
}
