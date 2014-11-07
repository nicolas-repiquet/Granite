using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJulien.Game_01
{
    public class Segment
    {
        public Triangle Triangle { get; set; }

        public Vector3 P1 { get; set; }
        public Vector3 P2 { get; set; }
        public Vector4 Color { get; set; }

        public Segment()
        {

        }

        public Segment(Vector3 p1, Vector3 p2)
        {
            P1 = p1;
            P2 = p2;
            Color = new Vector4(1, 1, 0, 1);
        }

        public Segment(Vector3 p1, Vector3 p2, Vector4 color)
        {
            P1 = p1;
            P2 = p2;
            Color = color;
        }

        public Triangle ToTriangles()
        {
            Triangle = new Triangle()
            {
                P1 = new Vector3(P1.X, P1.Y, 0),
                P2 = new Vector3(P2.X, P2.Y, 0),
                P3 = new Vector3(P2.X+2, P2.Y+2, 0),
                Color = Color
            };

            return Triangle;
        }
    }
}
