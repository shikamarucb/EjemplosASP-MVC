using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Llaves_foraneas_y_propiedades_de_navegacion.Models
{
    public class Direccion
    {
        public int Id { get; set; }
        public string _Direccion { get; set; }
        public Persona _Persona { get; set; }
    }
}