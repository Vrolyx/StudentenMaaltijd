using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentenMaaltijd.Entity.Entity
{
    public class MealStudent
    {
        public MealStudent(int studentId, int mealId, string role)
        {
            StudentId = studentId;
            MealId = mealId;
            Role = role;
        }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public string Role { get; set; }
    }
}