using Administración_Estacionamientos.capa_negocio.interfaz;
using Administración_Estacionamientos_.capa_datos.Context;
using Administración_Estacionamientos_.capa_negocio.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuración de servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar DbContext antes de construir la app
builder.Services.AddDbContext<configuracionBD_Context>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("AppConnection"))
);

builder.Services.AddScoped(typeof(IRepository<>), typeof(RepositoryServices<>));

var app = builder.Build();

// Configuración del pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // Si no usas HTTPS, comenta esta línea
app.UseAuthorization();
app.MapControllers();

app.Run();

