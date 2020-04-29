using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelos;
using System.Collections.Generic;

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

            modelBuilder.Entity<CentroSalud>().HasData(
                new CentroSalud
                {
                    Id= 1,
                    Nombre = "Matias",
                    Telefono= 0294,
                    Direccion= "en la loma del culo",
                    HorarioAtencion= "no trabja nunca",
                    RestriccionEdad="ancianas"
                }) ;

            modelBuilder.Entity<Colectivo>().HasData(
                new Colectivo
                {
                    Id = 1,
                    Linea ="503"
                });

            modelBuilder.Entity<Especialidad>().HasData(
                new Especialidad
                {
                    Id = 1,
                    Nombre = "verdulero"
                });

            modelBuilder.Entity<PracticaDiagnostico>().HasData(
                new PracticaDiagnostico
                {
                    Id = 1,
                    Nombre = "prostata"
                });

            modelBuilder.Entity<ColectivoCentroSalud>().HasData(
                new ColectivoCentroSalud
                {
                    ColectivoId = 1,
                    CentroSaludId=1,
                });

            modelBuilder.Entity<EspecialidadCentroSalud>().HasData(
                new EspecialidadCentroSalud
                {
                    EspecialidadId = 1,
                    CentroSaludId = 1,
                });

            modelBuilder.Entity<PracticaDiagnosticoCentroSalud>().HasData(
                new PracticaDiagnosticoCentroSalud
                {
                    PracticaDiagnosticoId = 1,
                    CentroSaludId = 1,
                });
        }

    }
}
