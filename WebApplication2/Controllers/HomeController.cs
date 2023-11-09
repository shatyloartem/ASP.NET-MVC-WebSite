using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly PeopleDataModel _peopleDataModel;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _peopleDataModel = new PeopleDataModel();
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult ShowPeople()
        {
            return View(_peopleDataModel.GetPeople());
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult OpenPersonPage(int personId)
        {
            return View(_peopleDataModel.GetExtendedPeople().ToArray()[personId]);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}