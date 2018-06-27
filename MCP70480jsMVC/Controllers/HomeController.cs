using System.Web.Mvc;

namespace MCP70480jsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Home Action Method.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult Test()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult PlayVideo()
        {
            ViewBag.Message = "Playing Intro Video";
            return View("Index");
        }
    }
}