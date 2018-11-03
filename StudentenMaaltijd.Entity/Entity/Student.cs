using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentenMaaltijd.Entity.Entity
{
    public class Student
    {
        public int StudentId { get; set; }
        
        public string StudentName { get; set; }
        
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        
        public virtual IEnumerable<MealStudent> MealStudents { get; set; }
    }
}