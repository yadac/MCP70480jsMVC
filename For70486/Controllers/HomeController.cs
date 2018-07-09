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
        // [ValidateInput(false)] // inputに対するvalidationが実行されなくなる
        public ActionResult Question(string question)
        {
            // querystringやformの要素は下記のように取得できる
            var req1 = Request["question1"];
            // viewの値をパラメータで受け取るためには, inputのnameの値とパラメータ名を一致させる
            var ret = question + " - " + req1;
            return Content(ret);
        }
    }
}