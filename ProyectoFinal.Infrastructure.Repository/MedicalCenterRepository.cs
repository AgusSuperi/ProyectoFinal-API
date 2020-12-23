using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Infrastructure.Data;
using ProyectoFinal.Infrastructure.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Infrastructure.Repository
{
    public class MedicalCenterRepository : IMedicalCenterRepository
    {
        private readonly ProyectoFinalContext context;

        public MedicalCenterRepository(ProyectoFinalContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<MedicalCenter>> GetAll()
        {
            return await context.MedicalCenters.ToListAsync();
        }

        public async Task<MedicalCenter> GetById(int id)
        {
            return await context.MedicalCenters.FindAsync(id);
        }

        public async Task<IEnumerable<Speciality>> GetSpecialitiesById(int id)
        {
           var medicalCenter = await context.MedicalCenters.Include(m => m.Specialities).FirstOrDefaultAsync(m => m.Id == id);
            return medicalCenter.Specialities;
        }

        public async Task<IEnumerable<MedicalCenter>> GetByFilter(Filter filter)
        {
            var medicalCenters = await context.MedicalCenters
                .Include(m => m.Specialities)
                .Include(m => m.Neighborhood)
                .Where(m => (filter.Neighborhoods.Count > 0 ? filter.Neighborhoods.Contains(m.Neighborhood.Id) : true))
                .Where(m => (filter.OpeningHours.Count > 0 ? filter.OpeningHours.Contains(m.OpeningHours) : true))
                .Where(m => (filter.Specialities.Count > 0 ? m.Specialities.All(s => filter.Specialities.Contains(s.Id)) :true))
                .ToListAsync();

            return medicalCenters;
        }

        public async Task<IEnumerable<string>> GetNeighborhoods()
        {
            var neighborhoods = await context.MedicalCenters
                .Select(m => m.Neighborhood)
                .Distinct()
                .ToListAsync();

            return neighborhoods;
        }
    }
}
