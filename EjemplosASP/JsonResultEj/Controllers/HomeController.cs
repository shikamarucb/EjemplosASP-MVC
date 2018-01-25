using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonResultEj.Controllers
{
    public class HomeController : Controller
    {

        public JsonResult Index()
        {
            return Json(new List<Persona>() { new Persona() { Nombre = "Andres", edad = 20 },
                new Persona() { Nombre = "Andres", edad = 20 } },JsonRequestBehavior.AllowGet);

            return Json(new Persona() { Nombre = "Andres", edad = 20 },JsonRequestBehavior.AllowGet);

            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class Persona {
        public string Nombre { get; set; }
        public int edad { get; set; }
    }
}