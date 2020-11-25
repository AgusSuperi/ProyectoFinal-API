using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.DTO;
using ProyectoFinal.IServicios;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/filtros")]
    [ApiController]
    public class FiltrosController : ControllerBase
    {
        private readonly IServicioFiltros servicioFiltros;
        private readonly IMapper mapper;

        public FiltrosController(IServicioFiltros servicioFiltros, IMapper mapper)
        {
            this.servicioFiltros = servicioFiltros;
            this.mapper = mapper;
        }

        [HttpPost("centrossalud")]
        public async Task<ActionResult<IEnumerable<CentroSaludDTO>>> GetCentrosSaludPorFiltro(FiltroDTO filtro)
        {
            var centrosSalud = await servicioFiltros.GetCentrosSaludPorFiltro(filtro);
            if (centrosSalud == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<IEnumerable<CentroSaludDTO>>(centrosSalud).ToList());
        }
    }
}
