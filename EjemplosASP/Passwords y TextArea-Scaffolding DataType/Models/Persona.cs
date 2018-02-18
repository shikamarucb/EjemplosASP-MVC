using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Passwords_y_TextArea_Scaffolding_DataType.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [DataType(DataType.MultilineText)]
        public string Propuesta { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}