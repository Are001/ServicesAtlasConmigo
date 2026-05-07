using AtlasLibraries.DBComandos;
using AtlasLibraries.Services;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<EjemploServices>();
builder.Services.AddScoped<UsuarioServices>();
builder.Services.AddScoped<UsuarioDBCommand>();

builder.Services.AddScoped<CategoriaServices>();
builder.Services.AddScoped<CategoriaDBCommand>();
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
