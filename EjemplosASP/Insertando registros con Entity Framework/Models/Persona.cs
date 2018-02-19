using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insertando_registros_con_Entity_Framework.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public int Edad { get; set; }
    }
}