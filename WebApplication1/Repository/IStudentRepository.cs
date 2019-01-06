using System.Collections.Generic;
using StudentenMaaltijd.Web.Models;

namespace StudentenMaaltijd.Web.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student GetStudent(int id);
        void AddStudent(Student student);
    }
}