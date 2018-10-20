using RentCar_1.Models;
using RentCar_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentCar_1.Controllers
{
    public class MarcasController : Controller
    {
        private MarcasRepository _repo;

        public MarcasController()
        {
            _repo = new MarcasRepository();
        }

        // GET: Marcas
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }

        // GET: Marcas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marcas/Create
        [HttpPost]
        public ActionResult Create(Marcas model)
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

        // GET: Marcas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Marcas/Edit/5
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

        // GET: Marcas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Marcas/Delete/5
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
