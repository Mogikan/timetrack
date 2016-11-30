using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TimeTrack.Model;

namespace TimeTrack.BusinessLogic
{
    [ServiceContract]
    public class TimeTrackService
    {
        [OperationContract]
        public IList<Project> GetProjects()
        {
            using (var db = new TimeTrackContext())
            {
                var projects = db.Projects.Include(p => p.ProjectManager);
                return projects.ToList();
            }         
        }

        [OperationContract]
        public Project GetProjectById(int id)
        {
            using (var db = new TimeTrackContext())
            {
                Project project = db.Projects.Find(id);
                return project;
            }            
        }      

        [OperationContract]
        public void AddProject(Project project)
        {
            using (var db = new TimeTrackContext())
            {
                db.Projects.Add(project);
                db.SaveChanges();            
            }            
        }
        [OperationContract]
        public void UpdateProject(Project project)
        {
            using (var db = new TimeTrackContext())
            {
                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
            }             
        }

        [OperationContract]
        public void DeleteProjectById(int id)
        {
            using (var db = new TimeTrackContext())
            {
                Project project = db.Projects.Find(id);
                db.Projects.Remove(project);
                db.SaveChanges();
            }            
        }
    }
}
