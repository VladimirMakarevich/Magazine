using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magazine.Api.Controllers;

namespace Magazine.Api.Tests.Controllers
{
    [TestClass]
    public class HomeApiControllerTest
    {
        private readonly HomeController _controller;

        public HomeApiControllerTest()
        {
            _controller = new HomeController();

        }

        [TestMethod]
        public void Index_IsNotNull()
        {
            var result = _controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Vladimir Makarevich", result.ViewBag.Title);
        }

        [TestMethod]
        public void Magazine_IsNotNull()
        {
            var result = _controller.Magazine() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
