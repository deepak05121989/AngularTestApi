
using AngularTestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularTestApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            // Add services to the container.
            builder.Services.AddCors();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<TestDBContext>(opt =>
            opt.UseSqlServer(builder.Configuration.GetConnectionString("MediaItemConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}