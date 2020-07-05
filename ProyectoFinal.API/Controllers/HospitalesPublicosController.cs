using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.API.DTOs;
using ProyectoFinal.BD;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.API.Controllers
{
        [Route("api/hospitalespublicos")]
        [ApiController]
        public class HospitalesPublicosController : ControllerBase
        {
            private readonly CentrosSaludContext _context;

            public HospitalesPublicosController(CentrosSaludContext context)
            {
                _context = context;
            }

            // GET: api/hospitalespublicos
            [HttpGet]
            public async Task<ActionResult<IEnumerable<HospitalPublicoDTO>>> GetHospitalesPublicos()
            {
                return await _context.HospitalesPublicos.Select(c => Helper.HospitalPublicoToDTO(c)).ToListAsync();
            }

            // GET: api/hospitalespublicos/5
            [HttpGet("{id}")]
            public async Task<ActionResult<HospitalPublicoDTO>> GetHospitalesPublicos(int id)
            {
                var hospitalPublico = await _context.HospitalesPublicos.FindAsync(id);

                if (hospitalPublico == null)
                {
                    return NotFound();
                }

                return Helper.HospitalPublicoToDTO(hospitalPublico);
            }
        }
    }
