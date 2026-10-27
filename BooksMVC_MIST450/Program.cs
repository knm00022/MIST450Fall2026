using Microsoft.EntityFrameworkCore;
namespace BooksMVC_MIST450.Data
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); //This makes the MVC framework available to the application

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); //talk to the configuration filr which is (appsettings.json) and bring in the the details of the connection string called DefualtConnection and save it as a variable called connectionString.

            builder.Services.AddDbContext<BooksDbContext>(options => options.UseSqlServer(connectionString)); //this is where we are telling the program to use the connection string that we defined in appsettings.json. //Tells the compiler to use DbContext file, along wirh SQLServer, and use the connection string that has beeen fetched in the previous step.

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