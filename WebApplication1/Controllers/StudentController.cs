using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentenMaaltijd.Web.Models;
using StudentenMaaltijd.Web.Repository;

namespace StudentenMaaltijd.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Student> GetStudentItems()
        {
            return _repository.GetStudents();
        }

        [HttpGet("{id}")]
        public Student GetMealById(int id)
        {
            return _repository.GetStudent(id);
        }
    }
}