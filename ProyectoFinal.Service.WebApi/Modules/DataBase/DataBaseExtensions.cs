using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProyectoFinal.Infrastructure.Data;

namespace ProyectoFinal.Service.WebApi.Modules.DataBase
{
    public static class DataBaseExtensions
    {
        public static void AddContext(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContextPool<ProyectoFinalContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("ProyectoFinalBD"));
                });
        }
    }
}
