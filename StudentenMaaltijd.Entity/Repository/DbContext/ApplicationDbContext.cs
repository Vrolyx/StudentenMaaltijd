using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using StudentenMaaltijd.Entity.Entity;

namespace StudentenMaaltijd.Entity.Repository.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLExpress;Database=StudentenMaaltijdDB;Trusted_Connection=True;"
            );
        }

        // Database table set
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<MealStudent> MealStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // DummyData
            // Meals
            var mealList = new List<Meal>()
            {
                new Meal(){ MealId = 1, MealName = "Chili con carne", PreperationTime = DateTime.Now, Description = "Super lekkere Chili", MaxAllowedGuests = 6, Price = 7.00m },
                new Meal(){ MealId = 2, MealName = "Spaghetti", PreperationTime = DateTime.Now, Description = "Super lekkere spaghetti",MaxAllowedGuests = 6, Price = 2.00m },
                new Meal(){ MealId = 3, MealName = "Stampot", PreperationTime = DateTime.Now, Description = "Super lekkere stampot", MaxAllowedGuests = 6, Price = 5.00m }
            };

            // Students
            var studentList = new List<Student>()
            {
                new Student(){StudentId = 1, StudentName = "Wessel Vrolijks", Email = "wessel.vrolijks@gmail.com",PhoneNumber = "0681839791"},
                new Student(){StudentId = 2, StudentName = "Ruben van Goor", Email = "rvgoor@gmail.com",PhoneNumber = "0612345678"},
                new Student(){StudentId = 3, StudentName = "Milan van Bergen", Email = "mvbergen@gmail.com",PhoneNumber = "06456925"},
                new Student(){StudentId = 4, StudentName = "Stijn van Wichen", Email = "svwichen@gmail.com",PhoneNumber = "0642376589"},
                new Student(){StudentId = 5, StudentName = "Derk de Groot", Email = "ddgroot@gmail.com",PhoneNumber = "0612078506"},    
            };
            


            // MealStudent
            var mealStudentList = new List<MealStudent>()
            {
                new MealStudent() {StudentId = 3, MealId = 3, Role = "kok"},
                new MealStudent() {StudentId = 1, MealId = 3, Role = "gast"},
                new MealStudent() {StudentId = 2, MealId = 3, Role = "gast"},
                new MealStudent() {StudentId = 4, MealId = 3, Role = "gast"},
            };
            
            
            // ModelBuilders
            // Mealstudent assign keys
            modelBuilder.Entity<MealStudent>()
                .HasKey(ms => new {ms.MealId, ms.StudentId});
            
            // Meal bind
            modelBuilder.Entity<MealStudent>()
                .HasOne(ms => ms.Meal)
                .WithMany(m => m.MealStudents)
                .HasForeignKey(ms => ms.MealId);
            
            // Student bind
            modelBuilder.Entity<MealStudent>()
                .HasOne(ms => ms.Student)
                .WithMany(s => s.MealStudents)
                .HasForeignKey(ms => ms.StudentId);
            
            // Add Dummydata to database
            modelBuilder.Entity<MealStudent>().HasData(mealStudentList);
            modelBuilder.Entity<Student>().HasData(studentList);
            modelBuilder.Entity<Meal>().HasData(mealList);
        }
    }
}