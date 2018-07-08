using System.Web;
using System.Web.Routing;

namespace For70486.Extensions
{
    public class MyCustomHandler : IHttpHandler, IRouteHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var p1 = context.Request["size"];
            var p2 = context.Request.Params["size"];
            context.Response.Write($"parameter is {p1}({p2})");
        }

        public bool IsReusable
        {
            get { return true; }
        }

        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return this;
        }
    }
}