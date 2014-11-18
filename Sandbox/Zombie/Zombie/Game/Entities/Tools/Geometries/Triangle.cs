using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Tools
{
    public class Triangle
    {
        public Vector3 P1 { get; set; }
        public Vector3 P2 { get; set; }
        public Vector3 P3 { get; set; }
        public Vector4 Color { get; set; }

        public Triangle()
        {

        }

        public Triangle(Vector3 p1, Vector3 p2, Vector3 p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            Color = new Vector4(1, 1, 0, 1);
        }

        public Triangle(Vector3 p1, Vector3 p2, Vector3 p3, Vector4 color)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            Color = color;
        }
    }
}
