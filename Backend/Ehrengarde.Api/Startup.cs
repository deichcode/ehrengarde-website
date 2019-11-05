using Ehrengarde.Api.Adapters.HttpAdapter;
using Ehrengarde.Api.Adapters.ical.net.Calendar;
using Ehrengarde.Api.Services.Calendar;
using Ehrengarde.Api.Services.HttpService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ehrengarde.Api
{
    public class Startup
    {
        private readonly IHostingEnvironment _environment;

        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            _environment = environment;
            Configuration = configuration;
        }

        private const string AllowAnyOrigin = "_allowLocalhostOrigin";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(AllowAnyOrigin,
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            if (_environment.IsDevelopment())
            {
                services.AddSingleton<ICalendarService, CalendarService>();
            }
            else
            {
                services.AddSingleton<ICalendarService, CalendarService>();
            }

            services.AddSingleton<IHttpService, HttpService>();
            services.AddSingleton<IHttpAdatper, HttpAdapter>();
            services.AddSingleton<ICalendarAdapter, CalendarAdapter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseCors(AllowAnyOrigin);
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
                app.UseHttpsRedirection();
            }

            app.UseMvc();

            ServeSpaFiles(app, env);
        }

        private static void ServeSpaFiles(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseSpa(spa =>
            {
                spa.Options.DefaultPage = "/index.html";

                if (env.IsDevelopment())
                {
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:8080");
                }
            });
        }
    }
}