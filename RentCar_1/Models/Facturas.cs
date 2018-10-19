using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class Facturas
    {
        public int id { get; set; }
        [Required]
        public int vehiculo_id { get; set; }
        [Required]
        public int cliente_id { get; set; }
        [Required]
        public int sucursal_id { get; set; }
        [Required]
        public int usuario_id { get; set; }
        public DateTime fecha_hora_factura { get; set; }
        [StringLength(19)]
        public string nfc { get; set; }
        public string moneda { get; set; }
        [Required]
        public int detalle_factura_id { get; set; }
        [Required]
        public decimal costo_total { get; set; } //sumatoria de los detalles de fact
        [Required]
        public decimal valor_impuesto { get; set; } //calc de porc x costo total
        [Required]
        public decimal total { get; set; }
    }
}