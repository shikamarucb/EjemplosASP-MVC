using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Llaves_foraneas_y_propiedades_de_navegacion.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //Se establece la llave foranea
            modelBuilder.Entity<Direccion>().HasRequired(x => x._Persona);

            base.OnModelCreating(modelBuilder);
        }
    }
}