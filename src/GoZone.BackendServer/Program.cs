using FluentValidation.AspNetCore;
using GoZone.BackendServer.Data;
using GoZone.BackendServer.Data.Entities;
using GoZone.ViewModels.Systems;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Serilog;
using System;

Log.Logger = new LoggerConfiguration()
                            .Enrich.FromLogContext()
                            .WriteTo.Console()
                            .CreateLogger();
var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog();

//1. Setup entity framework
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

//2. Setup idetntity
builder.Services.AddIdentity<AppUser, IdentityRole>()
               .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddIdentityServer(options =>
{
    options.Events.RaiseErrorEvents = true;
});
builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;

    // Lockout settings
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
    options.Lockout.MaxFailedAccessAttempts = 10;

    // User settings
    options.User.RequireUniqueEmail = true;

    options.SignIn.RequireConfirmedAccount = true;
});

// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation(m => m.RegisterValidatorsFromAssemblyContaining<RoleVmValidator>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(m =>
{
    m.SwaggerDoc("v1", new OpenApiInfo { Title = "GoZone Api", Version = "v1" });
});
builder.Services.AddTransient<DbInitializer>();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(m =>
    {
        m.SwaggerEndpoint("/swagger/v1/swagger.json", "GoZone Api V1");
    });
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
//app.UseRouting();
//app.MapRazorPages();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        Log.Information("Seeding data...");
        var dbInitializer = services.GetService<DbInitializer>();
        dbInitializer.Seed().Wait();
    }
    catch (Exception ex)
    {
        var logger = services.GetService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding the database");
    }
}
app.Run();
