using ASP_WEB_Lez02_Task_Impiegati.Models;
using ASP_WEB_Lez02_Task_Impiegati.Repository;
using ASP_WEB_Lez02_Task_Impiegati.Services;
using Microsoft.EntityFrameworkCore;

namespace ASP_WEB_Lez02_Task_Impiegati
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<TaskImpiegatiContext>(
                options => options.UseSqlServer(
                    builder.Configuration.GetConnectionString("Locale")
                    )
                );

            builder.Services.AddScoped<ImpiegatoRepo>();
            builder.Services.AddScoped<ImpiegatoService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Lista}/{id?}");

            app.Run();
        }
    }
}
