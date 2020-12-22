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
    public class NeighborhoodApplication : INeighborhoodApplication
    {
        private readonly INeighborhoodDomain domain;
        private readonly IMapper mapper;

        public NeighborhoodApplication(INeighborhoodDomain domain, IMapper mapper)
        {
            this.domain = domain;
            this.mapper = mapper;
        }

        public async Task<Response<IEnumerable<NeighborhoodDTO>>> GetAll()
        {
            var response = new Response<IEnumerable<NeighborhoodDTO>>();
            try
            {
                var neighborhoods = await domain.GetAll();
                response.Data = mapper.Map<IEnumerable<NeighborhoodDTO>>(neighborhoods);
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
