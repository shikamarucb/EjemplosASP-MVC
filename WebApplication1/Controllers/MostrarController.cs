using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MostrarController : Controller
    {
        // GET: Mostrar
        public ActionResult Index()
        {
            var car = new Automovil()
            {
                placa = "asd123",
                marca = "Renault",
                modelo = 2015
            };

            ViewBag.carro = car;
            return View();
        }

        public ActionResult Index2()
        {
            var car = new Automovil2()
            {
                placa = "asd123",
                marca = "Renault"
            };

            ViewBag.carro2 = car;
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.listado = new Automovil().ObtenerLista();

            //Listado con enum
            ViewBag.listadoEnum = Automovil.ObtenerLista2<Automovil.Listadoo>();


            return View();
        }


        public ActionResult Formulario() {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario2(Automovil2 car)
        {
            ViewBag.carrito = car;
            return View("Formulario");
        }
    }

    public class Automovil{
        public string placa { get; set; }
        public string marca { get; set; }
        public int modelo { get; set; }

        public enum Listadoo {
            Cedula = 1,
            Nombre = 2,
            [Description("Nombre y Apellidos")]
            NombreApellidos = 3
        };

        public List<SelectListItem> ObtenerLista() {
            return new List<SelectListItem>()
            {
                new SelectListItem(){
                    Text="Tal Vez",
                    Value="1"
                },

                new SelectListItem(){
                    Text="Sisas perro",
                    Value="2"
                }
            };
        }

        public static List<SelectListItem> ObtenerLista2<T>() {

            var t = typeof(T);

            if (!t.IsEnum) { throw new ApplicationException("Tipo debe ser enum"); }

            var members = t.GetFields(BindingFlags.Public | BindingFlags.Static);

            var result = new List<SelectListItem>();

            foreach (var member in members)
            {
                var attributeDescription = member.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute),
                    false);
                var descripcion = member.Name;

                if (attributeDescription.Any())
                {
                    descripcion = ((System.ComponentModel.DescriptionAttribute)attributeDescription[0]).Description;
                }

                var valor = ((int)Enum.Parse(t, member.Name));
                result.Add(new SelectListItem()
                {
                    Text = descripcion,
                    Value = valor.ToString()
                });
            }
            return result;
        }
    }

    public class Automovil2
    {
        public string placa { get; set; }
        public string marca { get; set; }
        public DateTime fecha { get; set; }
    }
}