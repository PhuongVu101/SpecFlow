using NUnit.Framework;
using TechTalk.SpecFlow;
using UniversityManager.DataAccess.Entity;
using UniversityManager.Test.Mocker;

namespace UniversityManager.Test.Steps
{
    [Binding]
    [Scope(Feature = "StudentService")]
    public class StudentServiceStep
    {
        StudentDataSet student;

        [BeforeScenario]
        public void BeforeScenario()
        {
            student = null;
        }


        [When(@"I call FindStudentByID '(.*)'")]
        public void WhenICallFindStudentByID(int p0)
        {
            student = StudentRepositoryMocker.studentRepository.Object.FindStudentByID(p0);
        }


        [Then(@"I found the student")]
        public void ThenIFoundTheStudent()
        {
            Assert.IsTrue(student != null);
        }


        [Then(@"I did not find the student")]
        public void ThenIDidNotFindTheStudent()
        {
            Assert.IsTrue(student == null);
        }


    }
}
