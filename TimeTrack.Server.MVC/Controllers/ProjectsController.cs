using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TimeTrack.Server.MVC.TimeTrackServiceReference;

namespace TimeTrack.Server.MVC.Controllers
{
    public class ProjectsController : Controller
    {
        private TimeTrackServiceClient serviceClient = new TimeTrackServiceClient();

        // GET: Projects
        public ActionResult Index()
        {
            var categories = serviceClient.GetProjects();//Projects.Include(p => p.ProjectManager);
            return View(categories.ToList());
        }

        // GET: Projects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = serviceClient.GetProjectById(id.Value);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // GET: Projects/Create
        public ActionResult Create()
        {
            ViewBag.FKProjectManager = new SelectList(serviceClient.GetEmployees(), "Id", "FullName");
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
                serviceClient.AddProject(project);
                return RedirectToAction("Index");
            }

            ViewBag.FKProjectManager = new SelectList(serviceClient.GetEmployees(), "Id", "FullName", project.FKProjectManager);
            return View(project);
        }

        // GET: Projects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = serviceClient.GetProjectById(id.Value);
            if (project == null)
            {
                return HttpNotFound();
            }
            ViewBag.FKProjectManager = new SelectList(serviceClient.GetEmployees(), "Id", "FullName", project.FKProjectManager);
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
                serviceClient.UpdateProject(project);
                return RedirectToAction("Index");
            }
            ViewBag.FKProjectManager = new SelectList(serviceClient.GetEmployees(), "Id", "FullName", project.FKProjectManager);
            return View(project);
        }

        // GET: Projects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = serviceClient.GetProjectById(id.Value);
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
            serviceClient.DeleteProjectById(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                serviceClient.Close();
            }
            base.Dispose(disposing);
        }
    }
}
