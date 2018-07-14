using For70486.Extensions;
using System.Web.Mvc;
using System.Web.Routing;

namespace For70486
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // ex. http://{domain}/action/a?size=100
            var customRoute = new Route("action/{something}", new MyCustomHandler());
            routes.Add(customRoute);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                // defaults: new { controller = "ExamAdmin", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
