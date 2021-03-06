using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentenMaaltijd.Entity.Entity
{
    public class Meal
    {
        [Key]
        public int MealId { get; set; }
        
        public string MealName { get; set; }
        
        public DateTime PreperationTime { get; set; }
        
        public String Description { get; set; }
        
        public int MaxAllowedGuests { get; set; }
        
        public decimal Price { get; set; }

        public virtual IEnumerable<MealStudent> MealStudents { get; set; }
    }
}