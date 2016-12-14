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
        [DisplayName("Project name")]
        public string Name { get; set; }
        [Column("closed")]        
        public int Closed { get; set; }
        [DataMember]
        [NotMapped]
        [DisplayName("Project terminated")]
        public bool IsClosed
        {
            get
            {
                return Convert.ToBoolean(Closed);
            }
            set
            {
                Closed = Convert.ToInt32(value);
            }
        }

        [Column("startDate")]
        [DataMember(IsRequired = false)]
        [DisplayName("Start date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? StartDate { get; set; }
        [Column("finishDate")]
        [DisplayName("Finish date")]
        [DataMember(IsRequired =false)]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FinishDate { get; set; }
        [ForeignKey("FKProjectManager")]
        [DataMember]
        [DisplayName("Project manager")]
        public Employee ProjectManager { get; set; }
    }
}
