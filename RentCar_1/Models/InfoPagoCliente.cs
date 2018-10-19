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
        public string metodo_pago { get; set; }
        public string cuenta_paypal { get; set; }
        public string banco { get; set; }
        public string num_tarjeta { get; set; }
        public string fecha_exp { get; set; }
        public string cvs { get; set; }
        public string tipo_tarjeta { get; set; }
    }
}