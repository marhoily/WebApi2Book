using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using WebApi2Book.Common.Logging;
using WebApi2Book.Web.Common;
using WebApi2Book.Web.Common.ErrorHandling;

namespace WebApi2Book.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enables attribute-based routing
            config.MapHttpAttributeRoutes();
            // Matches route with the taskNum parameter
            config.Routes.MapHttpRoute(
            name: "FindByTaskNumberRoute",
            routeTemplate: "api/{controller}/{taskNum}",
            defaults: new { taskNum = RouteParameter.Optional }
            );
            // Default catch-all
            config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
            );
            config.EnableSystemDiagnosticsTracing();
            config.Services.Add(typeof(IExceptionLogger), new SimpleExceptionLogger(WebContainerManager.Get<ILogManager>()));
            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());
        }
    }
}