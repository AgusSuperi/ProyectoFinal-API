using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Application.Interface;
using System.Threading.Tasks;

namespace ProyectoFinal.Service.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeighborhoodsController : ControllerBase
    {
        private readonly INeighborhoodApplication application;

        public NeighborhoodsController(INeighborhoodApplication application)
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
    }
}
