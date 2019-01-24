using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentenMaaltijd.Entity.Entity;
using StudentenMaaltijd.Entity.Repository;

namespace StudentenMaaltijd.Web.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository repository;

        public StudentController(IStudentRepository repoService)
        {
            repository = repoService;
        }

        public ViewResult Index() =>
            View(repository.GetStudents());

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var student = new Student(){ Email = collection["Email"], PhoneNumber = collection["PhoneNumber"], StudentName = collection["StudentName"]};
                repository.AddStudent(student);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}