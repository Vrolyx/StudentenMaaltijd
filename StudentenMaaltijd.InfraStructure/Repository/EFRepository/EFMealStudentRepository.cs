using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentenMaaltijd.Entity.Entity;
using StudentenMaaltijd.Entity.Repository;
using StudentenMaaltijd.Entity.Repository.DbContext;

namespace StudentenMaaltijd.InfraStructure.Repository.EFRepository
{
    public class EFMealStudentRepository : IMealStudentRepository
    {
        private readonly ApplicationDbContext _context;

        // Constructor
        public EFMealStudentRepository(ApplicationDbContext context) => _context = context;

        /**
         * Get all mealstudents
         */
        public IEnumerable<MealStudent> GetMealStudents()
        {
            return _context.MealStudents.ToList();
        }

        /**
         * Get mealstudents by id
         */
        public MealStudent GetMealStudent(int id)
        {
            return _context.MealStudents.Find(id);
        }

        /**
         * Add mealstudent to database
         */
        public void AddMealStudent(MealStudent mealStudent)
        {
            _context.MealStudents.Add(mealStudent);
            _context.SaveChanges();
        }
    }
}
