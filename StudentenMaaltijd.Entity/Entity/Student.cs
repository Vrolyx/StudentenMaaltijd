using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentenMaaltijd.Entity.Entity
{
    public class Student
    {
        public Student(int studentId, string studentName, string email, string phoneNumber)
        {
            StudentId = studentId;
            StudentName = studentName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public int StudentId { get; set; }
        
        public string StudentName { get; set; }
        
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        
        public virtual ICollection<MealStudent> MealStudents { get; set; }
    }
}