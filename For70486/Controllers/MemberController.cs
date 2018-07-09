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
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("ja");
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, NAme, Email, Birth, Married, Memo")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(member);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(member);
        }
    }
}