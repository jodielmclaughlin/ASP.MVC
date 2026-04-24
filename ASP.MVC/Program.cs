using ASP.MVC.Models;
using ASP.MVC.Services;
using Microsoft.AspNetCore.Mvc;
namespace ASP.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddScoped<AuthorService>();
            builder.Services.AddScoped<AuthorsModel>();
            builder.Services.AddScoped<BooksService>();
            builder.Services.AddScoped<BooksModel>();

            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapControllers();
            });

            app.Run();
        }
    }
}
