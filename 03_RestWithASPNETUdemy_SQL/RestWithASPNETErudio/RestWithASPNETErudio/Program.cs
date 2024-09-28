using Microsoft.EntityFrameworkCore;
using RestWithASPNETErudio.Model.Context;
using RestWithASPNETErudio.Services;
using RestWithASPNETErudio.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 29))));

// Configure the HTTP request pipeline.

// Dependence
builder.Services.AddScoped<IPersonInterface, PersonServiceImplementation>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
