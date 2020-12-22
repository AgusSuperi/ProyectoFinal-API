using AutoMapper;
using ProyectoFinal.Application.DTO;
using ProyectoFinal.Domain.Entity;

namespace ProyectoFinal.Transversal.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MedicalCenter, MedicalCenterDTO>().ReverseMap();
            CreateMap<Speciality, SpecialityDTO>().ReverseMap();
            CreateMap<Neighborhood, NeighborhoodDTO>().ReverseMap();
        }
    }
}
