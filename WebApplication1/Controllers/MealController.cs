using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentenMaaltijd.Entity.Entity;
using StudentenMaaltijd.Entity.Repository;
using StudentenMaaltijd.Web.Models;

namespace StudentenMaaltijd.Web.Controllers
{
    public class MealController : Controller
    {
        private IMealRepository repository;
        private MealDetailView mealDetailView;

        public MealController(IMealRepository repoService)
        {
            repository = repoService;
        }

        public ViewResult Index() =>
            View(repository.GetMeals());

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Meal meal)
        {
            try
            {
                repository.AddMeal(meal);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            MealDetailView view = new MealDetailView(repository.GetMeal(id), repository.GetStudentsMeal(id));
            return View(view);
        }

        public ActionResult Edit(int id)
        {
            return View(repository.GetMeal(id));
        }

        [HttpPost]
        public ActionResult Edit(Meal meal)
        {
            try
            {
                repository.EditMeal(meal);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                repository.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}