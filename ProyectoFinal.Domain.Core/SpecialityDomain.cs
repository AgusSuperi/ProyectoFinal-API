using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Domain.Interface;
using ProyectoFinal.Infrastructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Core
{
    public class SpecialityDomain : ISpecialityDomain
    {
        private readonly ISpecialityRepository repository;

        public SpecialityDomain(ISpecialityRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Speciality>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Speciality> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<IEnumerable<MedicalCenter>> GetMedicalCentersById(int id)
        {
            return await repository.GetMedicalCentersById(id);
        }
    }
}
