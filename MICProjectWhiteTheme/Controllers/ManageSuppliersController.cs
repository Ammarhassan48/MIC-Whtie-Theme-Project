using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MICProjectWhiteTheme.Models;

namespace MICProjectWhiteTheme.Controllers
{
    public class ManageSuppliersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ManageSuppliers
        public ActionResult Index()
        {
            return View(db.ManageSuppliers.ToList());
        }

        // GET: ManageSuppliers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageSuppliers manageSuppliers = db.ManageSuppliers.Find(id);
            if (manageSuppliers == null)
            {
                return HttpNotFound();
            }
            return View(manageSuppliers);
        }

        // GET: ManageSuppliers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageSuppliers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SupplierID,SupplierName,SupplierCompany,SuppliersAddress,SupplierPhone,SupplierEmail")] ManageSuppliers manageSuppliers)
        {
            if (ModelState.IsValid)
            {
                db.ManageSuppliers.Add(manageSuppliers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manageSuppliers);
        }

        // GET: ManageSuppliers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageSuppliers manageSuppliers = db.ManageSuppliers.Find(id);
            if (manageSuppliers == null)
            {
                return HttpNotFound();
            }
            return View(manageSuppliers);
        }

        // POST: ManageSuppliers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SupplierID,SupplierName,SupplierCompany,SuppliersAddress,SupplierPhone,SupplierEmail")] ManageSuppliers manageSuppliers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manageSuppliers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manageSuppliers);
        }

        // GET: ManageSuppliers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageSuppliers manageSuppliers = db.ManageSuppliers.Find(id);
            if (manageSuppliers == null)
            {
                return HttpNotFound();
            }
            return View(manageSuppliers);
        }

        // POST: ManageSuppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManageSuppliers manageSuppliers = db.ManageSuppliers.Find(id);
            db.ManageSuppliers.Remove(manageSuppliers);
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
