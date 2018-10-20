﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class CategoriaVehiculos
    {
        public int id { get; set; }
        [Required] [StringLength(50)] [DisplayName("Nombre Categoría")]
        public string nombre_cat { get; set; }
    }
}