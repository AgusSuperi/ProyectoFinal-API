using ProyectoFinal.Application.DTO;
using ProyectoFinal.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Interface
{
    public interface ISpecialityApplication
    {
        Task<Response<IEnumerable<SpecialityDTO>>> GetAll();

        Task<Response<SpecialityDTO>> GetById(int id);

        Task<Response<IEnumerable<MedicalCenterDTO>>> GetMedicalCentersById(int id);
    }
}
