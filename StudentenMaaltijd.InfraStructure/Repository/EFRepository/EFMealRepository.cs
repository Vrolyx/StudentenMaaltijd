using System;
using System.Collections.Generic;
using System.Linq;
using StudentenMaaltijd.Entity.Entity;
using StudentenMaaltijd.Entity.Repository.DbContext;

namespace StudentenMaaltijd.Entity.Repository.EFRepository
{
    public class EFMealRepository : IMealRepository
    {
        private readonly ApplicationDbContext _context;
        
        // Constructor
        public EFMealRepository(ApplicationDbContext context) => _context = context;
        
        /**
         * Get all meals
         */
        public IEnumerable<Meal> GetMeals()
        {
            return _context.Meals.ToList();
        }

        /**
         * Get meals by id
         */
        public Meal GetMeal(int id)
        {
            return _context.Meals.Find(id);
        }

        public void EditMeal(Meal meal)
        {
           _context.Entry(this.GetMeal(meal.MealId)).CurrentValues.SetValues(meal);
           _context.SaveChanges();
        }

        /**
         * Add meal to database
         */
        public void AddMeal(Meal meal)
        {
            _context.Meals.Add(meal);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Meals.Remove(this.GetMeal(id));
            _context.SaveChanges();
        }

        public IEnumerable<Meal> GetMealsWithinTwoWeeks()
        {
            var startDate = DateTime.Now;
            var endDate = DateTime.Now.AddDays(14);

            return _context.Meals.Where(m => m.PreperationTime >= startDate && m.PreperationTime <= endDate);
        }

        public IEnumerable<Student> GetStudentsMeal(int mealId)
        {
            return _context.Students.Where(s => s.MealStudents.Any(m => m.Meal.MealId == mealId));
        }

        /*public Student GetCook(int mealId)
        {
            return _context.Students.Find());
        }*/
    }
}