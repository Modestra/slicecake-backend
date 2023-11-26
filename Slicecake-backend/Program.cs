using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Slice.Persistance;
using Slicecake_backend;
using Slicecake_backend.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDBContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("BaseConnect")));
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "0.0.1",
        Title = "SliceCake API",
        Description = "Backend для сервера"
    });
    var basePath = AppContext.BaseDirectory;
    var xmlPath = Path.Combine(basePath, "Slicecake-backend.xml");
    options.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(builder =>
    {
        builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();