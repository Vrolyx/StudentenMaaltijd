using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentenMaaltijd.Entity.Entity;
using StudentenMaaltijd.Entity.Repository;

namespace StudentenMaaltijd.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MealStudentController : ControllerBase
    {
        private readonly IMealStudentRepository _repository;

        public MealStudentController(IMealStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<MealStudent> GetMealStudentItems()
        {
            return _repository.GetMealStudents();
        }

        [HttpGet("{id}")]
        public MealStudent GetMealStudentById(int id)
        {
            return _repository.GetMealStudent(id);
        }
    }
}