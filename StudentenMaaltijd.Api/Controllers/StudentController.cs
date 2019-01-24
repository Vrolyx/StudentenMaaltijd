using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentenMaaltijd.Entity.Entity;
using StudentenMaaltijd.Entity.Repository;

namespace StudentenMaaltijd.Api.Controllers
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