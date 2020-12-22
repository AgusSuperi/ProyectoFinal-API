using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Domain.Entity
{
    public class Neighborhood
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        public IEnumerable<MedicalCenter> MedicalCenters { get; set; } = new List<MedicalCenter>();
    }
}
