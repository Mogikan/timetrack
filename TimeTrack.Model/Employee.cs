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
    [Table("Employee")]
    [DataContract]
    public class Employee
    {
        [Key]
        [Column("id_employee")]
        [DataMember]        
        public int Id { get; set; }
        [Column("fullName")]
        [DisplayName("Full name")]
        [DataMember]
        public string FullName { get; set; }
    }
}
