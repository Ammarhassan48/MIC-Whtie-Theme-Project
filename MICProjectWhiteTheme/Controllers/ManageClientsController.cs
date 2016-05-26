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
    public class ManageClientsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ManageClients
        public ActionResult Index()
        {
            return View(db.ManageClients.ToList());
        }

        // GET: ManageClients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageClients manageClients = db.ManageClients.Find(id);
            if (manageClients == null)
            {
                return HttpNotFound();
            }
            return View(manageClients);
        }

        // GET: ManageClients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageClients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientID,CompanyName,RepresentatorName,Designation,Address,PhoneNo,Email")] ManageClients manageClients)
        {
            if (ModelState.IsValid)
            {
                db.ManageClients.Add(manageClients);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manageClients);
        }

        // GET: ManageClients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageClients manageClients = db.ManageClients.Find(id);
            if (manageClients == null)
            {
                return HttpNotFound();
            }
            return View(manageClients);
        }

        // POST: ManageClients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClientID,CompanyName,RepresentatorName,Designation,Address,PhoneNo,Email")] ManageClients manageClients)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manageClients).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manageClients);
        }

        // GET: ManageClients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManageClients manageClients = db.ManageClients.Find(id);
            if (manageClients == null)
            {
                return HttpNotFound();
            }
            return View(manageClients);
        }

        // POST: ManageClients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ManageClients manageClients = db.ManageClients.Find(id);
            db.ManageClients.Remove(manageClients);
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
