using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int FkEmployee { get; set; }
        [Column("fk_project")]
        [DataMember]
        public int FkProject { get; set; }
        [Column("Date")]
        [DataMember]
        [DisplayName("Date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
        [Column("SpendTime")]
        [DataMember]
        [DisplayName("Spent time")]
        public double SpendTime { get; set; }
        [Column("notes")]
        [DisplayName("Notes")]
        [DataMember]
        public string Notes { get; set; }
        [ForeignKey("FkEmployee")]
        [DataMember]
        [DisplayName("Employee")]
        public Employee Employee { get; set; }
        [ForeignKey("FkProject")]
        [DataMember]
        [DisplayName("Project")]
        public Project Project { get; set; }
    }
}
