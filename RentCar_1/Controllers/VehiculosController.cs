using RentCar_1.Models;
using RentCar_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentCar_1.Controllers
{
    public class VehiculosController : Controller
    {
        private VehiculosRepository _repo;
        

        public VehiculosController()
        {
            _repo = new VehiculosRepository();
        }
        
        // GET: Vehiculos
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }

        public ActionResult MostrarVehiculos()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }

        // GET: Vehiculos/Create
        public ActionResult Create()
        {
            List<Marcas> lMarcas = new List<Marcas>();
            using (var db = new RentCarContext())
            {
                lMarcas = db.MarcasVehiculos.ToList();
                ViewBag.listaMarcas = lMarcas;
            }

            List<CategoriaVehiculos> lCatVehiculos = new List<CategoriaVehiculos>();
            using (var db = new RentCarContext())
            {
                lCatVehiculos = db.CatVehiculos.ToList();
                ViewBag.listaCatVehiculos = lCatVehiculos;
            }
            return View();
        }

        // POST: Vehiculos/Create
        [HttpPost]
        public ActionResult Create(Vehiculos model)
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

        // GET: Vehiculos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vehiculos/Edit/5
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

        // GET: Vehiculos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vehiculos/Delete/5
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

        //Clase para mostrar Macas en DropDownList
        [HttpGet]
        public ActionResult Enroll()
        {
            List<Marcas> lMarcas = new List<Marcas>();
            using (var db = new RentCarContext())
            {
                lMarcas = db.MarcasVehiculos.ToList();
                ViewBag.listaMarcas = lMarcas;
            }

            List<CategoriaVehiculos> lCatVehiculos = new List<CategoriaVehiculos>();
            using (var db = new RentCarContext())
            {
                lCatVehiculos = db.CatVehiculos.ToList();
                ViewBag.listaCatVehiculos = lCatVehiculos;
            }
            return View();
        }
    }
}