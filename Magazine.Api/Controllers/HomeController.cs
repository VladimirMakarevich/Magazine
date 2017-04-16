using System.Web.Mvc;

namespace Magazine.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Magazine()
        {
            return View();
        }
    }
}
