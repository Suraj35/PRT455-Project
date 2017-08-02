using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ali.Models;

namespace Ali.Controllers
{
    public class alitablesController : Controller
    {
        private alidbEntities db = new alidbEntities();

        // GET: alitables
        public ActionResult Index()
        {
            return View(db.alitables.ToList());
        }

        // GET: alitables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            alitable alitable = db.alitables.Find(id);
            if (alitable == null)
            {
                return HttpNotFound();
            }
            return View(alitable);
        }

        // GET: alitables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: alitables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,surname")] alitable alitable)
        {
            if (ModelState.IsValid)
            {
                db.alitables.Add(alitable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alitable);
        }

        // GET: alitables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            alitable alitable = db.alitables.Find(id);
            if (alitable == null)
            {
                return HttpNotFound();
            }
            return View(alitable);
        }

        // POST: alitables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,surname")] alitable alitable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alitable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alitable);
        }

        // GET: alitables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            alitable alitable = db.alitables.Find(id);
            if (alitable == null)
            {
                return HttpNotFound();
            }
            return View(alitable);
        }

        // POST: alitables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            alitable alitable = db.alitables.Find(id);
            db.alitables.Remove(alitable);
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
