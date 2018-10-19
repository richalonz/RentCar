using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentCar_1.Controllers
{
    public class VehiculosController : Controller
    {
        // GET: Vehiculos
        public ActionResult Index()
        {
            return View();
        }
    }
}