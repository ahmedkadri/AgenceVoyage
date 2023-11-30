using Agence_Voyage_Business.Interfaces;
using Agence_Voyage_Business.Mappings;
using Agence_Voyage_Business.Repository;
using Agence_Voyage_Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agence_Voyage_WebUI
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

            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AgenceVoyageContext>(options =>
            {
                options.UseSqlite(connectionString);
            });

            services.AddControllers();

            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IProduitRepository, ProduitRepository>();
            services.AddScoped<IDossierRepository, DossierRepository>();

            services.AddAutoMapper(typeof(MappingProfile));

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "AgenceVoyage",
                    Description = "API .Net Core 3.1",
                    Contact = new OpenApiContact
                    {
                        Name = "Ahmed Kadri",
                        Email = "Ahmed.kadri@esprit.tn"
                    },
                    License = new OpenApiLicense
                    {
                        Name = "AgengeVoyage",
                        Url = new Uri("https://example.com/license")
                    }
                });
            });
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

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
