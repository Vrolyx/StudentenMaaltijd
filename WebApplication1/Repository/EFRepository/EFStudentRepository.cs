using System.Collections.Generic;
using System.Linq;
using StudentenMaaltijd.Web.Repository.DbContext;
using StudentenMaaltijd.Web.Models;

namespace StudentenMaaltijd.Web.Repository.EFRepository
{
    public class EFStudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        
        // Constructor
        public EFStudentRepository(ApplicationDbContext context) => _context = context;
        
        /**
         * Get all students
         */
        public IEnumerable<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        /**
         * Get student by id
         */
        public Student GetStudent(int id)
        {
            return _context.Students.Find(id);
        }

        /**
         * Add student to database
         */
        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}