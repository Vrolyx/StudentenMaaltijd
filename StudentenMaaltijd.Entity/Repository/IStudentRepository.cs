using System.Collections.Generic;
using StudentenMaaltijd.Entity.Entity;

namespace StudentenMaaltijd.Entity.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student GetStudent(int id);
        void AddStudent(Student student);
    }
}