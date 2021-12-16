using Moq;
using System.Linq;
using TechTalk.SpecFlow;
using UniversityManager.Model.Repository;
using UniversityManager.Test.EntityHelper;

namespace UniversityManager.Test.Mocker
{
    [Binding]
    public static class StudentRepositoryMocker
    {
        public static Mock<IStudentRepository> studentRepository;

        [Given(@"A mock of IStudentRepository")]
        public static void GivenAMockOfIStudentRepository()
        {
            studentRepository = new Mock<IStudentRepository>();
        }


        [Given(@"Mock function FindStudentByID with data students")]
        public static void GivenMockFunctionFindStudentByIDWithDataStudents()
        {
            studentRepository.Setup(r => r.FindStudentByID(It.IsAny<int>())).Returns<int>((id) =>StudentHelper.students.FirstOrDefault(s=>s.StudentID == id));
        }

        [Then(@"Function FindStudentByID is called '(.*)' times")]
        public static void ThenFunctionFindStudentByIDIsCalledTimes(int p0)
        {
            studentRepository.Verify(o => o.FindStudentByID(It.IsAny<int>()), Times.Exactly(p0));
        }

    }
}
