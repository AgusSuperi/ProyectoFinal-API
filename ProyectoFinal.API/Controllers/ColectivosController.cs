using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.API.DTOs;
using ProyectoFinal.BD;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/colectivos")]
    [ApiController]
    public class ColectivosController : ControllerBase
    {
        private readonly CentrosSaludContext _context;

        public ColectivosController(CentrosSaludContext context)
        {
            _context = context;
        }

        // GET: api/colectivos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ColectivoDTO>>> GetColectivos()
        {
            return await _context.Colectivos.Select(c=>Helper.ColectivoToDTO(c)).ToListAsync();
        }

        // GET: api/colectivos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ColectivoDTO>> GetColectivo(int id)
        {
            var colectivo = await _context.Colectivos.FindAsync(id);

            if (colectivo == null)
            {
                return NotFound();
            }

            return Helper.ColectivoToDTO(colectivo);
        }

        // GET: api/colectivos/5/centrossalud
        [HttpGet("{id}/centrossalud")]
        public async Task<ActionResult<IEnumerable<CentroSaludDTO>>> GetCentrosSaludByColectivo(int id)
        {
            var colectivo = await _context.Colectivos.FindAsync(id);

            if (colectivo == null)
            {
                return NotFound();
            }

            var centrossalud = await _context.ColectivosCentrosSalud.
                Where(ccs => ccs.ColectivoId == id).
                Select(ccs => Helper.CentroSaludToDTO(ccs.CentroSalud)).
                ToListAsync();

            if (centrossalud == null)
            {
                return NotFound();
            }

            return centrossalud;
        }
    }
}
