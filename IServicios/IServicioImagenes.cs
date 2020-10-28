using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinal.IServicios
{
    public interface IServicioImagenes
    {
        public ActionResult GetImagenCentroSaludPorNombre(string nombreImagen, string rutaProyectoAPI);
    }
}
 