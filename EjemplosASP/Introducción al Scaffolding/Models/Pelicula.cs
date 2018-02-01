using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introducción_al_Scaffolding.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool EstaEnCartelera { get; set; }
        public string Genero { get; set; }
    }
}