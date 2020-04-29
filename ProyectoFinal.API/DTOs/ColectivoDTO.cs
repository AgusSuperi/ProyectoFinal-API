using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.API.DTOs
{
    public class ColectivoDTO
    {
        public int Id { get; set; }

        [Required, StringLength(25)]
        public string Linea { get; set; }

    }
}
