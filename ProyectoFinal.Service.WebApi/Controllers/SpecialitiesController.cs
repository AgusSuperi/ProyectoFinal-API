using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Application.Interface;
using System.Threading.Tasks;

namespace ProyectoFinal.Service.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialitiesController : ControllerBase
    {
        private readonly ISpecialityApplication application;

        public SpecialitiesController(ISpecialityApplication application)
        {
            this.application = application;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var response = await application.GetAll();

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("names")]
        public async Task<IActionResult> GetNames()
        {
            var response = await application.GetNames();

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

        [HttpGet("{id}/medicalCenters")]
        public async Task<IActionResult> GetMedicalCentersById(int id)
        {
            if (id <= 0)
                return BadRequest();

            var response = await application.GetMedicalCentersById(id);

            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
    }
}
