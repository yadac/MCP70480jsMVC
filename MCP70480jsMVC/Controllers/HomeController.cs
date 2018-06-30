using MCP70480jsMVC.Models;
using System;
using System.Security.Claims;
using System.Threading;
using System.Web.Mvc;

namespace MCP70480jsMVC.Controllers
{
    public class HomeController : Controller
    {
        private BasicContext db = new BasicContext();

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
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            var a = context.Request.Params["size"];
            var b = context.Request["size"];
            ViewBag.Param = $"a = {a}, b = {b}";

            Response.Cookies["LastWatchedMovie"].Value = "100";
            Response.Cookies["LastWatchedMovie"].Expires = DateTime.Now.AddDays(1);
            return View();
        }

        [ActionName("List")]
        [OutputCache(Duration = 120, VaryByParam = "id")]
        public ActionResult ListUser(int id = 1)
        {
            return View(db.Members);
        }

        [ChildActionOnly]
        public ActionResult CurrenTime()
        {
            return PartialView("_CurrentTimePartial", DateTime.Now);
        }

        [Authorize]
        public ActionResult TestAction()
        {
            ClaimsPrincipal principal = (ClaimsPrincipal)Thread.CurrentPrincipal;
            bool authorized = principal.HasClaim("xxx", "aaa");
            if (authorized)
            {
                ViewBag.CitizenId = "xxx";
            }
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