using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Tools
{
    public class Polygone
    {
        public List<Vector3> Points { get; set; }
        public Vector4 Color { get; set; }

        public Polygone()
        {

        }

        public Polygone(List<Vector3> points)
        {
            Points = points;
            Color = new Vector4(1, 1, 0, 1);
        }

        public Polygone(List<Vector3> points, Vector4 color)
        {
            Points = points;
            Color = color;
        }
    }
}
