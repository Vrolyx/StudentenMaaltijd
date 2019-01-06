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