using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Tools
{
    public class Cone : ICloneable
    {
        private const double SLOTS = 4;

        public Vector3 Center { get; set; }
        public float Radius { get; set; }
        public float Angle { get; set; }
        public float StartAngle { get; set; }
        public Vector4 StartColor { get; set; }
        public Vector4 EndColor { get; set; }
        public Triangle[] Triangles { get; set; }

        public Cone()
        {

        }

        public Cone(Vector3 p, float radius, float angle, float startAngle = 0)
        {
            Center = p;
            Radius = radius;
            Angle = angle;
            StartAngle = startAngle;
            StartColor = new Vector4(0, 0, 1, 1);
            EndColor = new Vector4(0, 0, 1, 1);
        }

        public Cone(Vector3 p, float radius, float angle, Vector4 startColor, Vector4 endColor, float startAngle = 0)
        {
            Center = p;
            Radius = radius;
            Angle = angle;
            StartAngle = startAngle;
            StartColor = startColor;
            EndColor = endColor;
        }

        public Triangle[] ToTriangles()
        {

            Triangles = new Triangle[(int)SLOTS];

            for (int i = 0; i < SLOTS; i++)
            {
                var t1 = StartAngle + (i + 1) * (Angle / SLOTS);
                var p1 = new Vector3(
                    (float)Math.Cos(t1) * Radius + Center.X,
                    (float)Math.Sin(t1) * Radius + Center.Y,
                    0);

                if (i == 0)
                {
                    var t0 = StartAngle;
                    var p0 = new Vector3(
                        (float)Math.Cos(t0) * Radius + Center.X,
                        (float)Math.Sin(t0) * Radius + Center.Y,
                        0);

                    Triangles[0] = new Triangle()
                    {
                        P1 = Center,
                        P2 = p0,
                        P3 = p1,
                        ColorP1 = StartColor,
                        ColorP2 = new Vector4(EndColor.X, EndColor.Y, EndColor.Z, 0),
                        ColorP3 = EndColor
                    };
                }
                else if (i == SLOTS-1)
                {
                    var p = Triangles[i - 1].P3;

                    Triangles[i] = new Triangle()
                    {
                        P1 = Center,
                        P2 = p,
                        P3 = p1,
                        ColorP1 = StartColor,
                        ColorP2 = EndColor,
                        ColorP3 = new Vector4(EndColor.X, EndColor.Y, EndColor.Z, 0)
                    };
                }
                else
                {
                    var p = Triangles[i - 1].P3;

                    Triangles[i] = new Triangle()
                    {
                        P1 = Center,
                        P2 = p,
                        P3 = p1,
                        ColorP1 = StartColor,
                        ColorP2 = EndColor,
                        ColorP3 = EndColor
                    };
                }
            }

            return Triangles;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
