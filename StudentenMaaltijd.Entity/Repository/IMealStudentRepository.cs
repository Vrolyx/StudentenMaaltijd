using System;
using System.Collections.Generic;
using System.Text;
using StudentenMaaltijd.Entity.Entity;

namespace StudentenMaaltijd.Entity.Repository
{
    public interface IMealStudentRepository
    {
        IEnumerable<MealStudent> GetMealStudents();
        MealStudent GetMealStudent(int id);
        void AddMealStudent(MealStudent mealStudent);
    }
}
