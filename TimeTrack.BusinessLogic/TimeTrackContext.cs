using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrack.Model;

namespace TimeTrack.BusinessLogic
{
    public class TimeTrackContext:DbContext
    {
        public TimeTrackContext():base("name=TimeTrack")
        {
        }
        public virtual DbSet<Employee> Accounts { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Timesheet> Transactions { get; set; }

        #region 
        public ActionResult Index()
        {
            var categories = db.Categories.Include(p => p.ProjectManager);
            return View(categories.ToList());
        }

        // GET: Projects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Categories.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // GET: Projects/Create
        public ActionResult Create()
        {
            ViewBag.FKProjectManager = new SelectList(db.Accounts, "Id", "FullName");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FKProjectManager,Name,Closed,StartDate,FinishDate")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(project);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FKProjectManager = new SelectList(db.Accounts, "Id", "FullName", project.FKProjectManager);
            return View(project);
        }

        // GET: Projects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Categories.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            ViewBag.FKProjectManager = new SelectList(db.Accounts, "Id", "FullName", project.FKProjectManager);
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FKProjectManager,Name,Closed,StartDate,FinishDate")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FKProjectManager = new SelectList(db.Accounts, "Id", "FullName", project.FKProjectManager);
            return View(project);
        }

        // GET: Projects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Categories.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = db.Categories.Find(id);
            db.Categories.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

    }
}
