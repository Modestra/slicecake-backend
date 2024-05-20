using System.Configuration;
using System.Text;
using Domain.Repositories;
using Domain.Repositories.IRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Slice.Persistance;
using Slicecake_backend;
using Slicecake_backend.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDBContext>(options => 
    options.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=terrarik22"));
builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();

//Авторизация
builder.Services.AddAuthentication();
builder.Services.AddAuthentication(scheme =>
    {
        scheme.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        scheme.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("this is my custom Secret key for authentication")),
            ValidateIssuerSigningKey = true
        };
    });

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
    //Bearer авторизация
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Необходимый ключ",
        Scheme = "Bearer",
        In = ParameterLocation.Header
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference()
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new List<string>()
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "CookingRecipe");
    });
}

//Авторизация
app.UseAuthentication();
app.UseAuthorization();

//Показать контроллеры
app.MapControllers();

//Запуск сервера
app.Run();

public class AuthOptions
{
    public const string ISSUER = "MyAuthServer"; // издатель токена
    public const string AUDIENCE = "MyAuthClient"; // потребитель токена
    const string KEY = "mysupersecret_secretkey!123";   // ключ для шифрации
    public static SymmetricSecurityKey GetSymmetricSecurityKey() => 
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
}