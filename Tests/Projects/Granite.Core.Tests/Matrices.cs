using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core.Tests
{
    [TestClass]
    public class Matrices
    {
        [TestMethod]
        public void MatrixVectorMultiplication()
        {
            var v = new Vector3(2, 2, 1);
            var m = new Matrix3x2(1, 0, 0, 1, 5, 6);

            var r = Matrix3x2.Multiply(ref m, v);

            Assert.AreEqual(r.X, 7);
            Assert.AreEqual(r.Y, 8);

        }
    }
}
