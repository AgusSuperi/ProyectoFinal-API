using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Domain.Interface;
using ProyectoFinal.Infrastructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Core
{
    public class NeighborhoodDomain : INeighborhoodDomain
    {
        private readonly INeighborhoodRepository repository;

        public NeighborhoodDomain(INeighborhoodRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Neighborhood>> GetAll()
        {
            return await repository.GetAll();
        }
    }
}
