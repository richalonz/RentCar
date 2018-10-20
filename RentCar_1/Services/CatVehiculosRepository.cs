using RentCar_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentCar_1.Services
{
    public class CatVehiculosRepository
    {
        public List<CategoriaVehiculos> ObtenerTodos()
        {
            using (var db = new RentCarContext())
            {
                return db.CatVehiculos.ToList();
            }
        }

        internal void Crear (CategoriaVehiculos model)
        {
            using (var db = new RentCarContext())
            {
                db.CatVehiculos.Add(model);
                db.SaveChanges();
            }
        }
    }
}