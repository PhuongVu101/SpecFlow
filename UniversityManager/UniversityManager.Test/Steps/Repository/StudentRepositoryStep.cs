using NUnit.Framework;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UniversityManager.DataAccess.Entity;
using UniversityManager.Model.Repository;
using UniversityManager.Test.EntityHelper;

namespace UniversityManager.Test.Steps
{
    [Binding]
    [Scope(Feature = "StudentRepository")]
    public class StudentRepositoryStep: BaseRepositoryStep
    {
        private StudentDataSet student;
        private List<StudentDataSet> students;

        [BeforeScenario]
        public void BeforeScenario()
        {
            InitialiseDatabase();
            student = null;
            students = null;
        }


        [Given(@"The students in Database")]
        public void GivenTheStudentInDatabase(Table table)
        {
            List<StudentDataSet> students = StudentHelper.GivenTheStudents(table);
            dbContext.Students.AddRange(students);
            dbContext.SaveChanges();
        }


        #region FindStudentByID
        [When(@"I call FindStudentByID '(.*)'")]
        public void WhenICallFindStudentByID(int p0)
        {
            StudentRepository repo = new StudentRepository(dbContext);
            student = repo.FindStudentByID(p0);
        }

        [Then(@"I found student")]
        public void ThenIFoundStudent()
        {
            Assert.IsTrue(this.student != null,"Student not found");
        }

        [Then(@"I do not find student")]
        public void ThenIDoNotFindStudent()
        {
            Assert.IsTrue(this.student == null, "Student not found");
        }
        #endregion

        #region FindStudentByBirthYear
        [When(@"I call FindStudentByBirthYear '(.*)'")]
        public void WhenICallFindStudentByBirthYear(int p0)
        {
            StudentRepository repo = new StudentRepository(dbContext);
            students = repo.FindStudentByBirthYear(p0);
        }

        [Then(@"I found '(.*)' students")]
        public void ThenIFoundStudents(int p0)
        {
            Assert.AreEqual(p0,students.Count);
        }

        #endregion
    }
}
