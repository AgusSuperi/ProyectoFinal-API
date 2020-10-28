using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.IServicios;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/imagenes")]
    [ApiController]
    public class ImagenesController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IServicioImagenes servicioImagenes;

        public ImagenesController(IServicioImagenes servicioImagenes, IWebHostEnvironment webHostEnvironment)
        {
            this.servicioImagenes = servicioImagenes;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("{nombreImagen}")]
        public IActionResult GetImagenCentroSaludPorNombre(string nombreImagen)
        {
            return AbrirImagenODefault(nombreImagen);
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
