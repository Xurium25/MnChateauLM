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
    public class TroupesController : Controller
    {
        private BddContext db = new BddContext();

        // GET: Troupes
        public ActionResult Index()
        {
            return View(db.Troupes.ToList());
        }

        // GET: Troupes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Troupes troupes = db.Troupes.Find(id);
            if (troupes == null)
            {
                return HttpNotFound();
            }
            return View(troupes);
        }

        // GET: Troupes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Troupes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,InfanterieT1,ArcherT1,CavalerieT1,EnginSiegeT1,InfanterieT2,ArcherT2,CavalerieT2,EnginSiegeT2,InfanterieT3,ArcherT3,CavalerieT3,EnginSiegeT3,InfanterieT4,ArcherT4,CavalerieT4,EnginSiege")] Troupes troupes)
        {
            if (ModelState.IsValid)
            {
                db.Troupes.Add(troupes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(troupes);
        }

        // GET: Troupes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Troupes troupes = db.Troupes.Find(id);
            if (troupes == null)
            {
                return HttpNotFound();
            }
            return View(troupes);
        }

        // POST: Troupes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,InfanterieT1,ArcherT1,CavalerieT1,EnginSiegeT1,InfanterieT2,ArcherT2,CavalerieT2,EnginSiegeT2,InfanterieT3,ArcherT3,CavalerieT3,EnginSiegeT3,InfanterieT4,ArcherT4,CavalerieT4,EnginSiege")] Troupes troupes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(troupes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(troupes);
        }

        // GET: Troupes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Troupes troupes = db.Troupes.Find(id);
            if (troupes == null)
            {
                return HttpNotFound();
            }
            return View(troupes);
        }

        // POST: Troupes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Troupes troupes = db.Troupes.Find(id);
            db.Troupes.Remove(troupes);
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
