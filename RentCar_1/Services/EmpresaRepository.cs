using RentCar_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentCar_1.Services
{
    public class EmpresaRepository
    {
        public List<Empresa> ObtenerTodos()
        {
            using (var db = new RentCarContext())
            {
                return db.Empresa.ToList();
            }
        }

        internal  void Crear(Empresa model)
        {
            using (var db = new RentCarContext())
            {
                db.Empresa.Add(model);
                db.SaveChanges();
            }
        }

        //editar
    }
}