
using ASP_Lez05_task_Nasa.Models;
using ASP_Lez05_task_Nasa.Repos;
using ASP_Lez05_task_Nasa.Services;
using Microsoft.EntityFrameworkCore;

namespace ASP_Lez05_task_Nasa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Importanti per la configurazione di Context e Repository
            builder.Services.AddDbContext<NasaContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")
                ));
            builder.Services.AddScoped<SistemaRepo>();
            builder.Services.AddScoped<OggettoCelesteRepo>();
            builder.Services.AddScoped<SistemaService>();
            builder.Services.AddScoped<OggettoCelesteService>();

            #endregion

            var app = builder.Build();

            app.UseCors(builder =>
                 builder
                 .WithOrigins("*")
                 .AllowAnyMethod()
                 .AllowAnyHeader());

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
