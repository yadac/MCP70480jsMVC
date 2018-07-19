using System;
using System.Web.Mvc;

namespace MCP70480jsMVC.Controllers
{
    public class FilterController : Controller
    {

        // [HandleError(View = "ErrorSpare")]
        public ActionResult Index()
        {
            throw new ArgumentException("致命的なエラーです");
            return View();
        }
    }
}