using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.BD;
using ProyectoFinal.DTO;
using ProyectoFinal.IServicios;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/centrossalud")]
    [ApiController]
    public class CentrosSaludController : ControllerBase
    {
        private readonly IServicioCentrosSalud servicioCentrosSalud;

        public CentrosSaludController(IServicioCentrosSalud servicioCentrosSalud)
        {
            this.servicioCentrosSalud = servicioCentrosSalud;
        }

        // GET: api/centrossalud
        [HttpGet]
        public async Task<IEnumerable<CentroSaludDTO>> GetCentrosSalud()
        {
            return await servicioCentrosSalud.GetCentrosSaludAsync();
        }        

        // GET: api/centrossalud/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CentroSaludDTO>> GetCentroSaludPorId(int id)
        {
            var centroSalud = await servicioCentrosSalud.GetCentroSaludPorIdAsync(id);

            if (centroSalud == null)
            {
                return NotFound();
            }

            return centroSalud;
        }

        // GET: api/centrossalud/5/especialidades
        [HttpGet("{id}/especialidades")]
        public async Task<IEnumerable<EspecialidadDTO>> GetEspecialidades(int id)
        {
            return await servicioCentrosSalud.GetEspecialidadesPorCentroSaludIdAsync(id);
        }

        // POST: api/centrossalud/filtro
        [HttpPost("filtro")]
        public async Task<IEnumerable<CentroSaludDTO>> GetCentrosSaludPorFiltro(FiltroDTO filtro)
        {
            return await servicioCentrosSalud.GetCentrosSaludPorFiltro(filtro);        
        }
    }
}
