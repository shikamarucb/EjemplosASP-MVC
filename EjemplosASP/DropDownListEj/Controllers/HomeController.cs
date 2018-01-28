using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace DropDownListEj.Controllers
{
    public class HomeController : Controller
    {
        public enum Estados {
            Aprobado=1,
            Rechazado=2,

            [Description("Pendiente Aprobación")]
            PendienteAprobacion=3
        }

        public ActionResult Index()
        {
            //Listado de un enum
            ViewBag.miListado = ToListSelectListItem<Estados>();

            //Listado de creado por medio de un metodo
            ViewBag.lista = ObtenerLista();
            return View();
        }

        //Codigo para hacer el listado de acuerdo al enum, utlizando la descripcion si 
        //esta existe
        public List<SelectListItem> ToListSelectListItem<T>()
        {
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


        public List<SelectListItem> ObtenerLista() {
            return new List<SelectListItem>()
            {
                //SelecListItem no es mas que la estructura <option> que va dentro de la 
                //estructura <select>, con sus respectivas propiedades
                new SelectListItem(){
                    Value="1",
                    Text="Si"
                },
                new SelectListItem(){
                    Value="2",
                    Text="No"
                },
                new SelectListItem(){
                    Value="3",
                    Text="Quizás",
                    Disabled=true
                }
            };
        }
    }
}