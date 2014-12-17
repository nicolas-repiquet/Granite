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
        public Color4ub ColorP1 { get; set; }
        public Color4ub ColorP2 { get; set; }
        public Color4ub ColorP3 { get; set; }

        public Triangle()
        {

        }

        public Triangle(Vector3 p1, Vector3 p2, Vector3 p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            ColorP1 = new Color4ub(255, 255, 0, 255);
            ColorP2 = new Color4ub(255, 255, 0, 255);
            ColorP3 = new Color4ub(255, 255, 0, 255);
        }

        public Triangle(Vector3 p1, Vector3 p2, Vector3 p3,
            Color4ub colorP1, Color4ub colorP2, Color4ub colorP3)
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
