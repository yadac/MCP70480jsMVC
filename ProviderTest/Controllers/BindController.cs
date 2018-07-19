using ProviderTest.Extensions;
using ProviderTest.Models;
using System;
using System.Web;
using System.Web.Mvc;

namespace ProviderTest.Controllers
{
    public class BindController : Controller
    {
        // GET: Bind
        public ActionResult Custom()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Custom([ModelBinder(typeof(MemberBinder))]Member member)
        {
            return Content(member.ToString());
        }

        public ActionResult Provide(string email)
        {
            Response.AppendCookie(new HttpCookie("email")
            {
                Value = "xxx@example.com",
                Expires = DateTime.Now.AddHours(1),
            });

            return Content("provide cookie");
        }
    }
}