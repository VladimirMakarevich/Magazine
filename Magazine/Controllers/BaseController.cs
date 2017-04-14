using Magazine.BL.UnityOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magazine.Controllers
{
    public class BaseController : Controller
    {
        public IUnityOfWork _unityOfWork;
    }
}