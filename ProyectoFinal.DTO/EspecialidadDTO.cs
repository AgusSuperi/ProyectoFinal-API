using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.DTO
{
    public class EspecialidadDTO
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Nombre { get; set; }
    }
}
