using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class InfoPagoCliente
    {
        public int id { get; set; }
        public int cliente_id { get; set; }
        public string moneda { get; set; }
        [Required]
        public string metodo_pago { get; set; } //efectivo, tarjeta, cheque, etc.
    }
}