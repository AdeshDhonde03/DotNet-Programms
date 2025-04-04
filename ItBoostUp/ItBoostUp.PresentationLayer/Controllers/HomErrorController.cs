using Microsoft.AspNetCore.Mvc;

namespace ItBoostUp.PresentationLayer.Controllers
{
    public class HomErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
