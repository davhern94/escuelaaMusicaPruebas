using pruebasEscuela.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pruebasEscuela.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.escuela.ToList());
            }
        }

        // GET: Escuela/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.escuela.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Escuela/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Escuela/Create
        [HttpPost]
        public ActionResult Create(escuela Escuela)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.escuela.Add(Escuela);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Escuela/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.escuela.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Escuela/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, escuela Escuela)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(Escuela).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Escuela/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.escuela.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Escuela/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    escuela Escuela = (context.escuela.Where(x => x.id == id).FirstOrDefault());
                    context.escuela.Remove(Escuela);
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
