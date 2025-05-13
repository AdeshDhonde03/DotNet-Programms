using Microsoft.AspNetCore.Mvc.Filters;

namespace ItBoostUp.PresentationLayer.Filters
{
    public class CustomActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Custom Logic
            Console.WriteLine("On ActionExecuting called");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Custom Logic
            Console.WriteLine("On ActionExecuted called");
        }
    }
}
