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
    public class StatsMonosController : Controller
    {
        private BddContext db = new BddContext();

        // GET: StatsMonoes
        public ActionResult Index()
        {
            return View(db.StatsMonos.ToList());
        }

        // GET: StatsMonoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatsMono statsMono = db.StatsMonos.Find(id);
            if (statsMono == null)
            {
                return HttpNotFound();
            }
            return View(statsMono);
        }

        // GET: StatsMonoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatsMonoes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomFormation,AttaqueFormation,DefenseFormation,PvMaxFormation,AttaqueArmee,DefenseArmee,PvMaxArmee")] StatsMono statsMono)
        {
            if (ModelState.IsValid)
            {
                db.StatsMonos.Add(statsMono);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statsMono);
        }

        // GET: StatsMonoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatsMono statsMono = db.StatsMonos.Find(id);
            if (statsMono == null)
            {
                return HttpNotFound();
            }
            return View(statsMono);
        }

        // POST: StatsMonoes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomFormation,AttaqueFormation,DefenseFormation,PvMaxFormation,AttaqueArmee,DefenseArmee,PvMaxArmee")] StatsMono statsMono)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statsMono).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statsMono);
        }

        // GET: StatsMonoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatsMono statsMono = db.StatsMonos.Find(id);
            if (statsMono == null)
            {
                return HttpNotFound();
            }
            return View(statsMono);
        }

        // POST: StatsMonoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StatsMono statsMono = db.StatsMonos.Find(id);
            db.StatsMonos.Remove(statsMono);
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
