using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Domain.Entity;

namespace ProyectoFinal.Infrastructure.Data
{
    public class ProyectoFinalContext : DbContext
    {
        public DbSet<MedicalCenter> MedicalCenters { get; set; }

        public DbSet<Speciality> Specialities { get; set; }

        public ProyectoFinalContext(DbContextOptions<ProyectoFinalContext> Options) : base(Options) { }
    }
}
