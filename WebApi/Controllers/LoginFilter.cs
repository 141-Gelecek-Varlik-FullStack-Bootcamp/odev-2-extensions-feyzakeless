using Extension;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;

namespace WebApi.Controllers
{
    public class LoginFilter : Attribute, IActionFilter
    {
        //Get Enum Type As Array
        //For Unauthorized User = UserType3
        string[] userType = Extension.Extensions.GetEnum(Extension.Enum.UserType1).Split("-"); //Authorized User

        // When Entered the Method
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //Show Logged in User
            var result = userType[0] + ", başarıyla giriş yaptı.";
        }

        // First Condition
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
