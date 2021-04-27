using AutoMapper;
using Coravel;
using Coravel.Scheduling.Schedule.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NewsWebsite.Data;
using NewsWebsite.IocConfig;
using NewsWebsite.IocConfig.AutoMapper;
using NewsWebsite.Services;
using NewsWebsite.ViewModels.DynamicAccess;
using NewsWebsite.ViewModels.Settings;
using System;

namespace NewsWebsite
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IServiceProvider Services { get; }
        public Startup(IConfiguration configuration )
        {
            Configuration = configuration;
            
        }
        public void ConfigureServices(IServiceCollection services)
        {

           

             services.AddAutoMapper(typeof(MappingProfiles));
            

            services.Configure<SiteSettings>(Configuration.GetSection(nameof(SiteSettings)));
            services.AddDbContext<NewsDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlServer")));
            services.AddCustomServices();
            services.AddCustomIdentityServices();
            
            services.AddScheduler();
            services.ConfigureWritable<SiteSettings>(Configuration.GetSection("SiteSettings"));
            services.ConfigureApplicationCookie(options =>
            {
                //options.LoginPath = "/Account/SignIn";
                options.AccessDeniedPath = "/Admin/Manage/AccessDenied";
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy(ConstantPolicies.DynamicPermission, policy => policy.Requirements.Add(new DynamicPermissionRequirement()));
            });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
         if (env.IsDevelopment())
            app.UseDeveloperExceptionPage();
         else
            app.UseExceptionHandler("/Home/Error");

         app.UseStaticFiles();
            app.UseCustomIdentityServices();

            var provider = app.ApplicationServices;

            provider.UseScheduler(scheduler =>
            {
               // scheduler.Schedule<SendWeeklyNewsletter>().EveryMinute();
              scheduler.Schedule<SendWeeklyNewsletter>().Cron("30 20 * * 5"); //UTC Time
               // scheduler.Schedule<SendWeeklyNewsletter>().Cron("53 22 12 4 1"); //UTC Time
            });

         app.Use(async (context, next) =>
         {
            await next();
            if (context.Response.StatusCode == 404)
            {
               context.Request.Path = "/home/error404";
               await next();
            }
         });
         app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(routes =>
            {
                routes.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                routes.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Home}/{action=Index}/{id?}"
               );
            });
        }
    }
}
