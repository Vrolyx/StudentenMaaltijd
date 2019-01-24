using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentenMaaltijd.Entity.Entity;

namespace StudentenMaaltijd.Web.Models
{
    public class MealDetailView
    {
        public int MealId { get; set; }
        public string MealName { get; set; }

        public DateTime PreperationTime { get; set; }

        public String Description { get; set; }

        public int MaxAllowedGuests { get; set; }

        public decimal Price { get; set; }

        public IEnumerable<Student> Students { get; set; }

        public MealDetailView(Meal meal, IEnumerable<Student> students)
        {
            this.MealId = meal.MealId;
            this.MealName = meal.MealName;
            this.Description = meal.Description;
            this.MaxAllowedGuests = meal.MaxAllowedGuests;
            this.Price = meal.Price;
            this.Students = students;
        }
    }
}
