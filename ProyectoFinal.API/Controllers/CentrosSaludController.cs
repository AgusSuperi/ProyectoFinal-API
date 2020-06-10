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

            if (centroSalud == null)
            {
                return NotFound();
            }

            return Helper.CentroSaludToDTO(centroSalud);
        }
    }
}
