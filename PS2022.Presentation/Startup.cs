using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PS2022.BLL.Registries;
using PS2022.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PS2022.Presentation
{
    public class Startup
    {
        private readonly string AllowedOrigins = "AllowedOrigins";
        private readonly string[] AllowedMethods = { "POST", "GET", "PUT", "PATCH", "DELETE", "OPTIONS" };

        private readonly IConfiguration _configuration;
        private IWebHostEnvironment _environment;

        public Startup(IConfiguration configuration,IWebHostEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;

            ConfigurationRegistry.CreateInstance(_configuration, _environment.ContentRootPath);
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddControllersWithViews().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            });


            services.AddCors(options =>
            {
                options.AddPolicy(AllowedOrigins, builder =>
                {
                    builder.WithOrigins("*");
                    builder.WithMethods(AllowedMethods);
                    builder.AllowAnyHeader();
                });
            });

            new DependencyRegistrationModule().RegisterDependencies(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/error-development");
            }
            else
            {
                app.UseExceptionHandler("/error");
                app.UseHsts();
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseCors(AllowedOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "api/{controller=Home}/{action=Index}/{id?}"
                );
            });

        }
    }
}
