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
    public class AddProjectProfilesController : Controller
    {
        private MICProjectWhiteThemeContext db = new MICProjectWhiteThemeContext();

        // GET: AddProjectProfiles
        public ActionResult Index()
        {
            return View(db.AddProjectProfiles.ToList());
        }

        // GET: AddProjectProfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddProjectProfile addProjectProfile = db.AddProjectProfiles.Find(id);
            if (addProjectProfile == null)
            {
                return HttpNotFound();
            }
            return View(addProjectProfile);
        }

        // GET: AddProjectProfiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddProjectProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectID,ProjectName,ProjectStartingDate,ClientName,ProjectManager")] AddProjectProfile addProjectProfile)
        {
            if (ModelState.IsValid)
            {
                db.AddProjectProfiles.Add(addProjectProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addProjectProfile);
        }

        // GET: AddProjectProfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddProjectProfile addProjectProfile = db.AddProjectProfiles.Find(id);
            if (addProjectProfile == null)
            {
                return HttpNotFound();
            }
            return View(addProjectProfile);
        }

        // POST: AddProjectProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectID,ProjectName,ProjectStartingDate,ClientName,ProjectManager")] AddProjectProfile addProjectProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addProjectProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addProjectProfile);
        }

        // GET: AddProjectProfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddProjectProfile addProjectProfile = db.AddProjectProfiles.Find(id);
            if (addProjectProfile == null)
            {
                return HttpNotFound();
            }
            return View(addProjectProfile);
        }

        // POST: AddProjectProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddProjectProfile addProjectProfile = db.AddProjectProfiles.Find(id);
            db.AddProjectProfiles.Remove(addProjectProfile);
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
