using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContentResultEj.Controllers
{
    public class HomeController : Controller
    {
        //Devuelve contenido definido por el usuario
        public ContentResult Index()
        {
            return Content("<b>Podemos devolver cualquier contenido como string</b>");
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