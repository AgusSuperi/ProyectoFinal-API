using ProyectoFinal.Application.DTO;
using ProyectoFinal.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Interface
{
    public interface INeighborhoodApplication
    {
        Task<Response<IEnumerable<NeighborhoodDTO>>> GetAll();
    }
}
