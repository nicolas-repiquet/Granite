using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJulien.Game_01.Entities
{
    public class AABBCollision
    {
        public static bool Detection(AABB a0, AABB a1, AABB b0, AABB b1, ref float u0, ref float u1)
        {
            Vector2 va = a1.Position - a0.Position;
            Vector2 vb = b1.Position - b0.Position;

            Vector2 v = vb - va;

            float u_0x = 0;
            float u_0y = 0;
            float u_1x = 1;
            float u_1y = 1;

            if (a0.Overlaps(b0))
            {
                u0 = u1 = 0;
                return true;
            }

            //X
            if (a0.Max(0) < b0.Min(0) && v.X < 0)
            {
                u_0x = (a0.Max(0) - b0.Min(0)) / v.X;
            }
            else if (b0.Max(0) < a0.Min(0) && v.X > 0)
            {
                u_0x = (a0.Min(0) - b0.Max(0)) / v.X;
            }

            if (b0.Max(0) > a0.Min(0) && v.X < 0)
            {
                u_1x = (a0.Min(0) - b0.Max(0)) / v.X;
            }
            else if (a0.Max(0) > b0.Min(0) && v.X > 0)
            {
                u_1x = (a0.Max(0) - b0.Min(0)) / v.X;
            }

            //Y
            if (a0.Max(1) < b0.Min(1) && v.Y < 0)
            {
                u_0y = (a0.Max(1) - b0.Min(1)) / v.Y;
            }
            else if (b0.Max(1) < a0.Min(1) && v.Y > 0)
            {
                u_0y = (a0.Min(1) - b0.Max(1)) / v.Y;
            }

            if (b0.Max(1) > a0.Min(1) && v.Y < 0)
            {
                u_1y = (a0.Min(1) - b0.Max(1)) / v.Y;
            }
            else if (a0.Max(1) > b0.Min(1) && v.Y > 0)
            {
                u_1y = (a0.Max(1) - b0.Min(1)) / v.Y;
            }

            //possible first time of overlap
            u0 = Math.Max(u_0x, u_0y);

            //possible last time of overlap
            u1 = Math.Min(u_1x, u_1y);

            //they could have only collided if
            //the first time of overlap occurred
            //before the last time of overlap
            return u0 <= u1;
        }
    }
}
