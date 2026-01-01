using Artgallery.Models;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;

namespace Artgallery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Services
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<UserContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("conn")));

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            var contentTypeProvider = new FileExtensionContentTypeProvider();
            contentTypeProvider.Mappings[".avif"] = "image/avif";

            app.UseStaticFiles(new StaticFileOptions
            {
                ContentTypeProvider = contentTypeProvider
            });

            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
