using EntityModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FacilityDataMigrationScaffoldApi.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RequestContextResolverMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestContextResolverMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext,MyRequestContext rc)
        {
            //string rcvalue = "";
            var rcHeader = httpContext.Request.Headers["myrequestcontext"].FirstOrDefault();
            if(rcHeader != null)
            {
                var rcHeaderValue = System.Text.Json.JsonSerializer.Deserialize<MyRequestContext>(rcHeader);
                rc.FacilityId = rcHeaderValue.FacilityId;

            }
            
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RequestContextResolverMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestContextResolverMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestContextResolverMiddleware>();
        }
    }
}
