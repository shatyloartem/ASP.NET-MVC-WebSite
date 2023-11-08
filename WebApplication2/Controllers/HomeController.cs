using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private List<string> _people; 
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _people = new List<string>() { "Artem", "Viktoria", "Bebra" };
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult ShowPeople()
        {
            return View(_people);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}