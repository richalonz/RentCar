using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class Usuarios
    {
        public int id { get; set; }
        [StringLength(20)]
        public string nombre_usuario { get; set; }
        [Required] [StringLength(30)]
        public string nombres { get; set; }
        [Required] [StringLength(30)]
        public string apellidos { get; set; }
        [Required] [StringLength(100)]
        public string email { get; set; }
        [Required]
        public DateTime fecha_nacimiento { get; set; }
        [Required]
        public DateTime fecha_registro { get; set; }
        [Required] [StringLength(50)]
        public string contrasena { get; set; }
        [Required]
        public int sucursal_id { get; set; } //donde fue registrado y pertenece
        [Required]
        public bool inactivo { get; set; } //trabajando actualmente
        [StringLength(30)]
        public string razon_inactivo { get; set; }
    }
}