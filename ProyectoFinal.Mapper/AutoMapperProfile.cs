using AutoMapper;
using ProyectoFinal.DTO;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.Mapper
{
    public class AutoMapperProfile : Profile
    {
        // d: Destino s: Fuente
        public AutoMapperProfile()
        {
            CreateMap<CentroSalud, CentroSaludDTO>()
                .ForMember(d => d.Id, s => s.MapFrom(d => d.Id))
                .ForMember(d => d.Nombre, s => s.MapFrom(d => d.Nombre))
                .ForMember(d => d.Telefono, s => s.MapFrom(d => d.Telefono))
                .ForMember(d => d.Direccion, s => s.MapFrom(d => d.Direccion))
                .ForMember(d => d.HorarioAtencion, s => s.MapFrom(d => d.HorarioAtencion))
                .ForMember(d => d.Latitud, s => s.MapFrom(d => d.Latitud))
                .ForMember(d => d.Longitud, s => s.MapFrom(d => d.Longitud))
                .ForMember(d => d.Barrio, s => s.MapFrom(d => d.Barrio))
                .ForMember(d => d.ImagenURL, s => s.MapFrom(d => d.ImagenURL))
                .ReverseMap();

            CreateMap<Especialidad, EspecialidadDTO>()
                .ForMember(d => d.Id, s => s.MapFrom(d => d.Id))
                .ForMember(d => d.Nombre, s => s.MapFrom(d => d.Nombre))
                .ReverseMap();
        }
    }
}
