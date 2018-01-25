using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HttpStatusCodeResultEj.Controllers
{
    public class HomeController : Controller
    {
        public HttpStatusCodeResult Index()
        {
            return new HttpStatusCodeResult(404, "Pagina no encontrada, ejemplo HttpStatusCodeResult");
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