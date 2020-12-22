using ProyectoFinal.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Infrastructure.Interface
{
    public interface IMedicalCenterRepository
    {
        Task<IEnumerable<MedicalCenter>> GetAll();

        Task<MedicalCenter> GetById(int id);

        Task<IEnumerable<Speciality>> GetSpecialitiesById(int id);
    }
}
