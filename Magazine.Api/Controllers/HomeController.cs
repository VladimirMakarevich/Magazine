using System.Web.Mvc;

namespace Magazine.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Vladimir Makarevich";

            return View();
        }

        public ActionResult Magazine()
        {
            return View();
        }
    }
}
