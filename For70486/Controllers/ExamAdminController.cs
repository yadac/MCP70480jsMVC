using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace For70486.Controllers
{
    public class ExamAdminController : Controller, IControllerFactory
    {
        // https://stackoverflow.com/questions/20043306/how-to-impelment-a-custom-controller-factory-asp-net-mvc

        // GET: ExamAdmin
        public ActionResult Index()
        {
            return View();
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            throw new System.NotImplementedException();
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            throw new System.NotImplementedException();
        }

        public void ReleaseController(IController controller)
        {
            throw new System.NotImplementedException();
        }
    }
}