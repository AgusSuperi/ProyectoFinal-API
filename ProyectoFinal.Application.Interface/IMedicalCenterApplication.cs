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

        Task<Response<IEnumerable<MedicalCenterDTO>>> GetByFilter(Filter filter);

        Task<Response<MedicalCenterDTO>> GetClosestByCoordinates(Coordinates coordinates);

        Task<Response<IEnumerable<string>>> GetNeighborhoods();

        Response<IEnumerable<string>> GetFilterOpeningHours();
    }
}
