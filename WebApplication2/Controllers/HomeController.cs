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

        public ViewResult ShowPeople()
        {
            return View(_peopleDataModel.GetPeople());
        }
        
        public IActionResult OpenPersonPage(int personId)
        {
            return View(_peopleDataModel.GetExtendedPeople().ToArray()[personId]);
        }

        public ViewResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(string name, string surname, string description, string email)
        {
            var user = new PersonExtended(_peopleDataModel.GetFreeId(), name, surname, email, DateTime.Now,
                description);
            
            _peopleDataModel.AddUser(user);

            return View(user);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}