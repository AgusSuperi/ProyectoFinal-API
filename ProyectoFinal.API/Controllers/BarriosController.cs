using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.API.DTOs;
using ProyectoFinal.BD;

namespace ProyectoFinal.API.Controllers
{
    [Route("api/barrios")]
    [ApiController]
    public class BarriosController : ControllerBase
    {
        private readonly CentrosSaludContext _context;

        public BarriosController(CentrosSaludContext context)
        {
            _context = context;
        }

        // GET: api/barrios
        [HttpGet]
        public IEnumerable<string> GetBarrios()
        {
            HashSet<string> barrios = new HashSet<string>();

            foreach (var centroSalud in _context.CentrosSalud)
            {
                barrios.Add(centroSalud.Barrio);
            }

            var barriosOrdenados = barrios.ToList();
            barriosOrdenados.Sort();

            return barriosOrdenados;
        }
    }
}
