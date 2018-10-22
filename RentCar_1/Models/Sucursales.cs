using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class Sucursales
    {
        public int id { get; set; }
        [Required] [StringLength(30)]
        public string nombre_sucursal { get; set; }
        [Required] [StringLength(60)]
        public string ubicacion_gps { get; set; } //para mapas
        [Required] [StringLength(150)]
        public string direccion { get; set; }
        [StringLength(11)]
        public string telefon_directo { get; set; } //si existe
        [Range(0000,99999)]
        public int ext_telefonica { get; set; }
    }
}