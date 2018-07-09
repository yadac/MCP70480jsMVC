using System.Web.Mvc;

namespace For70486.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Question()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Question(string question)
        {
            // viewの値をパラメータで受け取るためには, inputのnameの値とパラメータ名を一致させる
            return Content(question);
        }
    }
}