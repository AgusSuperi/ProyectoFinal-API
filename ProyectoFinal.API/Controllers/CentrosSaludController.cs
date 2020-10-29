using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.DTO;
using ProyectoFinal.IServicios;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/centrossalud")]
    [ApiController]
    public class CentrosSaludController : ControllerBase
    {
        private readonly IServicioCentrosSalud servicioCentrosSalud;
        private readonly IMapper mapper;

        public CentrosSaludController(IServicioCentrosSalud servicioCentrosSalud, IMapper mapper)
        {
            this.servicioCentrosSalud = servicioCentrosSalud;
            this.mapper = mapper;
        }

        // GET: api/centrossalud
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CentroSaludDTO>>> GetCentrosSalud()
        {
            var centrosSalud = await servicioCentrosSalud.GetCentrosSalud();
            if (centrosSalud == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<IEnumerable<CentroSaludDTO>>(centrosSalud).ToList());
        }        

        // GET: api/centrossalud/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CentroSaludDTO>> GetCentroSaludPorId(int id)
        {
            var centroSalud = await servicioCentrosSalud.GetCentroSaludPorId(id);
            if (centroSalud == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<CentroSaludDTO>(centroSalud));
        }

        // GET: api/centrossalud/5/especialidades
        [HttpGet("{id}/especialidades")]
        public async Task<ActionResult<IEnumerable<EspecialidadDTO>>> GetEspecialidadesPorCentroSaludId(int id)
        {
            var especialidades = await servicioCentrosSalud.GetEspecialidadesPorCentroSaludId(id);
            if (especialidades == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<IEnumerable<EspecialidadDTO>>(especialidades).ToList());
        }

        // POST: api/centrossalud/filtro
        [HttpPost("filtro")]
        public async Task<ActionResult<IEnumerable<CentroSaludDTO>>> GetCentrosSaludPorFiltro(FiltroDTO filtro)
        {
            var centrosSalud = await servicioCentrosSalud.GetCentrosSaludPorFiltro(filtro);            
            if (centrosSalud == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<IEnumerable<CentroSaludDTO>>(centrosSalud).ToList());
        }
    }
}
