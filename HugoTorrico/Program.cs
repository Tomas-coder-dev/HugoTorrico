using Microsoft.EntityFrameworkCore;
using HugoTorrico.Models;

var builder = WebApplication.CreateBuilder(args);

// Register DbContext (solo cambié el nombre de la BD)
builder.Services.AddDbContext<StoreContext>(options =>
    options.UseSqlServer(@"Server=LAB1502-013\SQLEXPRESS;Database=StoreDB;Integrated Security=true;TrustServerCertificate=True;"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();