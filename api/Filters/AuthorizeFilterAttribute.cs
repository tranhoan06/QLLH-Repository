using api.Constants;
using api.Models.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;

namespace api.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorizeFilterAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Retrieve the Authorization header
            var tokenHeader = context.HttpContext.Request.Headers["Authorization"];

            // Check if the header is null or empty using StringValues
            if (StringValues.IsNullOrEmpty(tokenHeader))
            {
                context.Result = new OkObjectResult(new DefaultResponse().Error("Authorization is null", ApiConstants.StatusCode.Error401))
                {
                    StatusCode = ApiConstants.StatusCode.Error401
                };
            }
        }
    }
}