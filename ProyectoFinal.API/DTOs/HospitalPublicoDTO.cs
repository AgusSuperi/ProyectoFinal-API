using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.API.DTOs
{
    public class HospitalPublicoDTO
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Nombre { get; set; }

        [Required, StringLength(80)]
        public string Telefono { get; set; }

        [Required, StringLength(80)]
        public string Direccion { get; set; }

        [Required, StringLength(80)]
        public string URLPagina { get; set; }

        [Required, StringLength(250)]
        public string Restriccion { get; set; }
    }
}
