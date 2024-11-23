using Microsoft.EntityFrameworkCore;
using Administración_Estacionamientos_.capa_entidades.models;
using Administración_Estacionamientos_.capa_negocio;

namespace Administración_Estacionamientos_.capa_datos.Context
{
    public class configuracionBD_Context : DbContext
    {
        public configuracionBD_Context(DbContextOptions<configuracionBD_Context> op) : base(op) { }

        //modelos
        public DbSet<administradores> administradores { get; set; }
        public DbSet<administar_vehiculos> TiposVehiculos { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Estacionamientos> Estacionamientos { get; set; }
        public DbSet<Espacios> Espacios { get; set; }
        public DbSet<Tiket> Tiket { get; set; }
        public DbSet<Tarifa> Tarifas { get; set; }
        public DbSet<vehiculosPermmitidos> vehiculos_permmitidos { get; set; }

    }
}
