using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Application.DTO;
using ProyectoFinal.Application.Interface;
using System.Threading.Tasks;

namespace ProyectoFinal.Service.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalCentersController : ControllerBase
    {
        private readonly IMedicalCenterApplication application;

        public MedicalCentersController(IMedicalCenterApplication application)
        {
            this.application = application;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await application.GetAll();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }        

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0)
                return BadRequest();

            var response = await application.GetById(id);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("{id}/specialities")]
        public async Task<IActionResult> GetSpecialitiesById(int id)
        {
            if (id <= 0)
                return BadRequest();

            var response = await application.GetSpecialitiesById(id);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        /*
        [HttpPost("GetByFilter")]
        public async Task<IActionResult> GetByFilter(FilterDTO filtro)
        {
            return Ok();
        }

        
        public async Task<IEnumerable<CentroSalud>> GetCentrosSaludPorFiltro(FiltroDTO filtro)
        {
            var centrosSalud = await centrosSaludContext.CentrosSalud.
                Where(c => (filtro.Horarios.Count > 0 ? filtro.Horarios.Contains(c.HorarioAtencion) : true) &&
                (filtro.Barrios.Count > 0 ? filtro.Barrios.Contains(c.Barrio) : true)).
                Include(c => c.EspecialidadesCentroSalud).
                ToListAsync();

            List<CentroSalud> result = new List<CentroSalud>();

            if (filtro.Especialidades.Count > 0)
            {
                foreach (var centroSalud in centrosSalud)
                {
                    if (await CapsContieneEspecialidades(filtro.Especialidades, centroSalud))
                    {
                        result.Add(centroSalud);
                    }
                }

                return result;
            }
            else
            {
                return centrosSalud;
            }
        }

        private async Task<bool> CapsContieneEspecialidades(List<string> especialidades, CentroSalud centroSalud)
        {
            var especialidadesCentroSalud = await centrosSaludContext.EspecialidadesCentrosSalud.
                Where(e => e.CentroSaludId == centroSalud.Id).
                Select(e => e.Especialidad.Nombre).
                ToListAsync();

            foreach (var especialidad in especialidades)
            {
                if (!especialidadesCentroSalud.Contains(especialidad))
                {
                    return false;
                }
            }

            return true;
        }
        */
    }
}
