using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Granite.Core;
using System.Diagnostics;

namespace UnitTestProject.Collision
{
    [TestClass]
    public class Intersection
    {
        [TestMethod]
        public void Box2_Box2_1_Intersection()
        {
            var box1 = new Box2(0, 0, 100, 100);
            var box2 = new Box2(50, 50, 100, 100);

            var result = Granite.Collision.Collision.Intersect(box1, box2);

            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void Box2_Box2_2_Intersection()
        {
            var box1 = new Box2(0, 0, 100, 100);
            var box2 = new Box2(25, 25, 100, 50);

            var result = Granite.Collision.Collision.Intersect(box1, box2);

            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void Box2_Box2_4_Intersection()
        {
            var box1 = new Box2(0, 0, 100, 100);
            var box2 = new Box2(25, 25, 50, 50);

            var result = Granite.Collision.Collision.Intersect(box1, box2);

            Assert.IsTrue(result.Count == 4);
        }

        [TestMethod]
        public void Segment_Segment_True()
        {
            var s1A = new Vector2(0, 0);
            var s1B = new Vector2(0, 100);
            var s2A = new Vector2(-50, 50);
            var s2B = new Vector2(50, 50);

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.IntersectSegmentSegment(s1A, s1B, s2A, s2B);
            w.Stop();
            Console.WriteLine(string.Format("Segment_Segment_True : {0}", w.Elapsed));
            Assert.IsTrue(result != null);
        }

        [TestMethod]
        public void Segment_Segment_False()
        {
            var s1A = new Vector2(0, 0);
            var s1B = new Vector2(0, 100);
            var s2A = new Vector2(-50, 50);
            var s2B = new Vector2(-1, 50);

            Stopwatch w = new Stopwatch();
            w.Start();
            var result = Granite.Collision.Collision.IntersectSegmentSegment(s1A, s1B, s2A, s2B);
            w.Stop();
            Console.WriteLine(string.Format("Segment_Segment_False : {0}", w.Elapsed));

            Assert.IsTrue(result == null);
        }
    }
}
