using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Tools
{
    public class Point
    {
        private const double SLOTS = 8;
        private const double PI_2 = Math.PI * 2;
        private const double SLOT_ANGLE = (PI_2) / SLOTS;

        public Vector3 Center { get; set; }
        public float Radius { get; set; }
        public Vector4 StartColor { get; set; }
        public Vector4 EndColor { get; set; }
        public Triangle[] Triangles { get; set; }

        public Point()
        {

        }

        public Point(Vector3 p, float radius)
        {
            Center = p;
            Radius = radius;
            StartColor = new Vector4(0, 0, 1, 1);
            EndColor = new Vector4(0, 0, 1, 1);
        }

        public Point(Vector3 p, float radius, Vector4 startColor, Vector4 endColor)
        {
            Center = p;
            Radius = radius;
            StartColor = startColor;
            EndColor = endColor;
        }

        public Triangle[] ToTriangles()
        {

            //Triangles = new Triangle[(int)SLOTS];

            //for (int i = 0; i < SLOTS; i++)
            //{
            //    var t1 = i + 1 * SLOT_ANGLE;
            //    var p1 = new Vector3(
            //        (float)Math.Cos(t1) * Radius + Center.X,
            //        (float)Math.Sin(t1) * Radius + Center.Y,
            //        0);

            //    if (i == 0)
            //    {
            //        var t0 = i * SLOT_ANGLE;
            //        var p0 = new Vector3(
            //            (float)Math.Cos(t0) * Radius + Center.X,
            //            (float)Math.Sin(t0) * Radius + Center.Y,
            //            0);

            //        Triangles[0] = new Triangle()
            //        {
            //            P1 = Center,
            //            P2 = p1,
            //            P3 = p0,
            //            ColorP1 = StartColor,
            //            ColorP2 = EndColor,
            //            ColorP3 = EndColor
            //        };
            //    }
            //    else
            //    {
            //        var p = Triangles[i - 1].P3;

            //        Triangles[i] = new Triangle()
            //        {
            //            P1 = Center,
            //            P2 = p,
            //            P3 = p1,
            //            ColorP1 = StartColor,
            //            ColorP2 = EndColor,
            //            ColorP3 = EndColor
            //        };
            //    }
            //}

            return Triangles;
        }
    }
}
