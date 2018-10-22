using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class Empresa
    {
        public int id { get; set; }
        [Required] [StringLength(100)]
        public string nombre_empresa { get; set; }
        public int sucursal_principal_id { get; set; }
        [Required][StringLength(11)]
        public string telefono { get; set; }
        [Required] [StringLength(100)]
        public string email { get; set; }
    }
}