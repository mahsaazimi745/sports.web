using Microsoft.EntityFrameworkCore;
using SportsWeb.Application.Services;
using SportsWeb.CoreLayer.Interfaces;
using SportsWeb.Infrastructure.Data;
using SportsWeb.Infrastructure.Repositories;
using Umbraco.Core.Composing.CompositionExtensions;
using Umbraco.Core.Services;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Defaulttt");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Defaulttt")));

// Add services to the container.
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUserRepository, UserRepository>();


builder.Services.AddScoped<SportsWeb.CoreLayer.Interfaces.IUserService, UserService>();

builder.Services.AddControllers();
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

app.MapControllers();

app.Run();
