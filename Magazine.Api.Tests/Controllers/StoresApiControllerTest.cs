using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magazine.Api.Controllers;
using Magazine.BL.UnityOfWork;
using System.Threading.Tasks;
using Ninject;
using Magazine.Api.Tests.Ninject;

namespace Magazine.Api.Tests.Controllers
{
    [TestClass]
    public class StoresApiControllerTest : DependencyInjectedTest
    {
        private readonly StoresController _controller;

        public StoresApiControllerTest()
        {
            NewScope();
            _controller = Kernel.Get<StoresController>();
        }

        [TestMethod]
        public async Task Get_IsNotNull()
        {
            var result = await _controller.Get();

            Assert.IsNotNull(result, "Result is null");
        }
    }
}
