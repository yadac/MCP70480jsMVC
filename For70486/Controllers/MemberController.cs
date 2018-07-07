using For70486.Models;
using System.Net;
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

        public ActionResult Edit(int id)
        {
            throw new System.NotImplementedException();
        }

        public ActionResult Detail(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Member member = db.Members.Find(id);
            if (member == null)
            {
                return HttpNotFound();
            }

            return View(member);
        }
    }
}