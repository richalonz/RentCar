using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class Marcas
    {
        public int id { get; set; }
        [Required] [StringLength(50)]
        public string nombre_marca { get; set; }
    }
}