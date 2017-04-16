using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magazine.Controllers;
using System.Threading.Tasks;
using Magazine.Tests.Ninject;
using Ninject;
using Magazine.BL.UnityOfWork;
using System.Linq;

namespace Magazine.Tests.Controllers
{
    [TestClass]
    public class MagazineControllerTest : DependencyInjectedTest
    {
        private readonly MagazineController _controller;
        private readonly IUnityOfWork _unityOfWork;

        public MagazineControllerTest()
        {
            NewScope();
            _controller = Kernel.Get<MagazineController>();
            NewScope();
            _unityOfWork = Kernel.Get<IUnityOfWork>();
        }

        [TestMethod]
        public async Task Index_IsNotNull()
        {
            var result = await _controller.Index() as ViewResult;

            Assert.IsNotNull(result.Model, "Result is null");
            Assert.AreEqual("", result.ViewName, "View is different");
        }

        [TestMethod]
        public async Task GetListItems_IsNotNull()
        {
            var storeList = await _unityOfWork.Stores.GetAllAsync();
            var storeId = storeList.FirstOrDefault().Id;

            var result = await _controller.GetListItems(storeId) as JsonResult;

            dynamic jsonResult = result.Data;

            Assert.IsNotNull(jsonResult, "Json result is null");
        }
    }
}
