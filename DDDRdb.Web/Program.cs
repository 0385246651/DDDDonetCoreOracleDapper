using DDDRdb.Infrastructure.Database;
using DDDRdb.Core.Interfaces;
using DDDRdb.Infrastructure.Repositories;


namespace DDDRdb.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Dapper Context
            builder.Services.AddSingleton<DapperContext>();

            // DI Repository
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}



//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllersWithViews();

//// Dapper Context
//builder.Services.AddSingleton<DapperContext>();

//// DI Repository
//builder.Services.AddScoped<IUserRepository, UserRepository>();

//var app = builder.Build();

//app.UseStaticFiles();
//app.MapDefaultControllerRoute();

//app.Run();