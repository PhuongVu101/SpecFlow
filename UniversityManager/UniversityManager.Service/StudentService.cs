using System.Collections.Generic;
using UniversityManager.DataAccess.Entity;
using UniversityManager.Model.Repository;
using UniversityManager.Service.Model;

namespace UniversityManager.Service
{
    public interface IStudentService
    {
        Student FindStudentByID(int studentID);
    }

    public class StudentService : IStudentService
    {
        private IStudentRepository StudentRepository { get; set; }
        public StudentService (IStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }

        public Student FindStudentByID(int studentID)
        {
            StudentDataSet studentDataSet = StudentRepository.FindStudentByID(studentID);
            Student student = new Student();
            student.Birthday = studentDataSet.Birthday;
            // doing calculation....
            return student;
        }
    }
}
