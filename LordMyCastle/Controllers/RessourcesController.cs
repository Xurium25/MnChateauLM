using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LordMyCastle.Models;

namespace LordMyCastle.Controllers
{
    public class RessourcesController : Controller
    {
        private BddContext db = new BddContext();

        // GET: Ressources
        public ActionResult Index()
        {
            return View(db.Ressources.ToList());
        }

        // GET: Ressources/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ressource ressource = db.Ressources.Find(id);
            if (ressource == null)
            {
                return HttpNotFound();
            }
            return View(ressource);
        }

        // GET: Ressources/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ressources/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nom,Production,Stock")] Ressource ressource)
        {
            if (ModelState.IsValid)
            {
                db.Ressources.Add(ressource);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ressource);
        }

        // GET: Ressources/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ressource ressource = db.Ressources.Find(id);
            if (ressource == null)
            {
                return HttpNotFound();
            }
            return View(ressource);
        }

        // POST: Ressources/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nom,Production,Stock")] Ressource ressource)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ressource).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ressource);
        }

        // GET: Ressources/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ressource ressource = db.Ressources.Find(id);
            if (ressource == null)
            {
                return HttpNotFound();
            }
            return View(ressource);
        }

        // POST: Ressources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ressource ressource = db.Ressources.Find(id);
            db.Ressources.Remove(ressource);
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
