using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.API.DTOs;
using ProyectoFinal.BD;

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
            return await _context.CentrosSalud.Select(c=> Helper.CentroSaludToDTO(c)).ToListAsync();
        }

        // GET: api/centrossalud/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CentroSaludDTO>> GetCentroSalud(int id)
        {
            var centroSalud = await _context.CentrosSalud.FindAsync(id);

            var colectivos = await _context.ColectivosCentrosSalud.
                Where(ccs => ccs.CentroSaludId == id).
                Select(ccs=> Helper.ColectivoToDTO(ccs.Colectivo)).
                ToListAsync();

            var especialidades = await _context.EspecialidadesCentrosSalud.
                Where(ecs => ecs.CentroSaludId == id).
                Select(ecs => Helper.EspecialidadToDTO(ecs.Especialidad)).
                ToListAsync();

            var practicasDiagnostico = await _context.PracticasDiagnosticoCentrosSalud.
                Where(pdcs => pdcs.CentroSaludId == id).
                Select(pdcs => Helper.PracticaDiagnosticoToDTO(pdcs.PracticaDiagnostico)).
                ToListAsync();

            if (centroSalud == null)
            {
                return NotFound();
            }

            var centroSaludDTO = Helper.CentroSaludToDTO(centroSalud);

            centroSaludDTO.Colectivos = colectivos;
            centroSaludDTO.Especialidades = especialidades;
            centroSaludDTO.PracticasDiagnostico = practicasDiagnostico;

            return centroSaludDTO;
        }
    }
}
