using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Funciones_especiales_del_DbContext_EF.Models
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