using AKNProje.ToDo.BLL.Concrete;
using AKNProje.ToDo.BLL.Concrete.Manager;
using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Contexts;
using AKNProje.ToDo.DAL.Concrete.EntityFrameworkcore.Repositories;
using AKNProje.ToDo.DAL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace AKNProje.ToDo.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to Add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IReportService, ReportManager>();
            services.AddScoped<IUrgencyService, UrgencyManager>();
            services.AddScoped<IJobService, JobManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IDocumentService, DocumentManager>();


            services.AddControllersWithViews();


            services.AddScoped<IJobDAL, EfJobRepository>();
            services.AddScoped<IReportDAL, EfReportRepository>();
            services.AddScoped<IUrgencyDAL, EfUrgencyRepository>();
            services.AddScoped<IAppUserDAL, EfAppUserRepository>();


            services.AddDbContext<ToDoContext>();
            
            services.AddIdentity<AppUser, AppRole>(opt=> { 
                opt.Password.RequiredUniqueChars = 0; 
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false; 
                opt.Password.RequireUppercase = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequiredLength = 1;
            })
                .AddEntityFrameworkStores<ToDoContext>();

            services.ConfigureApplicationCookie(opt => { 
                opt.Cookie.Name = "IsTakipCookie"; 
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict; 
                opt.Cookie.HttpOnly = true; opt.ExpireTimeSpan = TimeSpan.FromDays(20); 
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest; 
                opt.LoginPath = "/Home/Index"; 

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


           
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            IdentityInitializer.SeedData(userManager, roleManager).Wait();
            app.UseStaticFiles();
          

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"

                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
