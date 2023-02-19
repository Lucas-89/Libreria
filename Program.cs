using LibreriaDigital.Servicios;
using Microsoft.EntityFrameworkCore;
using LibreriaDigital.Modelos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<LibreriaDbContext>(
    options=>options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString"))
);

builder.Services.AddSingleton<ILibroServicio,LibrosServicio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
