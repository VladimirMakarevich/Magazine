﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magazine.Controllers;

namespace Magazine.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private readonly HomeController _controller;

        public HomeControllerTest()
        {
            _controller = new HomeController();

        }

        [TestMethod]
        public void Index_IsNotNull()
        {
            var result = _controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
