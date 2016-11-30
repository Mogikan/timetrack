using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TimeTrack.BusinessLogic;
using TimeTrack.Model;

namespace TimeTrack.Server.MVC.Controllers
{
    public class TimesheetsController : Controller
    {
        private TimeTrackContext db = new TimeTrackContext();

        // GET: Timesheets
        public ActionResult Index()
        {
            var transactions = db.Transactions.Include(t => t.Employee).Include(t => t.Project);
            return View(transactions.ToList());
        }

        // GET: Timesheets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Timesheet timesheet = db.Transactions.Find(id);
            if (timesheet == null)
            {
                return HttpNotFound();
            }
            return View(timesheet);
        }

        // GET: Timesheets/Create
        public ActionResult Create()
        {
            ViewBag.FkEmployee = new SelectList(db.Accounts, "Id", "FullName");
            ViewBag.FkProject = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Timesheets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FkEmployee,FkProject,Date,SpendTime,Notes")] Timesheet timesheet)
        {
            if (ModelState.IsValid)
            {
                db.Transactions.Add(timesheet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FkEmployee = new SelectList(db.Accounts, "Id", "FullName", timesheet.FkEmployee);
            ViewBag.FkProject = new SelectList(db.Categories, "Id", "Name", timesheet.FkProject);
            return View(timesheet);
        }

        // GET: Timesheets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Timesheet timesheet = db.Transactions.Find(id);
            if (timesheet == null)
            {
                return HttpNotFound();
            }
            ViewBag.FkEmployee = new SelectList(db.Accounts, "Id", "FullName", timesheet.FkEmployee);
            ViewBag.FkProject = new SelectList(db.Categories, "Id", "Name", timesheet.FkProject);
            return View(timesheet);
        }

        // POST: Timesheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FkEmployee,FkProject,Date,SpendTime,Notes")] Timesheet timesheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timesheet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FkEmployee = new SelectList(db.Accounts, "Id", "FullName", timesheet.FkEmployee);
            ViewBag.FkProject = new SelectList(db.Categories, "Id", "Name", timesheet.FkProject);
            return View(timesheet);
        }

        // GET: Timesheets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Timesheet timesheet = db.Transactions.Find(id);
            if (timesheet == null)
            {
                return HttpNotFound();
            }
            return View(timesheet);
        }

        // POST: Timesheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Timesheet timesheet = db.Transactions.Find(id);
            db.Transactions.Remove(timesheet);
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
