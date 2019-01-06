using System.Collections.Generic;
using System.Linq;
using StudentenMaaltijd.Web.Repository.DbContext;
using StudentenMaaltijd.Web.Models;

namespace StudentenMaaltijd.Web.Repository.EFRepository
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

        /**
         * Add meals to database
         */
        public void AddMeal(Meal meal)
        {
            _context.Meals.Add(meal);
            _context.SaveChanges();
        }
    }
}