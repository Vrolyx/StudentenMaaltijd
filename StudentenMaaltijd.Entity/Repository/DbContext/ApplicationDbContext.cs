using System;
using Microsoft.EntityFrameworkCore;
using StudentenMaaltijd.Entity.Entity;

namespace StudentenMaaltijd.Entity.Repository.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
//        public ApplicationDbContext() { }
//
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }
        
        // Database table set
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<MealStudent> MealStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLExpress;Database=StudentenMaaltijdDB;Trusted_Connection=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // DummyData
            
            // Meals
            Meal m1 = new Meal(1, "Chili con carne", DateTime.Now, "Super lekkere Chili", 6, 7.00m, 1);
            Meal m2 = new Meal(2, "Spaghetti", DateTime.Now, "Super lekkere spaghetti", 6, 2.00m, 1);
            Meal m3 = new Meal(3, "Stampot", DateTime.Now, "Super lekkere stampot", 6, 5.00m, 1);
            
            // Students
            Student s1 = new Student(1, "Wessel Vrolijks", "wessel.vrolijks@gmail.com", "0681839791");
            Student s2 = new Student(2, "Ruben van Goor", "rvgoor@gmail.com", "0612345678");
            Student s3 = new Student(3, "Milan van Bergen", "mvbergen@gmail.com", "06456925");
            Student s4 = new Student(4, "Stijn van Wichen", "svwichen@gmail.com", "0642376589");
            Student s5 = new Student(5, "Derk de Groot", "ddgroot@gmail.com", "0612078506");
            
            // MealStudent
            MealStudent ms1 = new MealStudent(3, 3, "kok");
            MealStudent ms2 = new MealStudent(1, 3, "gast");
            MealStudent ms3 = new MealStudent(2, 3, "gast");
            MealStudent ms4 = new MealStudent(4, 3, "gast");
            
            
            // ModelBuilders
            // Mealstudent keys
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
        }
        
    }
}