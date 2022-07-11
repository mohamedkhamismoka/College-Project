using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebApplication13.BL;
using WebApplication13.BL.Mapper;
using WebApplication13.BL.Reposatory;
using WebApplication13.BL.services;
using WebApplication13.DAL.Database;


namespace WebApplication13
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContextPool<DataBase>(opts => opts.UseSqlServer(Configuration.GetConnectionString("sharp")));

            //.AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            // .AddDataAnnotationsLocalization();
            //services.AddLocalization(opt => opt.ResourcesPath = "");
       
            services.AddScoped<IStudent,StudentRepo>();
            services.AddScoped<IDepartment, DepartmentRepo>();
            services.AddScoped<ITeacher, TeacherRepo>();
            services.AddScoped<ICourse, CourseRepo>();
            services.AddScoped<IPayment, PaymentRepo>();
            services.AddScoped<IstudentCourse, StudentCourseRepo>();
            services.AddScoped<Mailsender, sender>();
            services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));


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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


//            var supportedCultures = new[] {
//      new CultureInfo("ar-EG"),
//      new CultureInfo("en-US"),
//};


//            app.UseRequestLocalization(new RequestLocalizationOptions
//            {
//                DefaultRequestCulture = new RequestCulture("en-US"),
//                SupportedCultures = supportedCultures,
//                SupportedUICultures = supportedCultures,
//                RequestCultureProviders = new List<IRequestCultureProvider>
//                {
//                new QueryStringRequestCultureProvider(),
//                new CookieRequestCultureProvider()
//                }
//            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
