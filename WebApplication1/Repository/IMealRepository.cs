using System.Collections.Generic;
using StudentenMaaltijd.Web.Models;

namespace StudentenMaaltijd.Web.Repository
{
    public interface IMealRepository
    {
        IEnumerable<Meal> GetMeals();
        Meal GetMeal(int id);
        void AddMeal(Meal meal);
    }
}