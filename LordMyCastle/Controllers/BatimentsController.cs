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
    public class BatimentsController : Controller
    {
        private BddContext db = new BddContext();

        // GET: Batiments
        public ActionResult Index()
        {
            return View(db.Batiments.ToList());
        }

        // GET: Batiments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Batiment batiment = db.Batiments.Find(id);
            if (batiment == null)
            {
                return HttpNotFound();
            }
            return View(batiment);
        }

        // GET: Batiments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Batiments/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomBatiment,Niveau")] Batiment batiment)
        {
            if (ModelState.IsValid)
            {
                db.Batiments.Add(batiment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(batiment);
        }

        // GET: Batiments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Batiment batiment = db.Batiments.Find(id);
            if (batiment == null)
            {
                return HttpNotFound();
            }
            return View(batiment);
        }

        // POST: Batiments/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomBatiment,Niveau")] Batiment batiment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(batiment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(batiment);
        }

        // GET: Batiments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Batiment batiment = db.Batiments.Find(id);
            if (batiment == null)
            {
                return HttpNotFound();
            }
            return View(batiment);
        }

        // POST: Batiments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Batiment batiment = db.Batiments.Find(id);
            db.Batiments.Remove(batiment);
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
