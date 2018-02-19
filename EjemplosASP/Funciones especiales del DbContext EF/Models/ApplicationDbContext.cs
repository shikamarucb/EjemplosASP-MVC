using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Funciones_especiales_del_DbContext_EF.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Producto> Productos { get; set; }

        //Metodo 1
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configura los campos datetime en la BD como datetime2
            modelBuilder.Properties<DateTime>().Configure(x => x.HasColumnType("datetime2"));

            //Establece un campo entero que empiece con la palabra "Codigo" como llave primaria
            modelBuilder.Properties<int>().Where(p => p.Name.StartsWith("Codigo"))
                .Configure(p => p.IsKey());

            //Siempre se ejecuta
            base.OnModelCreating(modelBuilder);
        }


        //Este metodo nos dice bajo que circunstancia una entidad(Persona,Producto) se debe validar
        //y la validacion se realiza en el metodo "ValidateEntity"
        protected override bool ShouldValidateEntity(DbEntityEntry entityEntry)
        {
            //Por defecto al borrar una entidad no se valida nada.

            //En este caso al retornar "true" estoy diciendo que si quiero que se valide algo con 
            //la entidad al momento de eliminar algo y se valida en el metodo "ValidateEntity"
            if (entityEntry.State == EntityState.Deleted)
            {
                return true;
            }

            //Siempre se ejecuta por defecto
            return base.ShouldValidateEntity(entityEntry);
        }

        //Este metodo realiza las validaciones de las entidades
        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            //si la entidad es persona y el estado de la entidad es de borrado..
            if(entityEntry.Entity is Persona && entityEntry.State== EntityState.Deleted)
            {
                var entidad = entityEntry.Entity as Persona;
                //si la entidad que se va a eliminar es un menor de edad, retorna un DBEntityValidationResult
                if(entidad.Edad < 18)
                {
                    return new DbEntityValidationResult(entityEntry, new DbValidationError[]
                    {
                        new DbValidationError("Edad","No se puede borrar a un menor de edad.")
                    });
                }
            }
            return base.ValidateEntity(entityEntry, items);
        }

        //Guarda todos los cambios realizados en este contexto en la base de datos subyacente.
        public override int SaveChanges()
        {
            var entidades = ChangeTracker.Entries();

            if(entidades != null)
            {
                foreach (var entidad in entidades.Where(x=>x.State!=EntityState.Unchanged))
                {
                    //Auditar..
                }
            }
            

            return base.SaveChanges();
        }
    }
}