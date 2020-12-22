using ProyectoFinal.Application.DTO;
using ProyectoFinal.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Interface
{
    public interface IMedicalCenterApplication
    {
        Task<Response<IEnumerable<MedicalCenterDTO>>> GetAll();

        Task<Response<MedicalCenterDTO>> GetById(int id);

        Task<Response<IEnumerable<SpecialityDTO>>> GetSpecialitiesById(int id);
    }
}
