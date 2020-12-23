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
    public class MedicalCenterApplication : IMedicalCenterApplication
    {
        private readonly IMedicalCenterDomain domain;
        private readonly IMapper mapper;

        public MedicalCenterApplication(IMedicalCenterDomain domain, IMapper mapper)
        {
            this.domain = domain;
            this.mapper = mapper;
        }

        public async Task<Response<IEnumerable<MedicalCenterDTO>>> GetAll()
        {
            var response = new Response<IEnumerable<MedicalCenterDTO>>();
            try
            {
                var medicalCenters = await domain.GetAll();
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

        public async Task<Response<MedicalCenterDTO>> GetById(int id)
        {
            var response = new Response<MedicalCenterDTO>();
            try
            {
                var medicalCenter = await domain.GetById(id);
                response.Data = mapper.Map<MedicalCenterDTO>(medicalCenter);
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

        public async Task<Response<IEnumerable<SpecialityDTO>>> GetSpecialitiesById(int id)
        {
            var response = new Response<IEnumerable<SpecialityDTO>>();
            try
            {
                var specialities = await domain.GetSpecialitiesById(id);
                response.Data = mapper.Map<IEnumerable<SpecialityDTO>>(specialities);
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

        public async Task<Response<IEnumerable<string>>> GetNeighborhoods()
        {
            var response = new Response<IEnumerable<string>>();
            try
            {
                response.Data = await domain.GetNeighborhoods();
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
