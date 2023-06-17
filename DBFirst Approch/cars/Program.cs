using cars.Models;
using Microsoft.EntityFrameworkCore;

namespace cars
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
            builder.Services.AddDbContext<MyPracticeContext>( opt =>
            {
                opt.UseSqlServer("Server=PC0404\\MSSQL2019;Database=MyPractice;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");
            });

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
