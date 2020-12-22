using ProyectoFinal.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Interface
{
    public interface INeighborhoodDomain
    {
        Task<IEnumerable<Neighborhood>> GetAll();
    }
}
