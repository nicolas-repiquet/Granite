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
        public Vector4 ColorP1 { get; set; }
        public Vector4 ColorP2 { get; set; }
        public Vector4 ColorP3 { get; set; }

        public Triangle()
        {

        }

        public Triangle(Vector3 p1, Vector3 p2, Vector3 p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            ColorP1 = new Vector4(1, 1, 0, 1);
            ColorP2 = new Vector4(1, 1, 0, 1);
            ColorP3 = new Vector4(1, 1, 0, 1);
        }

        public Triangle(Vector3 p1, Vector3 p2, Vector3 p3, 
            Vector4 colorP1, Vector4 colorP2, Vector4 colorP3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            ColorP1 = colorP1;
            ColorP2 = colorP2;
            ColorP3 = colorP3;
        }
    }
}
