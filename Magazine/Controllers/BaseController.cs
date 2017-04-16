using Magazine.BL.UnityOfWork;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class BaseController : Controller
    {
        public IUnityOfWork _unityOfWork;
    }
}