using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ProyectoFinal.Service.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public ImagesController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("{imageName}")]
        public async Task<IActionResult> GetImageByName(string imageName)
        {
            var imagePath = Path.Combine(webHostEnvironment.ContentRootPath, "Images/MedicalCenters/" + imageName);

            if (System.IO.File.Exists(imagePath))
            {
                Byte[] b = await System.IO.File.ReadAllBytesAsync(imagePath);
                return File(b, "image/png");
            }

            return BadRequest();
        }
    }
}
