using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBagDataEj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Parametros que se envian a la vista
            ViewBag.mensaje = "Hola mundo";
            ViewBag.fecha = new DateTime();
            ViewData["numero"] = 30;
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
}