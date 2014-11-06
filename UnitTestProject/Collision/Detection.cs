using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Granite.Core;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTestProject.Collision
{
    [TestClass]
    public class Detection
    {
        [TestMethod]
        public void Box2_Box2_False()
        {
            var box1 = new Box2(0, 0, 100, 100);
            var box2 = new Box2(200, 0, 100, 100);

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.Detection(box1, box2);
            w.Stop();
            Console.WriteLine(string.Format("Box2_Box2_False : {0}", w.Elapsed));

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Box2_Box2_True()
        {
            var box1 = new Box2(0, 0, 100, 100);
            var box2 = new Box2(50, 0, 100, 100);

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.Detection(box1, box2);
            w.Stop();
            Console.WriteLine(string.Format("Box2_Box2_True : {0}", w.Elapsed));
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Box2_Segment_True()
        {
            var box1 = new Box2(0, 0, 100, 100);
            var box2 = new Box2(50, 0, 100, 100);

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.Detection(box1, box2);
            w.Stop();
            Console.WriteLine(string.Format("Box2_Segment_True : {0}", w.Elapsed));
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShapeBox_ShapeBox_False()
        {
            var shape1 = new List<Vector2>()
                {
                    new Vector2(0, 0),
                    new Vector2(100, 0),
                    new Vector2(100, 100),
                    new Vector2(0, 100)
                };
            var shape2 = new List<Vector2>()
                {
                    new Vector2(200, 0),
                    new Vector2(200, 100),
                    new Vector2(300, 100),
                    new Vector2(300, 0)
                };

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.Detection(shape1, shape2);
            w.Stop();
            Console.WriteLine(string.Format("ShapeBox_ShapeBox_False : {0}", w.Elapsed));
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShapeBox_ShapeBox_True()
        {
            var shape1 = new List<Vector2>()
                {
                    new Vector2(0, 0),
                    new Vector2(100, 0),
                    new Vector2(100, 100),
                    new Vector2(0, 100)
                };
            var shape2 = new List<Vector2>()
                {
                    new Vector2(50, 50),
                    new Vector2(50, 150),
                    new Vector2(150, 150),
                    new Vector2(150, 0)
                };

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.Detection(shape1, shape2);
            w.Stop();
            Console.WriteLine(string.Format("ShapeBox_ShapeBox_True : {0}", w.Elapsed));
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShapeBox_ShapeStar_False()
        {
            var shape1 = new List<Vector2>()
                {
                    new Vector2(0, -100),
                    new Vector2(100, -100),
                    new Vector2(100, 0),
                    new Vector2(0, 0)
                };
            var shape2 = new List<Vector2>()
                {
                    new Vector2(100, 100),
                    new Vector2(150, 150),
                    new Vector2(200, 100),
                    new Vector2(175, 200),
                    new Vector2(250, 250),
                    new Vector2(160, 250),
                    new Vector2(150, 300),
                    new Vector2(140, 250),
                    new Vector2(50, 250),
                    new Vector2(125, 200)
                };

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.Detection(shape1, shape2);
            w.Stop();
            Console.WriteLine(string.Format("ShapeBox_ShapeStar_False : {0}", w.Elapsed));
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShapeBox_ShapeStar_True()
        {
            var shape1 = new List<Vector2>()
                {
                    new Vector2(0, 0),
                    new Vector2(100, 0),
                    new Vector2(100, 200),
                    new Vector2(0, 200)
                };
            var shape2 = new List<Vector2>()
                {
                    new Vector2(100, 100),
                    new Vector2(150, 150),
                    new Vector2(200, 100),
                    new Vector2(175, 200),
                    new Vector2(250, 250),
                    new Vector2(160, 250),
                    new Vector2(150, 300),
                    new Vector2(140, 250),
                    new Vector2(50, 250),
                    new Vector2(125, 200)
                };

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.Detection(shape1, shape2);
            w.Stop();
            Console.WriteLine(string.Format("ShapeBox_ShapeStar_True : {0}", w.Elapsed));
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShapeStar_ShapeStar_False()
        {
            var shape1 = new List<Vector2>()
                {
                    new Vector2(100, 100),
                    new Vector2(150, 150),
                    new Vector2(200, 100),
                    new Vector2(175, 200),
                    new Vector2(250, 250),
                    new Vector2(160, 250),
                    new Vector2(150, 300),
                    new Vector2(140, 250),
                    new Vector2(50, 250),
                    new Vector2(125, 200)
                };
            var shape2 = new List<Vector2>()
                {
                    new Vector2(400, 100),
                    new Vector2(450, 150),
                    new Vector2(500, 100),
                    new Vector2(475, 200),
                    new Vector2(550, 250),
                    new Vector2(460, 250),
                    new Vector2(450, 300),
                    new Vector2(440, 250),
                    new Vector2(350, 250),
                    new Vector2(425, 200)
                };

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.Detection(shape1, shape2);
            w.Stop();
            Console.WriteLine(string.Format("ShapeStar_ShapeStar_False : {0}", w.Elapsed));
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShapeStar_ShapeStar_True()
        {
            var shape1 = new List<Vector2>()
                {
                    new Vector2(100, 100),
                    new Vector2(150, 150),
                    new Vector2(200, 100),
                    new Vector2(175, 200),
                    new Vector2(250, 250),
                    new Vector2(160, 250),
                    new Vector2(150, 300),
                    new Vector2(140, 250),
                    new Vector2(50, 250),
                    new Vector2(125, 200)
                };
            var shape2 = new List<Vector2>()
                {
                    new Vector2(200, 100),
                    new Vector2(250, 150),
                    new Vector2(300, 100),
                    new Vector2(275, 200),
                    new Vector2(350, 250),
                    new Vector2(260, 250),
                    new Vector2(250, 300),
                    new Vector2(240, 250),
                    new Vector2(150, 250),
                    new Vector2(225, 200)
                };

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.Detection(shape1, shape2);
            w.Stop();
            Console.WriteLine(string.Format("ShapeStar_ShapeStar_True : {0}", w.Elapsed));
            Assert.IsTrue(result);
        }
    }
}
