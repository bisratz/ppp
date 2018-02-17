using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HairSalonAppointement.Models;

namespace HairSalonAppointement.Controllers
{
    public class HairStylersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HairStylers
        public ActionResult Index()
        {
            return View(db.HairStylers.ToList());
        }

        // GET: HairStylers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HairStylers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] HairStyler hairStyler)
        {
            if (ModelState.IsValid)
            {
                db.HairStylers.Add(hairStyler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hairStyler);
        }

        // GET: HairStylers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HairStyler hairStyler = db.HairStylers.Find(id);
            if (hairStyler == null)
            {
                return HttpNotFound();
            }
            return View(hairStyler);
        }

        // POST: HairStylers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] HairStyler hairStyler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hairStyler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hairStyler);
        }

        // GET: HairStylers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HairStyler hairStyler = db.HairStylers.Find(id);
            if (hairStyler == null)
            {
                return HttpNotFound();
            }
            return View(hairStyler);
        }

        // POST: HairStylers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HairStyler hairStyler = db.HairStylers.Find(id);
            db.HairStylers.Remove(hairStyler);
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

