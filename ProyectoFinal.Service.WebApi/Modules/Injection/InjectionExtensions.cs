using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Application.Interface;
using ProyectoFinal.Application.Main;
using ProyectoFinal.Domain.Core;
using ProyectoFinal.Domain.Interface;
using ProyectoFinal.Infrastructure.Interface;
using ProyectoFinal.Infrastructure.Repository;

namespace ProyectoFinal.Service.WebApi.Modules.Injection
{
    public static class InjectionExtensions
    {
        public static void AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddScoped<IMedicalCenterApplication, MedicalCenterApplication>();
            services.AddScoped<IMedicalCenterDomain, MedicalCenterDomain>();
            services.AddScoped<IMedicalCenterRepository, MedicalCenterRepository>();
            services.AddScoped<ISpecialityApplication, SpecialityApplication>();
            services.AddScoped<ISpecialityDomain, SpecialityDomain>();
            services.AddScoped<ISpecialityRepository, SpecialityRepository>();
        }
    }
}
