using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using WebApplication7.Model;

namespace WebApplication7
{
    public class Startup
    {
        public IConfiguration Configuration { get; }//configuration object
        public Startup(IConfiguration configuration)//creating constructor accepting configuration object
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<Sinterface, Sellerr>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>

            {
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Seller}/{action=Index}/{id?}");
            });

        }

    }
}