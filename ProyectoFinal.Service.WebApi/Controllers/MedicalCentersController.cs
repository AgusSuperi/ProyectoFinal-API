using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Application.Interface;
using ProyectoFinal.Transversal.Common;

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
            var response = await application.GetSpecialitiesById(id);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("neighborhoods")]
        public async Task<IActionResult> GetNeighborhoods()
        {
            var response = await application.GetNeighborhoods();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("filterOpeningHours")]
        public IActionResult GetFilterOpeningHours()
        {
            var response = application.GetFilterOpeningHours();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPost("filter")]
        public async Task<IActionResult> GetByFilter(Filter filter)
        {
            var response = await application.GetByFilter(filter);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
    }
}
