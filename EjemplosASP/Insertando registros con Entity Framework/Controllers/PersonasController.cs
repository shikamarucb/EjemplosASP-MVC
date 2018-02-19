using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Insertando_registros_con_Entity_Framework.Models;

namespace Insertando_registros_con_Entity_Framework.Controllers
{
    public class PersonasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Personas
        public ActionResult Index()
        {
            return View(db.Personas.ToList());
        }

        // GET: Personas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellido,Nacimiento,Edad")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                var listaPersonas = new List<Persona>() { persona };

                listaPersonas.Add(new Persona() { Nombre = "Felipe", Apellido = "Barragan", Edad = 32, Nacimiento = new DateTime(1995, 12, 15) });

                //Asi se añaden multiples registro a la DB
                db.Personas.AddRange(listaPersonas);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(persona);
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellido,Nacimiento,Edad")] Persona persona)
        {
            //Metodos para editar en EF

            //Metodo 1
            var personaEditar = db.Personas.FirstOrDefault(x => x.Id == 1);
            personaEditar.Nombre = "Metodo1";
            personaEditar.Edad = 51;
            db.SaveChanges();

            //Metodo 2: Actualizacion Parcial
            var personaEditar2 = new Persona();
            personaEditar2.Id = 2;
            personaEditar2.Nombre = "Metodo2";
            //Este campo no se va a modificar
            personaEditar2.Edad = 52;
            db.Personas.Attach(personaEditar2);
            db.Entry(personaEditar2).Property(x => x.Nombre).IsModified = true;
            db.SaveChanges();

            //Metodo 3 actualizado desde la vista
            if (ModelState.IsValid)
            {
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Persona persona = db.Personas.Find(id);
            //si quiero eliminar varios registros ejecuto el metodo removeRange y le paso como
            //parametro una lista de "Persona" en este caso
            db.Personas.Remove(persona);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
