using System.Web.Mvc;

namespace IisCrash.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => new JsonResult { Data = Request.RequestContext.RouteData, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
    }
}