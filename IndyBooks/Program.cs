using Microsoft.EntityFrameworkCore;
using IndyBooks.Services;

var builder = WebApplication.CreateBuilder(args);

//Enable MVC and DIJ Services for this application
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<Repository>(); //TODO: Add the Repository Service to the DI Container
//TODO: Initialize the DBC Service and add it to the DI Container
var connection = builder.Configuration.GetConnectionString("IndyBooks-Sqlite");
builder.Services.AddDbContext<IndyBooksDataContext>(options =>
    options.UseSqlite(connection));

var app = builder.Build();


/* Middleware in the HTTP Request Pipeline
 */

if (app.Environment.IsDevelopment())
{
    app.InitializeDb();    //custom extension method to seed the DB
}

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}",
    defaults: new
    {
        controller = "Admin",
        action = "Search"
    });

app.Run();
