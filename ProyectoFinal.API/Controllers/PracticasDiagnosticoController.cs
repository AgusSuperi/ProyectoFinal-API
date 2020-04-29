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
    [Route("api/practicasdiagnostico")]
    [ApiController]
    public class PracticasDiagnosticoController : ControllerBase
    {
        private readonly CentrosSaludContext _context;

        public PracticasDiagnosticoController(CentrosSaludContext context)
        {
            _context = context;
        }

        // GET: api/practicasdiagnostico
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PracticaDiagnosticoDTO>>> GetPracticasDiagnosticos()
        {
            return await _context.PracticasDiagnosticos.Select(pd=>Helper.PracticaDiagnosticoToDTO(pd)).ToListAsync();
        }

        // GET: api/practicasdiagnostico/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PracticaDiagnosticoDTO>> GetPracticaDiagnostico(int id)
        {
            var practicaDiagnostico = await _context.PracticasDiagnosticos.FindAsync(id);

            if (practicaDiagnostico == null)
            {
                return NotFound();
            }

            return Helper.PracticaDiagnosticoToDTO(practicaDiagnostico);
        }

        // GET: api/practicasdiagnostico/5/centrossalud
        [HttpGet("{id}/centrossalud")]
        public async Task<ActionResult<IEnumerable<CentroSaludDTO>>> GetCentrosSaludByPracticaDiagnostico(int id)
        {
            var practicaDiagnostico = await _context.PracticasDiagnosticos.FindAsync(id);

            if (practicaDiagnostico == null)
            {
                return NotFound();
            }

            var centrossalud = await _context.PracticasDiagnosticoCentrosSalud.
                Where(pdcs => pdcs.PracticaDiagnosticoId == id).
                Select(pdcs => Helper.CentroSaludToDTO(pdcs.CentroSalud)).
                ToListAsync();

            if (centrossalud == null)
            {
                return NotFound();
            }


            return centrossalud;
        }
    }
}
