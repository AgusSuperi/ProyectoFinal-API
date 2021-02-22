using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Infrastructure.Data;
using ProyectoFinal.Infrastructure.Interface;
using ProyectoFinal.Transversal.Common;
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
            return medicalCenter.Specialities.OrderBy(s => s.Name);
        }

        public async Task<IEnumerable<MedicalCenter>> GetByFilter(Filter filter)
        {
            var medicalCenters = await context.MedicalCenters
                .Include(m => m.Specialities)
                .Where(m => (filter.Neighborhoods.Count == 0 || filter.Neighborhoods.Contains(m.Neighborhood)))
                .Where(m => (filter.OpeningHours == FilterOpeningHours.Until_14 || 
                    (filter.OpeningHours == FilterOpeningHours.Until_18 ? (OpeningHours.Until_18 == m.OpeningHours || 
                    OpeningHours.AllDay == m.OpeningHours) : OpeningHours.AllDay == m.OpeningHours)))
                .ToListAsync();

            if (filter.Specialities.Count != 0)
            {
                var result = new List<MedicalCenter>();

                foreach (var medicalCenter in medicalCenters)
                {
                    if (filter.Specialities.All(s => medicalCenter.Specialities.Any(s2 => s2.Name.Equals(s))))
                    {
                        result.Add(medicalCenter);
                    }
                }

                return result;
            }            

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
