using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileResultEj.Controllers
{
    public class HomeController : Controller
    {
        public FileResult Index()
        {
            var ruta = Server.MapPath("imagen.jpg");

            //Buscar mas MIME type aca:
            //https://developer.mozilla.org/es/docs/Web/HTTP/Basics_of_HTTP/MIME_types

            return File(ruta,"image/jpg","futuro.jpg");
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