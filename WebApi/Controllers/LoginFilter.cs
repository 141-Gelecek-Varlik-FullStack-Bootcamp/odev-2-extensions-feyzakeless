using Extension;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;

namespace WebApi.Controllers
{
    public class LoginFilter : Attribute, IActionFilter
    {
        string[] userType = Extension.Extensions.GetEnum(Extension.Enum.UserType2).Split("-");

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var action = context.HttpContext.GetRouteData().Values["action"].ToString();
            if (action == "LoginAuthorized" && userType[1] != "Yetkili")
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Error" }));
            }


            
        }
    }
}
