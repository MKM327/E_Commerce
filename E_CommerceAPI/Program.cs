using E_CommerceAPI.Contexts;
using E_CommerceAPI.Data_Access.Login_Data_Access;
using Microsoft.EntityFrameworkCore;

namespace TestAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ECommerceContext>(options =>
                options.UseSqlServer(
                    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=E_Commerce;Integrated Security=True;"));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IECommerceDal, ECommerceDal>();
            builder.Services.AddSingleton<IEFLoginDal, EFLoginDal>();
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
                builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}