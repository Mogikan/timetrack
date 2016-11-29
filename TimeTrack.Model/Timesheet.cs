using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrack.Model
{
    [Table("Timesheet")]
    [DataContract]
    public class Timesheet
    {
        [Key]
        [Column("id_timesheet")]
        [DataMember]
        public int Id { get; set; }
        [Column("fk_employee")]
        [DataMember]
        private int FkEmployee { get; set; }
        [Column("fk_project")]
        [DataMember]
        private int FkProject { get; set; }
        [Column("Date")]
        [DataMember]
        public DateTime Date { get; set; }
        [Column("SpendTime")]
        [DataMember]
        public double SpendTime { get; set; }
        [Column("notes")]
        [DataMember]
        public string Notes { get; set; }
        [ForeignKey("FkEmployee")]
        public Employee Employee { get; set; }
        [ForeignKey("FkProject")]
        public Project Project { get; set; }
    }
}
