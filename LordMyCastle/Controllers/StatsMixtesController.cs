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
    public class StatsMixtesController : Controller
    {
        private BddContext db = new BddContext();

        // GET: StatsMixtes
        public ActionResult Index()
        {
            return View(db.StatsMixtes.ToList());
        }

        // GET: StatsMixtes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatsMixte statsMixte = db.StatsMixtes.Find(id);
            if (statsMixte == null)
            {
                return HttpNotFound();
            }
            return View(statsMixte);
        }

        // GET: StatsMixtes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatsMixtes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AttaqueInf,DefenseInf,PvMaxInf,AttaqueArcher,DefenseArcher,PvMaxArcher,AttaqueCava,DefenseCava,PvMaxCava,AttaqueArmee,DefenseArmee,PvMaxArmee")] StatsMixte statsMixte)
        {
            if (ModelState.IsValid)
            {
                db.StatsMixtes.Add(statsMixte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statsMixte);
        }

        // GET: StatsMixtes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatsMixte statsMixte = db.StatsMixtes.Find(id);
            if (statsMixte == null)
            {
                return HttpNotFound();
            }
            return View(statsMixte);
        }

        // POST: StatsMixtes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AttaqueInf,DefenseInf,PvMaxInf,AttaqueArcher,DefenseArcher,PvMaxArcher,AttaqueCava,DefenseCava,PvMaxCava,AttaqueArmee,DefenseArmee,PvMaxArmee")] StatsMixte statsMixte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statsMixte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statsMixte);
        }

        // GET: StatsMixtes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatsMixte statsMixte = db.StatsMixtes.Find(id);
            if (statsMixte == null)
            {
                return HttpNotFound();
            }
            return View(statsMixte);
        }

        // POST: StatsMixtes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StatsMixte statsMixte = db.StatsMixtes.Find(id);
            db.StatsMixtes.Remove(statsMixte);
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
