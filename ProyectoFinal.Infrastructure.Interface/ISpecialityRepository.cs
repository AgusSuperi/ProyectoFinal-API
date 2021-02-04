using ProyectoFinal.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Infrastructure.Interface
{
    public interface ISpecialityRepository
    {
        Task<IEnumerable<string>> GetNames();

        Task<Speciality> GetById(int id);

        Task<IEnumerable<MedicalCenter>> GetMedicalCentersById(int id);
    }
}
