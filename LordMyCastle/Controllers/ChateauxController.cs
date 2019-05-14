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
    public class ChateauxController : Controller
    {
        private BddContext db = new BddContext();

        // GET: Chateaux
        public ActionResult Index()
        {
            return View(db.Chateaux.ToList());
        }

        // GET: Chateaux/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chateau chateau = db.Chateaux.Find(id);
            if (chateau == null)
            {
                return HttpNotFound();
            }
            return View(chateau);
        }

        // GET: Chateaux/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chateaux/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nom")] Chateau chateau)
        {
            if (ModelState.IsValid)
            {
                db.Chateaux.Add(chateau);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chateau);
        }

        // GET: Chateaux/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chateau chateau = db.Chateaux.Find(id);
            if (chateau == null)
            {
                return HttpNotFound();
            }
            return View(chateau);
        }

        // POST: Chateaux/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nom")] Chateau chateau)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chateau).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chateau);
        }

        // GET: Chateaux/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chateau chateau = db.Chateaux.Find(id);
            if (chateau == null)
            {
                return HttpNotFound();
            }
            return View(chateau);
        }

        // POST: Chateaux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chateau chateau = db.Chateaux.Find(id);
            db.Chateaux.Remove(chateau);
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
