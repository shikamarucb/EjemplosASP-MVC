using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Atributo_Required.Models
{
    public class Persona
    {
        public int Id { get; set; }

        //Atributo StringLength: Longitud minima y maxima del campo "Nombre"
        [StringLength(50,MinimumLength = 5,ErrorMessage ="El campo {0} debe tener minimo {2} caracteres y maximo {1}" +
            " caracteres")]
        public string Nombre { get; set; }

        //Atributo Required: El atributo "Apellido" es obligatorio para crear un nuevo modelo de "Persona" en la BD
        [Required(ErrorMessage ="El campo {0} es obligatorio para crear")]
        public string Apellido { get; set; }
    }
}