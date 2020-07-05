using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.API.DTOs
{
    public class CentroSaludDTO
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Nombre { get; set; }

        [Required]
        public int Telefono { get; set; }

        [Required, StringLength(80)]
        public string Direccion { get; set; }

        [Required, StringLength(80)]
        public string HorarioAtencion { get; set; }

        public double Latitud { get; set; }

        public double Longitud { get; set; }

        [Required, StringLength(80)]
        public string Barrio { get; set; }

    }
}
