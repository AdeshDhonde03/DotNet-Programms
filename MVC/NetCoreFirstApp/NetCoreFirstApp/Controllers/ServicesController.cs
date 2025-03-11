using Microsoft.AspNetCore.Mvc;
using NetCoreFirstApp.Models;

namespace NetCoreFirstApp.Controllers
{
    public class ServicesController : Controller
    {
        [HttpGet]
        public IActionResult MyServices()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MyServices(MyServiceModel myServiceModel)
        {
            return View(myServiceModel);
        }

        [HttpGet]
        public IActionResult Company()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Company(CompanyModel companyModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View(companyModel);
        }
       


    }

}
