using Microsoft.AspNetCore.Mvc;
using poultry_management_system.web.Data;
using poultry_management_system.web.Models;
using poultry_management_system.web.Models.Domain;

using poultry_management_system.web.Models.ViewModels;
using System.Diagnostics;

namespace poultry_management_system.web.Controllers
{
    public class HomeController : Controller
    {
        PoultryDbContext _poultryDb;

        public HomeController(PoultryDbContext poultryDbContext)
        {
            _poultryDb = poultryDbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Index")]
        public IActionResult Index(AddUser addUser)
        {
            var user = new User
            {
                UserName = addUser.UserName,
                Password = addUser.Password

            };
            _poultryDb.Users.Add(user);
            _poultryDb.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        [ActionName("UserLogin")]
        public IActionResult UserLogin(AddUser addUser)
        {
            var user = _poultryDb.Users.FirstOrDefault( x => x.UserName == addUser.UserName );

            if(user != null && user.Password == addUser.Password)
            {
                return RedirectToAction("Add_Entry", "DailyEntry");
            }
            ViewData["ErrorMessage"] = "Invalid Id or Password.";
            return View("Index");
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
