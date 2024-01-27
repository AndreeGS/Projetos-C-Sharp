using Challenge_Back_End.Data;
using Challenge_Back_End.Repositorio.IRepositorio;
using Challenge_Back_End.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace Challenge_Back_End
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

            builder.Services.AddEntityFrameworkSqlServer()
              .AddDbContext<DataContext>(
                  options => options.UseSqlServer(builder.Configuration.GetConnectionString("dafaultConnection"))
              );

            builder.Services.AddScoped<IPlanetaRepositorio, PlanetaRepositorio>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}