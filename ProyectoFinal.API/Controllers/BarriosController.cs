using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.IServicios;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/barrios")]
    [ApiController]
    public class BarriosController : ControllerBase
    {
        private readonly IServicioBarrios servicioBarrios;

        public BarriosController(IServicioBarrios servicioBarrios)
        {
            this.servicioBarrios = servicioBarrios;
        }

        // GET: api/barrios
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetBarrios()
        {
            var barrios = servicioBarrios.GetBarrios();

            if (barrios == null)
            {
                return NotFound();
            }

            return Ok(barrios);
        }
    }
}
