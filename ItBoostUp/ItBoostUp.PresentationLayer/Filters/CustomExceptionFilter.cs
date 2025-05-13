using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Logger;

namespace ItBoostUp.PresentationLayer.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly IConfiguration _configuration;
        private string logFolder;

        public CustomExceptionFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnException(ExceptionContext context)
        {
            string exception = context.Exception.Message;

            logFolder = _configuration.GetValue<string>("LogFile:LoggerPath");

            Logger.Logger.Log("Error", exception, logFolder);

            context.ExceptionHandled = true;
            context.Result = new RedirectToActionResult("Error","Home" , null);
        }
    }
}
