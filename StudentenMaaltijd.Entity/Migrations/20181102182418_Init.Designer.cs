﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentenMaaltijd.Entity.Repository.DbContext;

namespace StudentenMaaltijd.Entity.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181102182418_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentenMaaltijd.Entity.Entity.Meal", b =>
                {
                    b.Property<int>("MealId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("MaxAllowedGuests");

                    b.Property<string>("MealName");

                    b.Property<DateTime>("PreperationTime");

                    b.Property<decimal>("Price");

                    b.Property<int?>("StudentId");

                    b.HasKey("MealId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("StudentenMaaltijd.Entity.Entity.MealStudent", b =>
                {
                    b.Property<int>("MealId");

                    b.Property<int>("StudentId");

                    b.Property<string>("Role");

                    b.HasKey("MealId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("MealStudents");
                });

            modelBuilder.Entity("StudentenMaaltijd.Entity.Entity.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("StudentName");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentenMaaltijd.Entity.Entity.MealStudent", b =>
                {
                    b.HasOne("StudentenMaaltijd.Entity.Entity.Meal", "Meal")
                        .WithMany("MealStudents")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StudentenMaaltijd.Entity.Entity.Student", "Student")
                        .WithMany("MealStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
