using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Servicios;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        //Retorna un archivo
        //Permite al usuario descargar un archivo
        public FileResult Archivo() {
            string ruta = Server.MapPath("/Archivos/meme2.jpg");
            return File(ruta, "image/jpeg", "Momazo");
        }

        //Retorna un codigo de estado HTTP
        public HttpStatusCodeResult HttpResultado() {

            return new HttpStatusCodeResult(404);
        }

        //redirecciona a una ruta diferente
        public RedirectToRouteResult resultadoRuta2() {
            return RedirectToRoute("MiRegla");
        }

        //redirecciona a una accion, puede ser de una accion de
        //un controlador diferente
        public RedirectToRouteResult resultadoRuta() {
            return RedirectToAction("Index");
        }

        public ContentResult Index()
        {
            return Content("<b>Andres Camacho</b>");
        }

        //solo se entra a ese metodo cuando la llamada se hace desde
        //un get
        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //solo se entra a ese metodo cuando la llamada se hace desde
        //un post
        [HttpPost]
        public ActionResult About(int numero)
        {
            ViewBag.Message = "Your application description page." + numero;
            ViewBag.uyyy = "uyyyy que rk";
            ViewData["lala"] = 5;

            return View();
        }


        //se le pasa informacion al metodo por medio de la url
        //ChildActionOnly indica que este metodo solo se puede ejecutar dentro de una vista
        //por ejemplo solo desde un render action
        [ChildActionOnly]
        public ActionResult Contact(string edad)
        {
            ViewBag.Message = "Your contact page."+edad;

            return View();
        }

        
        public ActionResult MiVista() {
            var srv = new Servicio().ObtenerPersonas();
            return View(srv);
        }
    }

}