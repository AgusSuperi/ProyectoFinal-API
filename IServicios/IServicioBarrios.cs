using System;
using System.Collections.Generic;

namespace ProyectoFinal.IServicios
{
    public interface IServicioBarrios
    {
        public IEnumerable<string> GetBarrios();
    }
}
