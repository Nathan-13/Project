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
using Microsoft.EntityFrameworkCore;

using HMSystem;
using HMSystem.Models;
using HMSystem.Storage;

namespace HMSystemMvc
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
            services.AddControllersWithViews();
            services.AddRazorPages();

            string connectionString = "Host=isilo.db.elephantsql.com;Port=5432;Database=lcmsaopz;Username=lcmsaopz;Password=qx5TIaMMUVoOoKgRNwHK0KzDG-0u7B9W";
            services.AddDbContext<HospitalContext>(options => 
                options.UseNpgsql(connectionString, b => b.MigrationsAssembly("HMSystemMvc")));
            
            services.AddScoped<IStoreDoctor, DoctorStorageEF>();
            services.AddScoped<IStorePatient, PatientStorageEF>();
            services.AddScoped<IStoreBill, BillStorageEF>();
            services.AddScoped<IStoreRoom, RoomStorageEF>();
            services.AddScoped<HospitalSystem>();

            // services.AddOptions();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
             using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope()) {
                using (var context = serviceScope.ServiceProvider.GetService<HospitalContext>()) {
                    context.Database.Migrate();
                }
            }

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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
