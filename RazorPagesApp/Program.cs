using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;
using RazorPagesApp.Repository;

var builder = WebApplication.CreateBuilder(args);
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<StudentContext>(options => options.UseSqlServer(connection));
builder.Services.AddRazorPages();

builder.Services.AddScoped<IRepository, StudentRepository>();

var app = builder.Build();
app.UseStaticFiles();
app.MapRazorPages();
app.Run();