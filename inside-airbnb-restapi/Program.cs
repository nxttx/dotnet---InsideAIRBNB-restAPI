using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

String applicationConnectionString =
    "Server=localhost;Database=AIRBNB;User Id=sa;password=MSSQL_server;Trusted_Connection=False";
builder.Services.AddDbContext<AIRBNBContext>(options =>
    options.UseSqlServer(applicationConnectionString));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//Middleware voor response header config.
// kan ook via web.config
//
app.Use(async (context, next)=>
{
    context.Response.Headers.Add("X-Frame-Options", "Deny");

    //CSP response header configuratie tegen XSS en clickjacking
    //https://content-security-policy.com 
    // starter polecy pakken en die later aanpassen.
    context.Response.Headers.Add("Content-Security-Policy", "default-src 'none'; script-src 'none'; connect-src 'self'; img-src 'self'; style-src 'self';base-uri 'self';form-action 'self'; frame-ancestors: 'none';");



    context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
    await next();
});



app.MapControllers();

app.Run();
