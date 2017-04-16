using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magazine.Controllers;
using System.Threading.Tasks;

namespace Magazine.Tests.Controllers
{
    [TestClass]
    public class MagazineControllerTest
    {
        public MagazineControllerTest()
        {

        }

        [TestMethod]
        public async Task Index_IsNotNull()
        {
            MagazineController controller = new MagazineController();

            var result = await controller.Index() as ActionResult;

            Assert.IsNotNull(result);
        }
    }
}
