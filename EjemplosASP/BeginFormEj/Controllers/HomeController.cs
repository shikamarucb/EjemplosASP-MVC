using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeginFormEj.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Persona persona)
        {
            ViewBag.visajes = persona.Nombre + persona.Edad;
            return View(persona);
        }

    }

    public class Persona {
        public int Edad { get; set; }
        public string Nombre { get; set; }
    }
}