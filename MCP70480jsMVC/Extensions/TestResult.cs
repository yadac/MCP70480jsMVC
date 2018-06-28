using System.Web.Mvc;

namespace MCP70480jsMVC.Extensions
{
    public class TestResult : ActionResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.Write("custom action return value");
        }
    }
}