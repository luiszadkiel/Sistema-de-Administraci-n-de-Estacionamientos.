using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace p2_FINAAL_parqueo.Context
{
    public class configuracionBD_Context : DbContext
    {
        public configuracionBD_Context(DbContextOptions<configuracionBD_Context> op) : base(op) { }

        //modelos
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Estacionamiento> Estacionamiento { get; set; }
        public DbSet<Espacio> Espacio { get; set; }
        public DbSet<Tiket> Tiket { get; set; }
        public DbSet<Tarifa> Tarifa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tiket>()
                .HasOne(t => t.Estacionamiento)
                .WithMany()
                .HasForeignKey(t => t.EstacionamientoID);

            modelBuilder.Entity<Tiket>()
                .HasOne(t => t.Vehiculo)
                .WithMany()
                .HasForeignKey(t => t.VehiculoID);

            modelBuilder.Entity<Tiket>()
                .HasOne(t => t.Espacio)
                .WithMany()
                .HasForeignKey(t => t.EspacioID);

            modelBuilder.Entity<Espacio>()
                .HasOne(e => e.Estacionamiento)
                .WithMany()
                .HasForeignKey(e => e.EstacionamientoID);

        }
    }
}
