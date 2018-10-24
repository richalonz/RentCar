using RentCar_1.Models;
using RentCar_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentCar_1.Controllers
{
    public class SucursalesController : Controller
    {
        private SucursalesRepository _repo;

        public SucursalesController()
        {
            _repo = new SucursalesRepository();
        }
        
        // GET: Sucursales
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }

        // GET: Sucursales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursales/Create
        [HttpPost]
        public ActionResult Create(Sucursales model)
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
            {  /*log o manejo de excepciones*/  }
                return View();
        }

        // GET: Sucursales/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sucursales/Edit/5
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

        // GET: Sucursales/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sucursales/Delete/5
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
