using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Domain.Interface;
using ProyectoFinal.Infrastructure.Interface;
using ProyectoFinal.Transversal.Common;
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

        public async Task<IEnumerable<MedicalCenter>> GetByFilter(Filter filter)
        {
            return await repository.GetByFilter(filter);
        }

        public async Task<MedicalCenter> GetClosestByCoordinates(Coordinates coordinates)
        {
            return await repository.GetClosestByCoordinates(coordinates);
        }

        public async Task<IEnumerable<string>> GetNeighborhoods()
        {
            return await repository.GetNeighborhoods();
        }

        public IEnumerable<string> GetFilterOpeningHours()
        {
            return FilterOpeningHours.Get();
        }
    }
}
