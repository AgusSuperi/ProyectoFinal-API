using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.BD
{
    public class CentrosSaludContext : DbContext 
    {
        public DbSet<CentroSalud> CentrosSalud { get; set; }

        public DbSet<Especialidad> Especialidades { get; set; }

        public DbSet<EspecialidadCentroSalud> EspecialidadesCentrosSalud { get; set; }

        public CentrosSaludContext(DbContextOptions<CentrosSaludContext> Options) : base(Options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EspecialidadCentroSalud>()
                .HasKey(e => new { e.CentroSaludId, e.EspecialidadId });
            modelBuilder.Seed();
        }

    }
}
