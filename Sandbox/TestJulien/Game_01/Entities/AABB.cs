using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJulien.Game_01.Entities
{
    public class AABB
    {
        public Vector2 Position { get; set; }
        public Vector2 Extent { get; set; }

        public AABB(Vector2 position, Vector2 extent)
        {
            Position = position;
            Extent = extent;
        }

        //returns true if this is overlapping b
        public bool Overlaps(AABB b)
        {
            Vector2 T = b.Position - Position;//vector from A to B
            return
            Math.Abs(T.X) <= (Extent.X + b.Extent.X)
            && Math.Abs(T.Y) <= (Extent.Y + b.Extent.Y);

        }

        public float Min(short i)
        {
            if(i == 0)
            {
                return this.Position.X - this.Extent.X;
            }
            else
            {
                return this.Position.Y - this.Extent.Y;
            }
        }

        public float Max(short i)
        {
            if(i == 0)
            {
                return this.Position.X + this.Extent.X;
            }
            else
            {
                return this.Position.Y + this.Extent.Y;
            }
        }
    }
}
