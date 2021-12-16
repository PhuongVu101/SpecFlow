using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManager.Service.Model
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int YearOld { get; set; }
    }
}
