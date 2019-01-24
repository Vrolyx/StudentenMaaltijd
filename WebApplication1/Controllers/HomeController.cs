using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentenMaaltijd.Entity.Repository;
using StudentenMaaltijd.Web.Models.ViewModels;

namespace StudentenMaaltijd.Web.Controllers
{
    public class HomeController : Controller
    {
        private IMealRepository repository;

        public HomeController(IMealRepository repoService)
        {
            repository = repoService;
        }

        public IActionResult Index()
        {
            return View(repository.GetMealsWithinTwoWeeks());
        }
    }
}