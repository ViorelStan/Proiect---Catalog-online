using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;
using Swashbuckle.AspNetCore.SwaggerGen;
using Proiect___Catalog_online.Data;
using System.Reflection;
using Proiect___Catalog_online.Services;
using Proiect___Catalog_online.DTO;
using Proiect___Catalog_online.Models;
using Proiect___Catalog_online.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<StudentsRegistryDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentsDb"))
    );
builder.Services.AddScoped<StudentsService>();
builder.Services.AddScoped<AddressesService>();
builder.Services.AddScoped<MarksService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
