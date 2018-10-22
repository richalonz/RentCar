using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class Tarifario
    {
        public int id { get; set; }
        [Required] [StringLength(20)]
        public string moneda { get; set; }
        [Required]
        public DateTime fecha_tarifario { get; set; } //fecha de valores en tabla. Para logs, evitar fraude
        [Range(0.01,100.00)]
        public decimal porc_beneficio { get; set; } //tasa de beneficio empresa
        [Range(0.01, 100.00)]
        public decimal porc_impuesto { get; set; }
        [Range(0.01, 100.00)]
        public decimal porc_seguro { get; set; }
        [Range(0.01,999999.99)]
        public decimal costo_mantenimiento { get; set; }
        [Range(0.01, 999999.99)]
        public decimal costo_gl_combustible { get; set; } //galon combustible
        [Range(0.01, 999999.99)]
        public decimal costo_srv_chofer { get; set; } //servicio chofer
    }
}