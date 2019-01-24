using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentenMaaltijd.Entity.Entity;
using StudentenMaaltijd.Entity.Repository;

namespace StudentenMaaltijd.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private readonly IMealRepository _repository;

        public MealController(IMealRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Meal> GetMealItems()
        {
            return _repository.GetMeals();
        }

        [HttpGet("{id}")]
        public Meal GetMealById(int id)
        {
            return _repository.GetMeal(id);
        }
    }
}