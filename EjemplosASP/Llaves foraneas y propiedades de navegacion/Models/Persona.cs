using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Llaves_foraneas_y_propiedades_de_navegacion.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual List<Direccion> Direcciones { get; set; }
    }
}