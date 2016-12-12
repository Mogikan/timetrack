using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrack.Model
{
    [Table("Project")]
    [DataContract]
    public class Project
    {
        [Column("id_project")]
        [DataMember]
        public int Id { get; set; }
        [Column("fk_employee")]
        [DataMember]
        public int FKProjectManager {get;set;}
        [Column("name")]
        [DataMember]
        public string Name { get; set; }
        [Column("closed")]
        [DataMember]
        public int Closed { get; set; }
        [Column("startDate")]
        [DataMember]
        public DateTime StartDate { get; set; }
        [Column("finishDate")]
        [DataMember]
        public DateTime FinishDate { get; set; }
        [ForeignKey("FKProjectManager")]
        [DataMember]
        public Employee ProjectManager { get; set; }
    }
}
