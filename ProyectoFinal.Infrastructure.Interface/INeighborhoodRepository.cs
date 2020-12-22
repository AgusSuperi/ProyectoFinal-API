using ProyectoFinal.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Infrastructure.Interface
{
    public interface INeighborhoodRepository
    {
        Task<IEnumerable<Neighborhood>> GetAll();
    }
}
