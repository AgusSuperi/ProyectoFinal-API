using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Domain.Interface;
using ProyectoFinal.Infrastructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Core
{
    public class MedicalCenterDomain : IMedicalCenterDomain
    {
        private readonly IMedicalCenterRepository repository;

        public MedicalCenterDomain(IMedicalCenterRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<MedicalCenter>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<MedicalCenter> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<IEnumerable<Speciality>> GetSpecialitiesById(int id)
        {
            return await repository.GetSpecialitiesById(id);
        }

        public async Task<IEnumerable<string>> GetNeighborhoods()
        {
            return await repository.GetNeighborhood();
        }
    }
}
