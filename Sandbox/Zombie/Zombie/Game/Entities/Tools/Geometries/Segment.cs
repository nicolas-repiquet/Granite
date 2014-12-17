using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Tools
{
    public class Segment
    {
        public Triangle Triangle { get; set; }

        public Vector2 P1 { get; set; }
        public Vector2 P2 { get; set; }
        public Color4ub Color { get; set; }

        public Segment()
        {

        }

        public Segment(Vector2 p1, Vector2 p2)
        {
            P1 = p1;
            P2 = p2;
            Color = new Color4ub(255, 0, 0, 255);
        }

        public Segment(Vector2 p1, Vector2 p2, Color4ub color)
        {
            P1 = p1;
            P2 = p2;
            Color = color;
        }

        public Vector2 ToVector()
        {
            return new Vector2(
                P2.X - P1.X,
                P2.Y - P1.X);
        }

        //public Triangle ToTriangles()
        //{
        //    Triangle = new Triangle()
        //    {
        //        P1 = new Vector3(P1.X, P1.Y, 0),
        //        P2 = new Vector3(P2.X, P2.Y, 0),
        //        P3 = new Vector3(P2.X+2, P2.Y+2, 0),
        //        Color = Color
        //    };

        //    return Triangle;
        //}
    }
}
