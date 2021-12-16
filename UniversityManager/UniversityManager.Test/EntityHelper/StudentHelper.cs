using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using UniversityManager.DataAccess.Entity;

namespace UniversityManager.Test.EntityHelper
{
    [Binding]
    public class StudentHelper
    {
        public static List<StudentDataSet> students;

        [Given(@"The students")]
        public static List<StudentDataSet> GivenTheStudents(Table table)
        {
            students = new List<StudentDataSet>();
            foreach (TableRow row in table.Rows)
            {
                StudentDataSet student = new StudentDataSet();

                if (table.ContainsColumn("StudentID"))
                {
                    student.StudentID = int.Parse(row["StudentID"]);
                }

                if (table.ContainsColumn("Name"))
                {
                    student.Name = row["Name"];
                }

                if (table.ContainsColumn("Birthday"))
                {
                    student.Birthday = DateTime.Parse(row["Birthday"]);
                }

                students.Add(student);
            }
            return students;
        }



    }
}
