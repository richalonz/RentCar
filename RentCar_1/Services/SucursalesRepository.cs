using RentCar_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentCar_1.Services
{
    public class SucursalesRepository
    {
        public List<Sucursales> ObtenerTodos()
        {
            using (var db = new RentCarContext())
            {
                return db.Sucursales.ToList();
            }
        }

        internal void Crear(Sucursales model)
        {
            using (var db = new RentCarContext())
            {
                db.Sucursales.Add(model);
                db.SaveChanges();
            }
        }
    }
}