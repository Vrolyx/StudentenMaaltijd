using System.Collections.Generic;
using StudentenMaaltijd.Entity.Entity;

namespace StudentenMaaltijd.Entity.Repository
{
    public interface IMealRepository
    {
        IEnumerable<Meal> GetMeals();
        Meal GetMeal(int id);
        void AddMeal(Meal meal);
        void EditMeal(Meal meal);
        void Delete(int id);
        IEnumerable<Meal> GetMealsWithinTwoWeeks();
        IEnumerable<Student> GetStudentsMeal(int id);
    }
}