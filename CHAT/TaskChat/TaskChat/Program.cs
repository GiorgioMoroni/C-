
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TaskChat.Models;
using TaskChat.Repos;
using TaskChat.Services;

namespace TaskChat
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

            builder.Services.AddAuthentication().AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "YourIssuer",
                    ValidAudience = "YourAudience",
                    IssuerSigningKey = new SymmetricSecurityKey
                    (
                        Encoding.UTF8.GetBytes("your_super_secret_key_your_super_secret_key")
                    )
                };
            });

            builder.Services.AddDbContext<TaskChatContext>(options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("UserDb")));

            builder.Services.AddScoped<UtenteRepo>();
            builder.Services.AddScoped<UtenteServ>();
            builder.Services.AddScoped<StanzaRepo>();
            builder.Services.AddScoped<StanzaServ>();
            builder.Services.AddScoped<MessaggioRepo>();
            builder.Services.AddScoped<MessaggioServ>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

#if DEBUG
            app.UseCors(options =>
            {
                options
                    .WithOrigins("*")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
#endif


            app.MapControllers();

            app.Run();
        }
    }
}
