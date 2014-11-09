using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core.Tests
{
    [TestClass]
    public class ValueTypeDescriptorTests
    {
        [TestMethod]
        public void CoreTypes()
        {
            // Primitives

            TestCoreType(typeof(sbyte), 1, GL.BYTE);
            TestCoreType(typeof(byte), 1, GL.UNSIGNED_BYTE);

            TestCoreType(typeof(short), 2, GL.SHORT);
            TestCoreType(typeof(ushort), 2, GL.UNSIGNED_SHORT);

            TestCoreType(typeof(int), 4, GL.INT);
            TestCoreType(typeof(uint), 4, GL.UNSIGNED_INT);

            TestCoreType(typeof(float), 4, GL.FLOAT);
            TestCoreType(typeof(double), 8, GL.DOUBLE);

            // Vectors

            TestCoreType(typeof(Vector2b), 2, GL.BYTE, 2);
            TestCoreType(typeof(Vector3b), 3, GL.BYTE, 3);
            TestCoreType(typeof(Vector4b), 4, GL.BYTE, 4);

            TestCoreType(typeof(Vector2ub), 2, GL.UNSIGNED_BYTE, 2);
            TestCoreType(typeof(Vector3ub), 3, GL.UNSIGNED_BYTE, 3);
            TestCoreType(typeof(Vector4ub), 4, GL.UNSIGNED_BYTE, 4);

            TestCoreType(typeof(Vector2s), 4, GL.SHORT, 2);
            TestCoreType(typeof(Vector3s), 6, GL.SHORT, 3);
            TestCoreType(typeof(Vector4s), 8, GL.SHORT, 4);

            TestCoreType(typeof(Vector2us), 4, GL.UNSIGNED_SHORT, 2);
            TestCoreType(typeof(Vector3us), 6, GL.UNSIGNED_SHORT, 3);
            TestCoreType(typeof(Vector4us), 8, GL.UNSIGNED_SHORT, 4);

            TestCoreType(typeof(Vector2i), 8, GL.INT, 2);
            TestCoreType(typeof(Vector3i), 12, GL.INT, 3);
            TestCoreType(typeof(Vector4i), 16, GL.INT, 4);

            TestCoreType(typeof(Vector2ui), 8, GL.UNSIGNED_INT, 2);
            TestCoreType(typeof(Vector3ui), 12, GL.UNSIGNED_INT, 3);
            TestCoreType(typeof(Vector4ui), 16, GL.UNSIGNED_INT, 4);

            TestCoreType(typeof(Vector2), 8, GL.FLOAT, 2);
            TestCoreType(typeof(Vector3), 12, GL.FLOAT, 3);
            TestCoreType(typeof(Vector4), 16, GL.FLOAT, 4);

            TestCoreType(typeof(Vector2d), 16, GL.DOUBLE, 2);
            TestCoreType(typeof(Vector3d), 24, GL.DOUBLE, 3);
            TestCoreType(typeof(Vector4d), 32, GL.DOUBLE, 4);

            // Matrices

            TestCoreType(typeof(Matrix2), 2 * 2 * 4, GL.FLOAT, 4);
            TestCoreType(typeof(Matrix2x3), 2 * 3 * 4, GL.FLOAT, 6);
            TestCoreType(typeof(Matrix2x4), 2 * 4 * 4, GL.FLOAT, 8);

            TestCoreType(typeof(Matrix3x2), 3 * 2 * 4, GL.FLOAT, 6);
            TestCoreType(typeof(Matrix3), 3 * 3 * 4, GL.FLOAT, 9);
            TestCoreType(typeof(Matrix3x4), 3 * 4 * 4, GL.FLOAT, 12);

            TestCoreType(typeof(Matrix4x2), 4 * 2 * 4, GL.FLOAT, 8);
            TestCoreType(typeof(Matrix4x3), 4 * 3 * 4, GL.FLOAT, 12);
            TestCoreType(typeof(Matrix4), 4 * 4 * 4, GL.FLOAT, 16);

            TestCoreType(typeof(Matrix2d), 2 * 2 * 8, GL.DOUBLE, 4);
            TestCoreType(typeof(Matrix2x3d), 2 * 3 * 8, GL.DOUBLE, 6);
            TestCoreType(typeof(Matrix2x4d), 2 * 4 * 8, GL.DOUBLE, 8);

            TestCoreType(typeof(Matrix3x2d), 3 * 2 * 8, GL.DOUBLE, 6);
            TestCoreType(typeof(Matrix3d), 3 * 3 * 8, GL.DOUBLE, 9);
            TestCoreType(typeof(Matrix3x4d), 3 * 4 * 8, GL.DOUBLE, 12);

            TestCoreType(typeof(Matrix4x2d), 4 * 2 * 8, GL.DOUBLE, 8);
            TestCoreType(typeof(Matrix4x3d), 4 * 3 * 8, GL.DOUBLE, 12);
            TestCoreType(typeof(Matrix4d), 4 * 4 * 8, GL.DOUBLE, 16);

        }

        private void TestCoreType(Type type, int expectedSize, uint expectedGlType, int expectedCount = 1)
        {
            var descriptor = ValueTypeDescriptor.Create(type);

            Assert.AreEqual(expectedSize, descriptor.Size);
            Assert.AreEqual(expectedGlType, descriptor.FlattenedType);
            Assert.AreEqual(expectedCount, descriptor.FlattenedCount);
        }

    }
}
