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
using System.Net;
using System.Net.Mime;
using Microsoft.Extensions.Primitives;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Cors.Infrastructure;

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
            services.AddTransient<IServicioFiltros, ServicioFiltros>();            

            // AutoMapper
            services.AddAutoMapper(c => c.AddProfile<AutoMapperProfile>(), typeof(Startup));

            // Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Proyecto Final API", Version = "v1", Description = "Proyecto Final API v1" });
            });

            // CORS
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            string[] corsAllowedSites = new string[]{ "http://localhost:3000" };

            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = MediaTypeNames.Text.Html;
                    if (context.Request.Headers.TryGetValue("Origin", out StringValues origin) && corsAllowedSites.Contains(origin.ToString()))
                    {
                        context.Response.Headers.Append("Access-Control-Allow-Origin", origin.ToString());
                        context.Response.Headers.Append("Access-Control-Allow-Credentials", "true");
                    }

                    return Task.CompletedTask;
                });
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Proyecto Final API v1");
                });
            }

            CorsMiddlewareExtensions
                .UseCors(app, (Action<CorsPolicyBuilder>)(options => options.WithOrigins(corsAllowedSites)
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()));

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });            
        }
    }
}
