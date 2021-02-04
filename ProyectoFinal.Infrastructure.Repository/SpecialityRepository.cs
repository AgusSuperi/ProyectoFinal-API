using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Infrastructure.Data;
using ProyectoFinal.Infrastructure.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Infrastructure.Repository
{
    public class SpecialityRepository : ISpecialityRepository
    {
        private readonly ProyectoFinalContext context;

        public SpecialityRepository(ProyectoFinalContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<string>> GetNames()
        {
            return await context.Specialities.OrderBy(s => s.Name).Select(s => s.Name).ToListAsync();
        }

        public async Task<Speciality> GetById(int id)
        {
            return await context.Specialities.FindAsync(id);
        }

        public async Task<IEnumerable<MedicalCenter>> GetMedicalCentersById(int id)
        {
            var speciality = await context.Specialities.Include(s => s.MedicalCenters).FirstOrDefaultAsync(s => s.Id == id);
            return speciality.MedicalCenters;
        }
    }
}
