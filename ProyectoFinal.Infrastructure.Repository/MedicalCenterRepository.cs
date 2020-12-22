using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Infrastructure.Data;
using ProyectoFinal.Infrastructure.Interface;
using System.Collections.Generic;
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
            var medicalCenter = await GetById(id);
            return medicalCenter.Specialities;
        }
    }
}
