using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManager.DataAccess.Entity
{

    [Table("Student", Schema = "dbo")]
    public class StudentDataSet
    {
        [Key]
        [Column("StudentID")]
        public int StudentID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Birthday")]
        public DateTime Birthday { get; set; }
    }
}
