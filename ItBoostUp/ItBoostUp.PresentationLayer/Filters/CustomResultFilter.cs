using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ItBoostUp.PresentationLayer.Filters
{
    public class CustomResultFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result != null)
            {
                if (context.Result is JsonResult jsonResult)
                {
                    var response = new
                    {
                        Status = "Success",
                        StatusCode = 200,
                        Data = jsonResult.Value
                    };
                    context.Result = new JsonResult(response);
                }
            }
        }
    }
}
