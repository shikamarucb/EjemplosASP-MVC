using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QueryStringAction.Controllers
{
    public class HomeController : Controller
    {
        //Query String ej: nombre=felipe
        //tener cuidado con no pasar un tipo por valor, al no especificar un query string
        //cuando se llama la url, se envian valores null como parametros y no es posible asignar
        //null a un tipo por valor

        public ActionResult Index()
        {
            return View();
        }

        //Edad al ser un nullable no tiene problema al recibir un null
        public ActionResult About(string nombre, int? edad)
        {
            if(edad.HasValue)
                ViewBag.Message = "Your application description page. " + nombre + " "
                    + edad.Value;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}