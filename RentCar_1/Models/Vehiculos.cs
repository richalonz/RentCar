using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class Vehiculos
    {
        public int id { get; set; }
        [Required][StringLength(30)]
        public string marca { get; set; }
        [Required][StringLength(50)]
        public string modelo { get; set; }
        [Required] [DisplayName("Año")]
        public int ano { get; set; } //año de fabricación
        [StringLength(40)]
        public string tipo_auto { get; set; } //sedan, coupé, etc
        [StringLength(512)]
        public string ruta_imagen { get; set; }  //ruta relativa (carpeta dentro del servidor). Se selecciona mediante cuadro de dialogo y se guarda en el servidor
        [Required] [Range(0.01,99999999.99)]
        public decimal precio_vehiculo { get; set; }
        [Required]
        public bool disponible { get; set; } //disponible, mantenimiento, etc
    }
}