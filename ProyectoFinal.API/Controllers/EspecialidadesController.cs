using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.DTO;
using ProyectoFinal.IServicios;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/especialidades")]
    [ApiController]
    public class EspecialidadesController : ControllerBase
    {
        private readonly IServicioEspecialidades servicioEspecialidades;
        private readonly IMapper mapper;

        public EspecialidadesController(IServicioEspecialidades servicioEspecialidades, IMapper mapper)
        {
            this.servicioEspecialidades = servicioEspecialidades;
            this.mapper = mapper;
        }

        // GET: api/especialidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetEspecialidades()
        {
            var especialidades = await servicioEspecialidades.GetEspecialidades();

            if (especialidades == null)
            {
                return NotFound();
            }

            return Ok(especialidades);
        }

        // GET: api/especialidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EspecialidadDTO>> GetEspecialidadPorId(int id)
        {
            var especialidad = await servicioEspecialidades.GetEspecialidadPorId(id);

            if (especialidad == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<EspecialidadDTO>(especialidad));
        }

        // GET: api/especialidades/5/centrossalud
        [HttpGet("{id}/centrossalud")]
        public async Task<ActionResult<IEnumerable<CentroSaludDTO>>> GetCentrosSaludPorEspecialidadId(int id)
        {
            var centrosSalud = await servicioEspecialidades.GetCentrosSaludPorEspecialidadId(id);

            if (centrosSalud == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<IEnumerable<CentroSaludDTO>>(centrosSalud).ToList());
        }
    }
}
