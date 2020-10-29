using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProyectoFinal.BD;
using ProyectoFinal.Mapper;
using ProyectoFinal.IServicios;
using ProyectoFinal.Servicios;
using Microsoft.OpenApi.Models;

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

            // Servicios
            services.AddTransient<IServicioCentrosSalud, ServicioCentrosSalud>();
            services.AddTransient<IServicioEspecialidades, ServicioEspecialidades>();
            services.AddTransient<IServicioBarrios, ServicioBarrios>();
            services.AddTransient<IServicioImagenes, ServicioImagenes>();

            // AutoMapper
            services.AddAutoMapper(c => c.AddProfile<AutoMapperProfile>(), typeof(Startup));

            // Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Proyecto Final API", Version = "v1", Description = "Proyecto Final API v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Proyecto Final API v1");
                });
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
