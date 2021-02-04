using ProyectoFinal.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Interface
{
    public interface ISpecialityDomain
    {
        Task<IEnumerable<string>> GetNames();

        Task<Speciality> GetById(int id);

        Task<IEnumerable<MedicalCenter>> GetMedicalCentersById(int id);
    }
}
