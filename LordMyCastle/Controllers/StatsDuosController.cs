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
    public class StatsDuosController : Controller
    {
        private BddContext db = new BddContext();

        // GET: StatsDuos
        public ActionResult Index()
        {
            return View(db.StatsDuos.ToList());
        }

        // GET: StatsDuos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatsDuo statsDuo = db.StatsDuos.Find(id);
            if (statsDuo == null)
            {
                return HttpNotFound();
            }
            return View(statsDuo);
        }

        // GET: StatsDuos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatsDuos/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomFormation,AttaqueTypeTroupe1,DefenseTypeTroupe1,PvMaxTypeTroupe1,AttaqueTypeTroupe2,DefenseTypeTroupe2,PvMaxTypeTroupe2,AttaqueArmee,DefenseArmee,PvMaxArmee")] StatsDuo statsDuo)
        {
            if (ModelState.IsValid)
            {
                db.StatsDuos.Add(statsDuo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statsDuo);
        }

        // GET: StatsDuos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatsDuo statsDuo = db.StatsDuos.Find(id);
            if (statsDuo == null)
            {
                return HttpNotFound();
            }
            return View(statsDuo);
        }

        // POST: StatsDuos/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomFormation,AttaqueTypeTroupe1,DefenseTypeTroupe1,PvMaxTypeTroupe1,AttaqueTypeTroupe2,DefenseTypeTroupe2,PvMaxTypeTroupe2,AttaqueArmee,DefenseArmee,PvMaxArmee")] StatsDuo statsDuo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statsDuo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statsDuo);
        }

        // GET: StatsDuos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatsDuo statsDuo = db.StatsDuos.Find(id);
            if (statsDuo == null)
            {
                return HttpNotFound();
            }
            return View(statsDuo);
        }

        // POST: StatsDuos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StatsDuo statsDuo = db.StatsDuos.Find(id);
            db.StatsDuos.Remove(statsDuo);
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
