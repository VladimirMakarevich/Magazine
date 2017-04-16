using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magazine.Controllers;

namespace Magazine.Tests.Controllers
{
    [TestClass]
    public class MagazineController
    {
        [TestMethod]
        public void Index()
        {
            MagazineController controller = new MagazineController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
