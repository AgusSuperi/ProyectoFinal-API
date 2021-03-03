using Microsoft.Extensions.DependencyInjection;

namespace ProyectoFinal.Service.WebApi.Modules.DataBase
{
    public static class CorsExtensions
    {
        public static void AddCorsExtension(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
        }
    }
}