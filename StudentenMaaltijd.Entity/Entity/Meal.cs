using System;
using System.Collections.Generic;

namespace StudentenMaaltijd.Entity.Entity
{
    public class Meal
    {
        public Meal(int mealId, string mealName, DateTime preperationTime, string description, int maxAllowedGuests, decimal price, int studentId)
        {
            MealId = mealId;
            MealName = mealName;
            PreperationTime = preperationTime;
            Description = description;
            MaxAllowedGuests = maxAllowedGuests;
            Price = price;
            StudentId = studentId;
        }

        public int MealId { get; set; }
        
        public string MealName { get; set; }
        
        public DateTime PreperationTime { get; set; }
        
        public String Description { get; set; }
        
        public int MaxAllowedGuests { get; set; }
        
        public decimal Price { get; set; }

        public Student Student;
        public int? StudentId { get; set; }
        
        public virtual ICollection<MealStudent> MealStudents { get; set; }
    }
}