using Microsoft.AspNetCore.Mvc;

namespace AreaExample.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LogInController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
