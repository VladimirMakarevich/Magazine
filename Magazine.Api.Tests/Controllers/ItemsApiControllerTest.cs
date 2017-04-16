using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magazine.Api.Controllers;
using Magazine.BL.UnityOfWork;
using System.Threading.Tasks;
using System.Linq;
using Ninject;
using Magazine.Api.Tests.Ninject;

namespace Magazine.Api.Tests.Controllers
{
    [TestClass]
    public class ItemsApiControllerTest : DependencyInjectedTest
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly ItemsController _controller;

        public ItemsApiControllerTest()
        {
            NewScope();
            _controller = Kernel.Get<ItemsController>();
            NewScope();
            _unityOfWork = Kernel.Get<IUnityOfWork>();
        }

        [TestMethod]
        public async Task Get_IsNotNull()
        {
            var storeList = await _unityOfWork.Stores.GetAllAsync();
            var storeId = storeList.FirstOrDefault().Id;

            var result = await _controller.Get(storeId);

            Assert.IsNotNull(result, "Result is null");
        }
    }
}
