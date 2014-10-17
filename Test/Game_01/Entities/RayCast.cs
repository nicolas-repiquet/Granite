using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Maps;

namespace Test.Game_01.Entities
{
    public sealed class RayCast
    {
        public readonly Vector2 m_start;
        public readonly Vector2 m_end;

        public RayCast(Vector2 start, Vector2 end)
        {
            m_start = start;
            m_end = end;
        }

        //public bool Collision()
        //{
        //    var map = World.Instance.Level.Map;

        //    var material = map.GetMaterial(m_start);

        //    if (material == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        public bool Collision()
        {
            var isCollided = false;

            var map = World.Instance.Level.Map;

            if (Math.Truncate(m_start.Y) == Math.Truncate(m_end.Y)
                && Math.Truncate(m_start.X) == Math.Truncate(m_end.X))
            {
                var material = map.GetMaterial(new Vector2(m_start.X, m_start.Y));

                if (material != null && material == Grass.Instance)
                {
                    isCollided = true;
                }
                else
                {
                    isCollided = false;
                }
            }
            else if (Math.Truncate(m_start.Y) == Math.Truncate(m_end.Y))
            {
                var xStart = Math.Min(m_start.X, m_end.X);
                var xEnd = Math.Max(m_start.X, m_end.X);

                for (var x = xStart; x <= xEnd; x += 70)
                {
                    var material = map.GetMaterial(new Vector2(x, m_start.Y));

                    if (material != null && material == Grass.Instance)
                    {
                        isCollided = true;
                        break;
                    }
                    else
                    {
                        isCollided = false;
                    }
                }
            }
            else if (Math.Truncate(m_start.X) == Math.Truncate(m_end.X))
            {
                var yEnd = Math.Min(m_start.Y, m_end.Y);
                var yStart = Math.Max(m_start.Y, m_end.Y);

                for (var y = yStart; y >= yEnd; y -= 70)
                {
                    var material = map.GetMaterial(new Vector2(m_start.X, y));

                    if (material != null && material == Grass.Instance)
                    {
                        isCollided = true;
                        break;
                    }
                    else
                    {
                        isCollided = false;
                    }
                }
            }
            else
            {
                var xStart = Math.Min(m_start.X, m_end.X);
                var xEnd = Math.Max(m_start.X, m_end.X);

                var yEnd = Math.Min(m_start.Y, m_end.Y);
                var yStart = Math.Max(m_start.Y, m_end.Y);

                for (var x = xStart; x <= xEnd; x += 70)
                {
                    for (var y = yStart; y >= yEnd; y -= 70)
                    {
                        var material = map.GetMaterial(new Vector2(x, y));

                        if (material != null && material == Grass.Instance)
                        {
                            isCollided = true;
                            break;
                        }
                        else
                        {
                            isCollided = false;
                        }
                    }
                }
              
            }
            return isCollided;
        }
    }
}
