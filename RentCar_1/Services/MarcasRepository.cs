using RentCar_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentCar_1.Services
{
    public class MarcasRepository
    {
        public List<Marcas> ObtenerTodos()
        {
            using (var db = new RentCarContext())
            {
                return db.MarcasVehiculos.ToList();
            }
        }

        internal void Crear(Marcas model)
        {
            using (var db = new RentCarContext())
            {
                db.MarcasVehiculos.Add(model);
                db.SaveChanges();
            }
        }
    }
}