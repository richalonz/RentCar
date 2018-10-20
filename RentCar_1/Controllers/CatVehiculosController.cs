using RentCar_1.Models;
using RentCar_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentCar_1.Controllers
{
    public class CatVehiculosController : Controller
    {
        private CatVehiculosRepository _repo;

        public CatVehiculosController()
        {
            _repo = new CatVehiculosRepository();
        }
        
        // GET: CatVehiculos
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }

        // GET: CatVehiculos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatVehiculos/Create
        [HttpPost]
        public ActionResult Create(CategoriaVehiculos model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.Crear(model);
                    return RedirectToAction("Index");
                }

            }
            catch
            {
            }
                return View();
        }

        // GET: CatVehiculos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CatVehiculos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CatVehiculos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CatVehiculos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
