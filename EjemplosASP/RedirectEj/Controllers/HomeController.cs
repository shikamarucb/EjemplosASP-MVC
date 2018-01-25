using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedirectEj.Controllers
{
    public class HomeController : Controller
    {

        public RedirectResult Index()
        {
            return Redirect("https://github.com/shikamarucb/EjemplosASP-MVC");
        }

        public RedirectToRouteResult About()
        {
            return RedirectToAction("Index", "Home");
        }

        public RedirectToRouteResult Contact()
        {
            return RedirectToRoute("miRuta");
        }

        public ActionResult Ruta()
        {
            return View("About");
        }
    }
}