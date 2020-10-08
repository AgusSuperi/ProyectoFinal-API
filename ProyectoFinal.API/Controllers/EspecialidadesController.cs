using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.API.DTOs;
using ProyectoFinal.BD;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/especialidades")]
    [ApiController]
    public class EspecialidadesController : ControllerBase
    {
        private readonly CentrosSaludContext _context;

        public EspecialidadesController(CentrosSaludContext context)
        {
            _context = context;
        }

        // GET: api/especialidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetEspecialidades()
        {
            return await _context.Especialidades.Select(e => e.Nombre).ToListAsync();
        }

        // GET: api/especialidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EspecialidadDTO>> GetEspecialidad(int id)
        {
            var especialidad = await _context.Especialidades.FindAsync(id);

            if (especialidad == null)
            {
                return NotFound();
            }

            return Helper.EspecialidadToDTO(especialidad);
        }

        // GET: api/especialidades/5/centrossalud
        [HttpGet("{id}/centrossalud")]
        public async Task<ActionResult<IEnumerable<CentroSaludDTO>>> GetCentrosSaludByEspecialidades(int id)
        {
            var especialidad = await _context.Especialidades.FindAsync(id);

            if (especialidad == null)
            {
                return NotFound();
            }

            var centrossalud = await _context.EspecialidadesCentrosSalud.
                Where(ecs => ecs.EspecialidadId == id).
                Select(ecs => Helper.CentroSaludToDTO(ecs.CentroSalud)).
                ToListAsync();

            if (centrossalud == null)
            {
                return NotFound();
            }

            return centrossalud;
        }
    }
}
