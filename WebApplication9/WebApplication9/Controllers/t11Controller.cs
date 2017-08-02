using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class t11Controller : Controller
    {
        private testdbEntities db = new testdbEntities();

        // GET: t11
        public ActionResult Index()
        {
            return View(db.t11.ToList());
        }

        // GET: t11/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t11 t11 = db.t11.Find(id);
            if (t11 == null)
            {
                return HttpNotFound();
            }
            return View(t11);
        }

        // GET: t11/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: t11/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name")] t11 t11)
        {
            if (ModelState.IsValid)
            {
                db.t11.Add(t11);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(t11);
        }

        // GET: t11/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t11 t11 = db.t11.Find(id);
            if (t11 == null)
            {
                return HttpNotFound();
            }
            return View(t11);
        }

        // POST: t11/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name")] t11 t11)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t11).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t11);
        }

        // GET: t11/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t11 t11 = db.t11.Find(id);
            if (t11 == null)
            {
                return HttpNotFound();
            }
            return View(t11);
        }

        // POST: t11/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            t11 t11 = db.t11.Find(id);
            db.t11.Remove(t11);
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
