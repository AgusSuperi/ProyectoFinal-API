using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Domain.Entity
{
    public class Speciality
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public IEnumerable<MedicalCenter> MedicalCenters { get; set; } = new List<MedicalCenter>();

        public Speciality(string Name)
        {
            this.Name = Name;
        }
    }
}
