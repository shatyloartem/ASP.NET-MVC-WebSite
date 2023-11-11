using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly PeopleDataModel _usersDataModel;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _usersDataModel = new PeopleDataModel();
        }

        public ViewResult ShowUsers()
        {
            return View(_usersDataModel.GetUsers());
        }
        
        public IActionResult OpenUserPage(int personId)
        {
            return View(_usersDataModel.GetExtendedUsers().ToArray()[personId]);
        }

        public ViewResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(string name, string surname, string description, string email)
        {
            var user = new PersonExtended(_usersDataModel.GetFreeId(), name, surname, email, DateTime.Now,
                description);
            
            _usersDataModel.AddUser(user);

            return View(user);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}