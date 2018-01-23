using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Servicios
{
    public class Servicio
    {
        public List<Persona> ObtenerPersonas() {
            return new List<Persona>()
            {
                new Persona(){
                    cedula=1010890465,
                    nombre="Andres Felipe",
                    apellido="Camacho Barragan"
                },
                new Persona(){
                    cedula=1010890000,
                    nombre="Juan Felipe",
                    apellido="Beltran Barragan"
                },
                new Persona(){
                    cedula=1010877765,
                    nombre="Cristian Felipe",
                    apellido="Camacho Suarez<script>alert('hackeado papu');</script>"
                }
            };
        }
    }
}