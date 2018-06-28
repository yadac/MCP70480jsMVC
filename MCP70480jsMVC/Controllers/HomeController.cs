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

        [AllowAnonymous]
        public ActionResult Test()
        {
            return View();
        }

        [Authorize]
        public ActionResult TestAction()
        {
            // return instance of custum action class.
            // it needs to inherit ActionResult class, also it needs to override the ExecuteResult method.
            return new Extensions.TestResult();
        }

        [ChildActionOnly]
        public ActionResult PlayVideo()
        {
            ViewBag.Message = "Playing Intro Video";
            return View("Index");
        }
    }
}