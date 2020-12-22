using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Domain.Entity
{
    public class MedicalCenter
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        [Required, StringLength(15)]
        public string PhoneNumber { get; set; }

        [Required, StringLength(50)]
        public string Address { get; set; }

        [Required, StringLength(15)]
        public string OpeningHours { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public Neighborhood Neighborhood { get; set; }

        [Required, StringLength(20)]
        public string ImageURL { get; set; }

        public IEnumerable<Speciality> Specialities { get; set; } = new List<Speciality>();
    }
}
