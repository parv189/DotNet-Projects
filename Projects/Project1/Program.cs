using Microsoft.EntityFrameworkCore;
using Project1.Code.Interfaces;
using Project1.Code.SqlServer;
using Project1.Models;

namespace Project1
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
            builder.Services.AddDbContext<NaukriContext>(options =>
            {
                options.UseSqlServer("Server=PC0395\\MSSQL2019;Database=naukridatabase;" +
                    "Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");
            });
            builder.Services.AddTransient<ICompanyRepository, CompanyRepository>();
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