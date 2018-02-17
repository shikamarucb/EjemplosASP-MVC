using Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MultiIdioma.Models
{
    public class Persona
    {
        public int Id { get; set; }

        //Se crean los archivos de recurso con nombre igual, lo unico que varia es el
        //Table of Language Culture Names, Codes, que va seguido despues de un punto
        //Los archivos de recursos se crearon en la carpeta Recursos

        [Display(ResourceType =typeof(Persona_res), Name ="Persona_Nombre_Mostrar" )]
        [Required(ErrorMessageResourceType =typeof(Persona_res),ErrorMessageResourceName ="Persona_Nombre_Error")]
        public string Nombre { get; set; }
    }
}