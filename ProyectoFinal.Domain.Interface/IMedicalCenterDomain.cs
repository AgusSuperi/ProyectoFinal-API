using ProyectoFinal.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Interface
{
    public interface IMedicalCenterDomain
    {
        Task<IEnumerable<MedicalCenter>> GetAll();

        Task<MedicalCenter> GetById(int id);

        Task<IEnumerable<Speciality>> GetSpecialitiesById(int id);

        Task<IEnumerable<string>> GetNeighborhoods();
    }
}
