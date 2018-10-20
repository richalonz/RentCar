using RentCar_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentCar_1.Services
{
    public class VehiculosRepository
    {
        public List<Vehiculos> ObtenerTodos()
        {
            using (var db = new RentCarContext())
            {
                return db.Vehiculos.ToList();
            }
        }

        internal void Crear(Vehiculos model)
        {
            using (var db = new RentCarContext())
            {
                db.Vehiculos.Add(model);
                db.SaveChanges();
            }
        }
    }
}