using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hello.Infrastructure.Data.Context;
using HelloDDD.Web.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HelloDDD.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            //services.AddDbContext<StudyContext>(c =>
            //    c.UseSqlServer(Configuration.GetConnectionString("SqlServer"))
            //);
            //         services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseSqlServer(DbConfig.InitConn(Configuration.GetConnectionString("SqlServer_file"), Configuration.GetConnectionString("SqlServer"))));

            // .NET Core 原生依赖注入
            // 单写一层用来添加依赖项，可以将IoC与展示层 Presentation 隔离
            NativeInjectorBootStrapper.RegisterServices(services);

            // Automapper 注入
            services.AddAutoMapperSetup();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
