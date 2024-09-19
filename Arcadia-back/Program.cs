using Arcadia_back.models;
using Arcadia_back.Repositories;
using ArcadiaBack;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Connection to Database
builder.Services.AddDbContext<AppDbContext>(options =>
{
    if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
    {
        options.UseInMemoryDatabase("Arcadia_Database");
    }
    else
    {
        options.UseSqlServer(configuration.GetConnectionString("Value"));
    }
});

// User Identity configuration     
builder.Services.AddIdentity<User, IdentityRole>(
    options =>
    {
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 6;
        options.User.RequireUniqueEmail = true;
    })
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/";
    options.LogoutPath = "/";
    options.AccessDeniedPath = "/";
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
    options.Cookie.HttpOnly = true;
    options.Cookie.SameSite = SameSiteMode.None;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.SlidingExpiration = true;
});

builder.Services.AddAuthorization();

// Repositories
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<IHabitatRepository, HabitatRepository>();

// Cors policy
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins(configuration["AllowedOrigin"] ?? throw new Exception("There is no value for the Allowed Hosts parameter"))
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
        }
    );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles(); // Enables static file serving

string assetsPath = Path.Combine(Directory.GetCurrentDirectory(), "assets");
// Check if the directory exists, if not, create it
if (!Directory.Exists(assetsPath))
{
    Directory.CreateDirectory(assetsPath);
}
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(assetsPath),
    RequestPath = "/assets"
});

/// Server endpoints
// Login/Logout 
app.MapAccountEndpoints();

// User
app.MapHomepageEndpoints();
app.MapHabitatpageEndpoints();

// Admin
app.MapAnimalEndpoints();
app.MapHabitatEndpoints();
app.MapServiceEndpoints();
app.MapTestimonyEndpoints();
app.MapContactEndpoints();
app.MapUserEndpoints();

app.Run();