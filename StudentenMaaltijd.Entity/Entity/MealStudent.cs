using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentenMaaltijd.Entity.Entity
{
    public class MealStudent
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }

        public string Role { get; set; }
    }
}