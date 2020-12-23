using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Entity
{
    public class Filter
    {
        public List<string> OpeningHours { get; set; }

        public List<int> Neighborhoods { get; set; }

        public List<int> Specialities { get; set; }
    }
}
