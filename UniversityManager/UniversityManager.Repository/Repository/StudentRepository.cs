using System.Collections.Generic;
using System.Linq;
using UniversityManager.DataAccess;
using UniversityManager.DataAccess.Entity;

namespace UniversityManager.Model.Repository
{
    public interface IStudentRepository 
    {
        StudentDataSet FindStudentByID(int studentID);
        List<StudentDataSet> FindStudentByBirthYear(int year);
    }

    public class StudentRepository : IStudentRepository
    {

        public UniversityManagerDbContext dbContext { get; set; }

        public StudentRepository(UniversityManagerDbContext context) 
        {
            dbContext = context;
        }

        public StudentDataSet FindStudentByID(int studentID)
        {
            StudentDataSet student = dbContext.Students.Where(t => t.StudentID == studentID).FirstOrDefault();
            return student;
        }


        public List<StudentDataSet> FindStudentByBirthYear(int year)
        {
            List<StudentDataSet> students = dbContext.Students.Where(t => t.Birthday.Year == year).ToList();
            return students;
        }
    }
}
