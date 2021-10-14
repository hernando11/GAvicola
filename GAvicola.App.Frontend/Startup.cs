using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//using GAvicola.App.Persistencia.AppRepositorios; // 05 Septiembre 2021
using GAvicola.App.Persistencia; // 06 Septiembre 2021

namespace GAvicola.App.Frontend
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
            services.AddRazorPages();
            //services.AddTransient<IRepositorioGalpon, RepositorioGalpon>();
            services.AddSingleton<IRepositorioGalpon ,RepositorioGalpon>(); // 05 Septiembre 2021
            services.AddSingleton<IRepositorioVeterinario, RepositorioVeterinario>(); // 05 Sept 2021
            services.AddSingleton<IRepositorioOperario, RepositorioOperario>(); // 05 Sept 2021
            services.AddSingleton<IRepositorioGAmbiente, RepositorioGAmbiente>(); // 08 Sept 2021
            services.AddSingleton<IRepositorioSugerencia, RepositorioSugerencia>(); // 13 Sept 2021
            services.AddSingleton<IRepositorioDiagnostico, RepositorioDiagnostico>(); // 13 Sept 2021
            //services.AddSingleton<IRepositorioAmbiente, RepositorioAmbiente>(); // 13 Sept 2021

            /* Para que funcione el "AddSingleton" de contener,
             En cada uno de los "RepositoriosXXXX.cs" de "Persistencia" deben de ir estass 4 lineas.  - Fecha 06 Sept 2021
            private readonly AppContext _appContext;
            public RepositorioVeterinario(AppContext appContext)
            {
                _appContext=appContext;
            }
            */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
