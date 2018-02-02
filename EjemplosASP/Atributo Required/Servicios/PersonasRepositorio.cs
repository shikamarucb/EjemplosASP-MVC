using Atributo_Required.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atributo_Required.Servicios
{
    public class PersonasRepositorio
    {
        public List<Persona> ObtenerPersonas() {

            using (var db = new ApplicationDbContext()) {
                return db.Personas.ToList();
            }
        }

        internal void Crear(Persona model)
        {
            using(var db=new ApplicationDbContext())
            {
                db.Personas.Add(model);
                db.SaveChanges();
            }
        }
    }
}