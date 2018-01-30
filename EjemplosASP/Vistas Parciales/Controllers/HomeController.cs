using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vistas_Parciales.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.listado = Persona.GenerarLista();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.listado = Persona.GenerarLista1();

            return View();
        }
    }

    public class Persona {
        public string Name { get; set; }
        public int Edad { get; set; }

        public static List<Persona> GenerarLista(){
            return new List<Persona>()
            {
                new Persona(){
                    Name="Andres",
                    Edad=23
                },

                new Persona(){
                    Name="Andrea",
                    Edad=27
                },

                new Persona(){
                    Name="Alex",
                    Edad=21
                }
            };
        }

        public static List<Persona> GenerarLista1()
        {
            return new List<Persona>()
            {
                new Persona(){
                    Name="Carlos",
                    Edad=26
                },

                new Persona(){
                    Name="Juan",
                    Edad=27
                },

                new Persona(){
                    Name="Maria",
                    Edad=30
                }
            };
        }
    }
}