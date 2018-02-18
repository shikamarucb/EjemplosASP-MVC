using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ocultando_campos_con_ScaffoldColumn.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Por defector es true, es decir si aparecerá un campo en la vista cuando
        //se haga scaffolding
        [ScaffoldColumn(false)]
        public string Apellido { get; set; }
    }
}