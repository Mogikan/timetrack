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
        #region Projects
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
        #endregion
        #region Employees
        [OperationContract]
        public IList<Employee> GetEmployees()
        {
            using (var db = new TimeTrackContext())
            {
                return db.Employees.ToList();
            }            
        }        
        [OperationContract]
        public Employee GetEmployeeById(int? id)
        {
            using (var db = new TimeTrackContext())
            {
                return db.Employees.Find(id);
            }
        }
        [OperationContract]
        public void AddEmployee(Employee employee)
        {
            using (var db = new TimeTrackContext())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }            
        }
        [OperationContract]
        public void UpdateEmployee(Employee employee)
        {
            using (var db = new TimeTrackContext())
            { 
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();             
            }            
        }
        [OperationContract]
        public void DeleteEmployeeById(int id)
        {
            using (var db = new TimeTrackContext())
            {
                Employee employee = db.Employees.Find(id);
                db.Employees.Remove(employee);
                db.SaveChanges();
            }            
        }
        #endregion
        #region
        [OperationContract]
        public IList<Timesheet> GetTimeSheets()
        {
            using (var db = new TimeTrackContext())
            {
                var timesheets = db.Timesheets.Include(t => t.Employee).Include(t => t.Project);
                return timesheets.ToList();
            }
        }

        [OperationContract]
        public Timesheet GetTimeSheetById(int id)
        {
            using (var db = new TimeTrackContext())
            {
                return db.Timesheets.Find(id);
            }
        }
        [OperationContract]
        public void AddTimesheet(Timesheet timesheet)
        {
            using (var db = new TimeTrackContext())
            { 
                db.Timesheets.Add(timesheet);
                db.SaveChanges();             
            }
        }
        [OperationContract]
        public void UpdateTimeSheet(Timesheet timesheet)
        {
            using (var db = new TimeTrackContext())
            {
                db.Entry(timesheet).State = EntityState.Modified;
                db.SaveChanges();                
            }            
        }

        [OperationContract]
        public void DeleteTimesheetById(int id)
        {
            using (var db = new TimeTrackContext())
            {
                Timesheet timesheet = db.Timesheets.Find(id);
                db.Timesheets.Remove(timesheet);
                db.SaveChanges();
            }
        }        
        #endregion
    }
}
