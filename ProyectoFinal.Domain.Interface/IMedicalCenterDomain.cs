using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Interface
{
    public interface IMedicalCenterDomain
    {
        Task<IEnumerable<MedicalCenter>> GetAll();

        Task<MedicalCenter> GetById(int id);

        Task<IEnumerable<Speciality>> GetSpecialitiesById(int id);

        Task<IEnumerable<MedicalCenter>> GetByFilter(Filter filter);

        Task<MedicalCenter> GetClosestByCoordinates(Coordinates coordinates);

        Task<IEnumerable<string>> GetNeighborhoods();

        IEnumerable<string> GetFilterOpeningHours();
    }
}
