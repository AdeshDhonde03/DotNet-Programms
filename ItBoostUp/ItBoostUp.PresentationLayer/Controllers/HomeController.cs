using ItBoostUp.BuisnessLayer.Models;
using ItBoostUp.PresentationLayer.Filters;
using ItBoostUp.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ItBoostUp.PresentationLayer.Controllers
{
    // Controller level filter registration
    //[ServiceFilter(typeof(CustomExceptionFilter))]
    //[ServiceFilter(typeof(CustomActionFilter))]
    //[ServiceFilter(typeof(CustomAuthorizationFilter))]
    //[ServiceFilter(typeof(CustomResultFilter))]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            //int z = 0;
            //var r = 1 / z;
            return View();
        }

        [ServiceFilter(typeof(CustomAuthorizationFilter))]
        public IActionResult Privacy()
        {
            return View();
        }

        [ServiceFilter(typeof(CustomResultFilter))]
        public IActionResult Test()
        {
            List<Company> list = new List<Company>();

            list.Add(new Company{ Id = 1, Name = "TCS", Address = "Pune" });
            list.Add(new Company{ Id = 2, Name = "Wipro", Address = "Pune" });
            list.Add(new Company{ Id = 3, Name = "Infy", Address = "Pune" });

            return Json(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            return View();
        }

        public IActionResult UnAuthorization()
        {
            return View();
        }
    }
}
