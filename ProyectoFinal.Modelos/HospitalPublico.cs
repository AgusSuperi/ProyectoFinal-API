﻿using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelos
{
    public class HospitalPublico
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Nombre { get; set; }

        [Required, StringLength(80)]
        public string Telefono { get; set; }

        [Required, StringLength(80)]
        public string Direccion { get; set; }

        [Required, StringLength(100)]
        public string URLPagina{ get; set; }

        [Required, StringLength(250)]
        public string Restriccion { get; set; }

        [Required, StringLength(200)]
        public string ImagenURL { get; set; }
    }
}
