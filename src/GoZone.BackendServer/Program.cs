using FluentValidation.AspNetCore;
using GoZone.BackendServer.Data;
using GoZone.BackendServer.Data.Entities;
using GoZone.BackendServer.IdentityServer;
using GoZone.BackendServer.Services;
using GoZone.ViewModels.Systems;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;

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
    options.Events.RaiseInformationEvents = true;
    options.Events.RaiseFailureEvents = true;
    options.Events.RaiseSuccessEvents = true;
})
.AddInMemoryApiResources(Config.Apis)
.AddInMemoryClients(Config.Clients)
.AddInMemoryIdentityResources(Config.Ids)
.AddAspNetIdentity<AppUser>()
.AddDeveloperSigningCredential();
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
builder.Services.AddControllersWithViews()
    .AddFluentValidation(m => m.RegisterValidatorsFromAssemblyContaining<RoleVmValidator>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAuthentication()
   .AddLocalApi("Bearer", option =>
   {
       option.ExpectedScope = "api.gozone";
   });
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Bearer", policy =>
    {
        policy.AddAuthenticationSchemes("Bearer");
        policy.RequireAuthenticatedUser();
    });
});

builder.Services.AddRazorPages(options =>
{
    options.Conventions.AddAreaFolderRouteModelConvention("Identity", "/Account/", model =>
    {
        foreach (var selector in model.Selectors)
        {
            var attributeRouteModel = selector.AttributeRouteModel;
            attributeRouteModel.Order = -1;
            attributeRouteModel.Template = attributeRouteModel.Template.Remove(0, "Identity".Length);
        }
    });
});
builder.Services.AddTransient<DbInitializer>();
builder.Services.AddTransient<IEmailSender, EmailSenderService>();
builder.Services.AddSwaggerGen(m =>
{
    m.SwaggerDoc("v1", new OpenApiInfo { Title = "GoZone Api", Version = "v1" });
    m.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.OAuth2,
        Flows = new OpenApiOAuthFlows
        {
            Implicit = new OpenApiOAuthFlow
            {
                AuthorizationUrl = new Uri(builder.Configuration["AuthorityUrl"]+"/connect/authorize"),
                Scopes = new Dictionary<string, string> { { "api.gozone", "GoZone API" } }
            },
        },
    });
    m.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
            },
            new List<string>{ "api.gozone" }
        }
    });
});
var app = builder.Build();
// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseIdentityServer();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    endpoints.MapRazorPages();
});

app.UseSwagger();
app.UseSwaggerUI(m =>
{
    m.OAuthClientId("swagger");
    m.SwaggerEndpoint("/swagger/v1/swagger.json", "GoZone Api V1");
});

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
