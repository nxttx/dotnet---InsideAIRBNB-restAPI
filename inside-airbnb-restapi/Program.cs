using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using WebApplication1.Models;
using WebApplication1.Repository;
using WebApplication1.Cache;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

String applicationConnectionString =
    // "Server=localhost;Database=AIRBNB;User Id=sa;password=MSSQL_server;Trusted_Connection=False";
    "Server=63128insideairbnb.database.windows.net;Database=AIRBNB;User Id=airbnbAdmin;password=Insideairbnb!;Trusted_Connection=False";

builder.Services.AddDbContext<AIRBNBContext>(options =>
    options.UseSqlServer(applicationConnectionString));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("AzureRedisConnection");
});

builder.Services.AddScoped<INeighbourhoodsRepository, NeighbourhoodsRepository>();
builder.Services.AddScoped<IListingsRepository, ListingRepository>();

builder.Services.AddSingleton<IResponseCacheService, ResponseCacheService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//serve static files
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"))
});
// end serve static files

app.UseHttpsRedirection();

app.UseAuthorization();

// Middleware voor response header config.
// kan ook via web.config
//
app.Use(async (context, next)=>
{
    context.Response.Headers.Add("X-Frame-Options", "Deny");

    //CSP response header configuratie tegen XSS en clickjacking
    //https://content-security-policy.com 
    // starter polecy pakken en die later aanpassen.
    context.Response.Headers.Add("Content-Security-Policy", "default-src 'self' https://fonts.gstatic.com; script-src 'self'; connect-src 'self'; img-src 'self'; style-src 'self' https://cdnjs.cloudflare.com https://fonts.googleapis.com https://api.mapbox.com;base-uri 'self';form-action 'self'; frame-ancestors: 'none';");
    context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
    await next();
});

app.MapControllers();

app.Run();
