using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using WebSite.Services;

namespace WebSite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddHttpClient<IWebApi1Service, WebApi1Service>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:5001/");
            });
            services.AddHttpClient<IWebApi2Service, WebApi2Service>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:5002/");
            });
            services.AddHttpClient<IWebApi3Service, WebApi3Service>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:5003/");
            });
            services.AddHttpClient<IWebApi4Service, WebApi4Service>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:5004/");
            });

            services.AddScoped<IFileUpload, FileUpload>();
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
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub(options => options.WebSockets.CloseTimeout = new TimeSpan(1, 1, 1));
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
