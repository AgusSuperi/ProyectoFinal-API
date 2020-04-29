using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelos;

namespace ProyectoFinal.BD
{
    public class CentrosSaludContext : DbContext 
    {
        public DbSet<CentroSalud> CentrosSalud { get; set; }

        public DbSet<Colectivo> Colectivos { get; set; }

        public DbSet<ColectivoCentroSalud> ColectivosCentrosSalud { get; set; }

        public DbSet<Especialidad> Especialidades { get; set; }

        public DbSet<EspecialidadCentroSalud> EspecialidadesCentrosSalud { get; set; }

        public DbSet<PracticaDiagnostico> PracticasDiagnosticos { get; set; }

        public DbSet<PracticaDiagnosticoCentroSalud> PracticasDiagnosticoCentrosSalud { get; set; }

        public CentrosSaludContext(DbContextOptions<CentrosSaludContext> Options) : base(Options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ColectivoCentroSalud>()
                .HasKey(c => new { c.CentroSaludId, c.ColectivoId });

            modelBuilder.Entity<EspecialidadCentroSalud>()
                .HasKey(e => new { e.CentroSaludId, e.EspecialidadId });

            modelBuilder.Entity<PracticaDiagnosticoCentroSalud>()
                .HasKey(p => new { p.CentroSaludId, p.PracticaDiagnosticoId });
        }

    }
}
