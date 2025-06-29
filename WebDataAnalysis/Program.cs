using Microsoft.EntityFrameworkCore;
using WebDataAnalysis.Application.Interfaces;
using WebDataAnalysis.Domain.Interfaces;
using WebDataAnalysis.Domain.Interfaces.Bases;
using WebDataAnalysis.Infrastructure.Data;
using WebDataAnalysis.Infrastructure.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//ConnectionString
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<WebDataAnalysisDbContext>(options =>
{
    options.UseNpgsql(connectionString, x => x.MigrationsAssembly("WebDataAnalysis.Infrastructure"));
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IDeviceMappingRepository, DeviceMappingRepository>();
builder.Services.AddScoped<IDeviceParametersRepository, DeviceParametersRepository>();
builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();
builder.Services.AddScoped<IFindDeviceRepository, FindDeviceRepository>();
builder.Services.AddScoped<IParametersRepository, ParameteresRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IStatusDeviceRepository, StatusDeviceRepository>();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();