using AutoMapper;
using ProyectoFinal.Application.DTO;
using ProyectoFinal.Application.Interface;
using ProyectoFinal.Domain.Interface;
using ProyectoFinal.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Main
{
    public class SpecialityApplication : ISpecialityApplication
    {
        private readonly ISpecialityDomain domain;
        private readonly IMapper mapper;

        public SpecialityApplication(ISpecialityDomain domain, IMapper mapper)
        {
            this.domain = domain;
            this.mapper = mapper;
        }

        public async Task<Response<IEnumerable<string>>> GetNames()
        {
            var response = new Response<IEnumerable<string>>();
            try
            {
                response.Data = await domain.GetNames();
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<SpecialityDTO>> GetById(int id)
        {
            var response = new Response<SpecialityDTO>();
            try
            {
                var speciality = await domain.GetById(id);
                response.Data = mapper.Map<SpecialityDTO>(speciality);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<IEnumerable<MedicalCenterDTO>>> GetMedicalCentersById(int id)
        {
            var response = new Response<IEnumerable<MedicalCenterDTO>>();
            try
            {
                var medicalCenters = await domain.GetMedicalCentersById(id);
                response.Data = mapper.Map<IEnumerable<MedicalCenterDTO>>(medicalCenters);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
    }
}
