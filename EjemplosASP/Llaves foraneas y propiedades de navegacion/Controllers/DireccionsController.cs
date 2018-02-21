using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Llaves_foraneas_y_propiedades_de_navegacion.Models;

namespace Llaves_foraneas_y_propiedades_de_navegacion.Controllers
{
    public class DireccionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Direccions
        public ActionResult Index()
        {
            //Id=1=Andres
            //Persona persona = new Persona() { Id = 1 };
            //db.Personas.Attach(persona);

            //Direccion direccion = new Direccion() { _Direccion="calle falsa",_Persona=persona};

            //db.Direcciones.Add(direccion);
            //db.SaveChanges();

            //Propiedades de Navegacion
            //Metodo 1
            var persona = db.Personas.FirstOrDefault(x => x.Id == 1);
            //Para que funcione el metodo debe llevar la palabra virtual en la clase
            //del modelo Persona, en el atributo "Direcciones"
            var direccion = persona.Direcciones;

            //Metodo 2
            var persona2 = db.Personas.Include("Direcciones").FirstOrDefault(x => x.Id == 1);


            //Inner join en Entity Framework. Join y GroupJoin 

            //una direccion con su persona
            var personaDireccion = db.Direcciones.Join(db.Personas, dir => dir.IdPersona,
                per => per.Id, (dir, per) => new { dir, per }).FirstOrDefault(x => x.dir.Id == 1);

            //1 persona con todas sus direcciones
            var persona1ConSusDirecciones = db.Personas.GroupJoin(db.Direcciones, per => per.Id,
                dir => dir.IdPersona, (per, dir) => new { per, dir }).FirstOrDefault(x => x.per.Id == 1);

            //Todas las personas con sus direcciones
            var personaConSusDirecciones = db.Personas.GroupJoin(db.Direcciones, per => per.Id,
                dir => dir.IdPersona, (per, dir) => new { per, dir }).ToList();



            return View(db.Direcciones.ToList());
        }

        // GET: Direccions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direccion direccion = db.Direcciones.Find(id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            return View(direccion);
        }

        // GET: Direccions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Direccions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,_Direccion")] Direccion direccion)
        {
            if (ModelState.IsValid)
            {
                db.Direcciones.Add(direccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(direccion);
        }

        // GET: Direccions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direccion direccion = db.Direcciones.Find(id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            return View(direccion);
        }

        // POST: Direccions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,_Direccion")] Direccion direccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(direccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(direccion);
        }

        // GET: Direccions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direccion direccion = db.Direcciones.Find(id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            return View(direccion);
        }

        // POST: Direccions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Direccion direccion = db.Direcciones.Find(id);
            db.Direcciones.Remove(direccion);
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
