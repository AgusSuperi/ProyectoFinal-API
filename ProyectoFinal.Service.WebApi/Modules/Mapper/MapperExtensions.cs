using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Transversal.Mapper;

namespace ProyectoFinal.Service.WebApi.Modules.Mapper
{
    public static class MapperExtensions
    {
        public static void AddMapper(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
