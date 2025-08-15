using pruebasEscuela.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pruebasEscuela.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            using(DbModels context = new DbModels())
            {
                return View(context.Alumno.ToList());
            }
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Alumno.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {
                return View();
            }
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Alumno.Add(alumno);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Alumno.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Alumno alumno)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(alumno).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Alumno.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {

                using (DbModels context = new DbModels()) { 
                    Alumno alumno = (context.Alumno.Where(x => x.id == id).FirstOrDefault());
                context.Alumno.Remove(alumno);
                context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
