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
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Timesheet> Timesheets { get; set; }
      
    }
}
