using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Granite.Render;

namespace RenderTest
{
    [TestClass]
    public class RenderManagerTest
    {
        [TestMethod]
        public void AddLayer()
        {
            RenderManager.Instance.AddLayer("Floor");

            Assert.IsTrue(RenderManager.Instance.GetLayerId("Floor") == 0);
        }

        [TestMethod]
        public void AddSprite()
        {
            RenderManager.Instance.AddLayer("Floor");

            Assert.IsTrue(RenderManager.Instance.GetLayerId("Floor") == 0);
        }
    }
}
