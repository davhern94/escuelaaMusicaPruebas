using pruebasEscuela.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pruebasEscuela.Controllers
{
    public class ProfesorController : Controller
    {
        // GET: Profesor
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.profesor.ToList());
            }
        }

        // GET: Profesor/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.profesor.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Profesor/Create
        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {
                return View();
            }
        }

        // POST: Profesor/Create
        [HttpPost]
        public ActionResult Create(profesor Profesor)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.profesor.Add(Profesor);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profesor/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.profesor.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Profesor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, profesor Profesor)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(Profesor).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profesor/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.profesor.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Profesor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    profesor Profesor = (context.profesor.Where(x => x.id == id).FirstOrDefault());
                    context.profesor.Remove(Profesor);
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
