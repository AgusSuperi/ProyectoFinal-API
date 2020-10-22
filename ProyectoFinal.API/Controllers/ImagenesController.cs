using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/imagenes")]
    [ApiController]
    public class ImagenesController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ImagenesController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("{nombre}")]
        public IActionResult GetImagenCaps(string nombre)
        {
            return AbrirImagenODefault(nombre);
        }

        private IActionResult AbrirImagenODefault(string nombre)
        {
            var rutaImagen = Path.Combine(_webHostEnvironment.ContentRootPath, "Imagenes/CAPS/" + nombre);

            if (System.IO.File.Exists(rutaImagen))
            {
                Byte[] b = System.IO.File.ReadAllBytes(rutaImagen);
                return File(b, "image/png");
            }
            return AbrirImagenPorDefault("defaultCaps.png");
        }

        private IActionResult AbrirImagenPorDefault(string nombreImagenDefault)
        {
            var rutaImagen = Path.Combine(_webHostEnvironment.ContentRootPath, "Imagenes/Default/" + nombreImagenDefault);

            if (System.IO.File.Exists(rutaImagen))
            {
                Byte[] b = System.IO.File.ReadAllBytes(rutaImagen);
                return File(b, "image/png");
            }
            return BadRequest();
        }
    }
}
