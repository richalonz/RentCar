using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RentCar_1.Models
{
    public class RentCarContext : DbContext
    {
        public RentCarContext()
            : base("DefaultConnection") { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Marcas> MarcasVehiculos { get; set; }
        public DbSet<CategoriaVehiculos> CatVehiculos { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<InfoPagoCliente> IPC { get; set; }
        public DbSet<Tarifario> Tarifarios { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Sucursales> Sucursales { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
    }
}