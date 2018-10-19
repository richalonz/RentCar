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
        [StringLength(200)]
        public string eslogan { get; set; }
        public int sucursal_principal_id { get; set; }
        [Required][StringLength(11)]
        public string telefono { get; set; }
        [StringLength(9)]
        public string rnc { get; set; }
        [Required] [StringLength(100)]
        public string email { get; set; }
        [StringLength(50)]
        public string cuenta_instagram { get; set; }
        [StringLength(50)]
        public string cuenta_twitter { get; set; }
        [StringLength(200)]
        public string pag_facebook { get; set; }
        public string ruta_carpeta_logo { get; set; } //para varios formatos de img
    }
}