using For70486.Models;
using System.Web.Mvc;

namespace For70486.Controllers
{
    public class MemberController : Controller
    {
        private For70486Context db = new For70486Context();

        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(db.Members);
        }
    }
}