using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Granite.Core.Tests
{
    [TestClass]
    public class Vectors
    {
        [TestMethod]
        public void Addition()
        {
            var v = Vector2.UnitX + Vector2.UnitY;

            Assert.AreEqual(v.X, 1);
            Assert.AreEqual(v.Y, 1);
        }
    }
}
