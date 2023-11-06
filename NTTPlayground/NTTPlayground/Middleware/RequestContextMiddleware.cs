using EntityModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace NTTPlayground.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RequestContextMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestContextMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext,MyRequestContext rc)
        {
            rc.FacilityId = DateTime.UtcNow.Second;
            var res = System.Text.Json.JsonSerializer.Serialize(rc);
            httpContext.Request.Headers.Add("myrequestcontext",res);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RequestContextMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestContextMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestContextMiddleware>();
        }
    }
}
