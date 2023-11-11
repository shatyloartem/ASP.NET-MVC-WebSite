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

        public ViewResult UsersList()
        {
            return View(_usersDataModel.GetUsers());
        }
        
        public IActionResult UserPage(int personId)
        {
            return View(_usersDataModel.GetUserById(personId));
        }

        public ViewResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnUserCreated(string name, string surname, string description, string email)
        {
            var user = new User(_usersDataModel.GetFreeId(), name, surname, email, description, DateTime.Now);
            
            _usersDataModel.AddUser(user);

            return UserPage(user.Id);
        }

        [HttpPost]
        public IActionResult RemoveUser()
        {
            _usersDataModel.RemoveUserById(Int32.Parse(Request.Form["Action:Delete"]));
            
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}