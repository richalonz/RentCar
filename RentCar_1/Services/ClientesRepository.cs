using RentCar_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentCar_1.Services
{
    public class ClientesRepository
    {
        public List<Clientes> ObtenerTodos()
        {
            using (var db = new RentCarContext())
            {
                return db.Clientes.ToList();
            }
        }

        internal void Crear(Clientes model)
        {
            using (var db = new RentCarContext())
            {
                db.Clientes.Add(model);
                db.SaveChanges();
            }
        }
    }
}