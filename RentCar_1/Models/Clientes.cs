using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class Clientes
    {
        public int id { get; set; }
        [Required] [StringLength(50)]
        public string nombres { get; set; }
        [Required] [StringLength(50)]
        public string apellidos { get; set; }
        [StringLength(100)]
        public string email { get; set; }
        [StringLength(60)]
        public string contrasena { get; set; }
        [Required]
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_registro { get; set; }
        [Required] [StringLength(20)]
        public string no_doc_legal { get; set; } 
        [Required] [StringLength(10)]
        public string tipo_doc { get; set; } //cedula, pasaporte
        [Required] [StringLength(20)]
        public string no_licencia_conduc { get; set; }
        [StringLength(20)]
        public string nacionalidad { get; set; }
        public int info_pago_id { get; set; } //relacionado a tabla de info pagos
    }
}