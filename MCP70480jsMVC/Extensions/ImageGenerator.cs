using System.Web;

namespace MCP70480jsMVC.Extensions
{
    public class ImageGenerator : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("custom http handler says hello");
        }

        public bool IsReusable => true;
    }
}