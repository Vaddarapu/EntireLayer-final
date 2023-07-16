using DataAccessLayer.Entities;
using DataAccessLayer.IRepositories;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using ServiceLayerorBL.IServices;
using ServiceLayerorBL.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EmployeDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("OneConnectionString")
));
builder.Services.AddScoped<IEmployeeService, EmployeService>();
builder.Services.AddScoped<IEmployeRepository,EmployeRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employe}/{action=Index}/{id?}");

app.Run();
