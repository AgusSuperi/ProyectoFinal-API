using System.Collections.Generic;

namespace ProyectoFinal.Application.DTO
{
    public class FilterDTO
    {
        public List<string> OpeningHours { get; set; }

        public List<NeighborhoodDTO> Neighborhoods { get; set; }

        public List<SpecialityDTO> Specialities { get; set; }
    }
}
