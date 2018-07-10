using System;
using System.Web;
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

        public ActionResult RegistEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistEmail(string email)
        {
            if (Request.Cookies["email"] != null)
            {
                Request.Cookies["email"].Value = email;
            }
            else
            {
                var cookie = new HttpCookie("email")
                {
                    Value = email,
                    Expires = DateTime.Now.AddMinutes(1),
                    //HttpOnly = true
                };
                //when saving cookies to a user's browser, you should use the response object.
                //the request object allows you to read existing cookies.
                Response.Cookies.Add(cookie);
            }

            return RedirectToAction("RegistEmail");
        }
    }
}