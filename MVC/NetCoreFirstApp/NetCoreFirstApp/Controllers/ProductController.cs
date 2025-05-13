using Microsoft.AspNetCore.Mvc;

namespace NetCoreFirstApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        
    }
}
