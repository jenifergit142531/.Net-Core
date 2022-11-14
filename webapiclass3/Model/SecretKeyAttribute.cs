using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace webapiclass3.Model
{
    public class SecretKeyAttribute : Attribute, IAsyncActionFilter
    {
        private const string APIKEYNAME = "SecretKey";

        //Check to see if the key is provided on the request header
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
           if(!context.HttpContext.Request.Headers.TryGetValue(APIKEYNAME,out var extractedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Secret key not provided"
                };
                return;
            }


            var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();

            var apiKey = appSettings.GetValue<string>(APIKEYNAME);

            //check for the authentication

            if(!apiKey.Equals(extractedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "SECRET KEY IS NOT VALID"
                };
                return;
            }

            await next();




        }
    }
}
