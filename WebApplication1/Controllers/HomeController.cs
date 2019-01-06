using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentenMaaltijd.Web.Models.ViewModels;
using StudentenMaaltijd.Web.Repository;

namespace StudentenMaaltijd.Web.Controllers
{
    public class HomeController : Controller
    {
        
        private IStudentRepository repo;
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}