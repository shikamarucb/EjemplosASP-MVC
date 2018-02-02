using Atributo_Required.Models;
using Atributo_Required.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atributo_Required.Controllers
{
    public class PersonasController : Controller
    {

        private PersonasRepositorio _repo;

        public PersonasController()
        {
            _repo = new PersonasRepositorio();
        }


        // GET: Personas
        public ActionResult Index()
        {
            var model = _repo.ObtenerPersonas();
            return View(model);
        }

        // GET: Personas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        [HttpPost]
        public ActionResult Create(Persona model)
        {
            try
            {
                if (ModelState.IsValid) {
                    _repo.Crear(model);
                    return View(model);
                }
                // TODO: Add insert logic here

                
            }
            catch
            {
                //Log
            }
            return View();
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Personas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
