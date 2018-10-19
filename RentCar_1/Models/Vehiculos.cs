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
        public string ruta_imagen { get; set; }
        [Required] [Range(0, 10)]
        public int no_puertas { get; set; }
        [Required] [Range(1, 100)]
        public int no_pasajeros { get; set; }
        [Range(1,30)]
        public int tipo_transmision { get; set; } //número de velocidades
        public bool ac_disponible { get; set; } //aire acondicionado
        [Required][StringLength(17)]
        public string no_chasis { get; set; }
        [Required][StringLength(7)]
        public string placa { get; set; }
        public bool bolsa_aire { get; set; } //si dispone o no
        [StringLength(10)]
        public string traccion { get; set; } //delantera, trasera, 4x4, etc
        [StringLength(10)]
        public string tipo_retrovisores { get; set; } //ajuste manual o automatico
        [StringLength(60)]
        public string detalles_radio { get; set; } //AM,FM,AUX,USB,CD,BT, etc
        [Range(0.01,9999999.99)]
        public float capacidad_combustible_gl { get; set; }
        [StringLength(15)]
        public string tipo_combustible { get; set; } //gasolina, gas, gasoil
        [Required] [Range(0.01,99999999.99)]
        public decimal precio_vehiculo { get; set; }
        [Required] [StringLength(20)]
        public string estado { get; set; } //disponible, mantenimiento, etc
        [Required]
        public int sucursal_id { get; set; }
        [StringLength(60)]
        public string ult_ubicacion_gps { get; set; } //coordenadas
    }
}