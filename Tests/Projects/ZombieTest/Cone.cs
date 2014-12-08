using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zombie.Game.Entities.Tools;
using Granite.Core;

namespace ZombieTest
{
    [TestClass]
    public class ConeTest
    {
        private Cone m_coneRight;
        private Cone m_coneTop;
        private Cone m_coneLeft;
        private Cone m_coneDown;

        [TestInitialize]
        public void Init()
        {
            var angle = 1.0;
            m_coneRight = new Cone(
                new Vector2(0, 0),
                10,
                (float)angle,
                (float)((Math.Atan2(0, 1) + Math.PI * 2) - (angle / 2.0) - Math.PI * 2)
                );

            angle = 1.0;
            m_coneTop = new Cone(
                new Vector2(0, 0),
                10,
                (float)angle,
                (float)((Math.Atan2(1, 0) + Math.PI * 2) - (angle / 2.0) - Math.PI * 2)
                );

            angle = 1.0;
            m_coneLeft = new Cone(
                new Vector2(0, 0),
                10,
                (float)angle,
                (float)((Math.Atan2(0, -1) + Math.PI * 2) - (angle / 2.0) - Math.PI * 2)
                );

            angle = 1.0;
            m_coneDown = new Cone(
                new Vector2(0, 0),
                10,
                (float)angle,
                (float)((Math.Atan2(-1, 0) + Math.PI * 2) - (angle / 2.0) - Math.PI * 2)
                );
        }

        [TestCleanup]
        public void Cleanup()
        {
            m_coneRight = null;
            m_coneTop = null;
            m_coneLeft = null;
            m_coneDown = null;

        }

        [TestMethod]
        public void CollisionRight1()
        {
            var z = new Vector2(10, 0);

            var result = m_coneRight.Collision(z, 10);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CollisionRight2()
        {
            var z = new Vector2(0, 10);

            var result = m_coneRight.Collision(z, 10);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CollisionRight3()
        {
            var z = new Vector2(10, 0);
            m_coneRight.Angle = 0.2f;
            m_coneRight.StartAngle = (float)((Math.Atan2(0, 1) + Math.PI * 2) - (m_coneRight.Angle / 2.0) - Math.PI * 2);

            var result = m_coneRight.Collision(z, 10);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CollisionRight4()
        {
            var z = new Vector2(10, 0);
            m_coneRight.Angle = 0.2f;
            m_coneRight.StartAngle = (float)((Math.Atan2(0, 1) + Math.PI * 2) - (m_coneRight.Angle / 2.0) - Math.PI * 2);

            m_coneRight.Radius = 9f;

            var result = m_coneRight.Collision(z, 10);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CollisionRight5()
        {
            var z = new Vector2(10, 0);
            m_coneRight.Angle = 0.2f;
            m_coneRight.StartAngle = (float)((Math.Atan2(0, 1) + Math.PI * 2) - (m_coneRight.Angle / 2.0) - Math.PI * 2);

            m_coneRight.Radius = 11f;

            var result = m_coneRight.Collision(z, 10);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CollisionTop1()
        {
            var z = new Vector2(0, 10);

            var result = m_coneTop.Collision(z, 10);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CollisionTop2()
        {
            var z = new Vector2(10, 0);

            var result = m_coneTop.Collision(z, 10);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CollisionLeft1()
        {
            var z = new Vector2(-10, 00);

            var result = m_coneLeft.Collision(z, 10);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CollisionLeft2()
        {
            var z = new Vector2(0, 10);

            var result = m_coneLeft.Collision(z, 10);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CollisionLeft3()
        {
            var z = new Vector2(-10, 10);

            var result = m_coneLeft.Collision(z, 5);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CollisionLeft4()
        {
            var z = new Vector2(-8, -1);

            var result = m_coneLeft.Collision(z, 5);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CollisionLeft5()
        {
            var z = new Vector2(-8, 1);

            var result = m_coneLeft.Collision(z, 5);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CollisionDown1()
        {
            var z = new Vector2(0, -10);

            var result = m_coneDown.Collision(z, 10);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CollisionDown2()
        {
            var z = new Vector2(10, 0);

            var result = m_coneDown.Collision(z, 10);

            Assert.IsFalse(result);
        }
    }
}
