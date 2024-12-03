using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web.CustFilter
{
    public class FarmerAuth : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("TraderFarmerID") == null)
            {
                context.Result = new RedirectToActionResult("Login", "Farmer", new { area = "" });
            }
        }
    }
}
