using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Display_y_DisplayTemplates.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.cadena = "Cadena de caracteres";
            char[] nombres = { 'A','n','d'};
            ViewBag.persona = new Persona() {
                Nombre = new String(nombres),
                Edad = 23,
                Empleado = true,
                Nacimiento = new DateTime(1994, 12, 15)
            };
            return View();
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
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public bool Empleado { get; set; }
        public DateTime? Nacimiento { get; set; }
    }
}