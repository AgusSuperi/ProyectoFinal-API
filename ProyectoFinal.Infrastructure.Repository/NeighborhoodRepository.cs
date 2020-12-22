using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Domain.Entity;
using ProyectoFinal.Infrastructure.Data;
using ProyectoFinal.Infrastructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Infrastructure.Repository
{
    public class NeighborhoodRepository : INeighborhoodRepository
    {
        private readonly ProyectoFinalContext context;

        public NeighborhoodRepository(ProyectoFinalContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Neighborhood>> GetAll()
        {
            return await context.Neighborhoods.ToListAsync();
        }
    }
}
