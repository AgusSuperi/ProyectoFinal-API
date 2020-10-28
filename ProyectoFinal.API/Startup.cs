using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProyectoFinal.BD;
using ProyectoFinal.IServicios;
using ProyectoFinal.Servicios;

namespace ProyectoFinal.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<CentrosSaludContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CentrosSaludBD"));
            });

            services.AddControllers();

            services.AddTransient<IServicioCentrosSalud, ServicioCentrosSalud>();
            services.AddTransient<IServicioEspecialidades, ServicioEspecialidades>();
            services.AddTransient<IServicioBarrios, ServicioBarrios>();
            services.AddTransient<IServicioImagenes, ServicioImagenes>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });            
        }
    }
}
