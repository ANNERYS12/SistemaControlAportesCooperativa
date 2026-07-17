using Microsoft.EntityFrameworkCore;
using SistemaControlAportesCooperativa.Domain.Entities;

namespace SistemaControlAportesCooperativa.Infrastructure.Context 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Socio> Socios { get; set; }
        public DbSet<Aporte> Aportes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Socio>(entity =>
            {
                entity.Property(e => e.BalanceAportes)
                      .HasPrecision(18, 2);
            });

            modelBuilder.Entity<Aporte>(entity =>
            {
                entity.Property(e => e.Monto)
                      .HasPrecision(18, 2);
            });
        }
    }
}