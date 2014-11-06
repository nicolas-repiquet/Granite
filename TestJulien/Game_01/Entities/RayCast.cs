using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestJulien.Game_01.Maps;

namespace TestJulien.Game_01.Entities
{
    //public sealed class RayCast
    //{
    //    private readonly Guid m_id;
    //    public readonly Vector2 m_start;
    //    public readonly Vector2 m_end;
    //    public readonly Vector2 m_indices;

    //    public RayCast(Vector2 start, Vector2 end, Vector2 indices)
    //    {
    //        m_start = start;
    //        m_end = end;
    //        m_indices = indices;
    //        m_id = Guid.NewGuid();
    //    }

    //    public Tuple<float?, float?, double, double> Collision2()
    //    {
    //        var map = World.Instance.Level.Map;

    //        Tuple<float?, float?> result = map.Move(m_start, m_end);

    //        var distanceX = -1.0;
    //        var distanceY = -1.0;

    //        var collisionX = result.Item1;
    //        var collisionY = result.Item2;

    //        if (collisionX.HasValue)
    //        {
    //            distanceX = Math.Sqrt(Math.Pow(result.Item1.Value - m_start.X, 2) + Math.Pow(m_start.Y - m_start.Y, 2));

    //            collisionX = result.Item1 - m_indices.X; 
    //        }

    //        if (collisionY.HasValue)
    //        {
    //            distanceY = Math.Sqrt(Math.Pow(m_start.X - m_start.X, 2) + Math.Pow(result.Item2.Value - m_start.Y, 2));

    //            collisionY = result.Item2 - m_indices.Y; 
    //        }

    //        return new Tuple<float?, float?, double, double>(collisionX, collisionY, distanceX, distanceY);
    //    }

    //    public Guid Id
    //    {
    //        get
    //        {
    //            return m_id;
    //        }
    //    }

    //    public Vector2? Collision()
    //    {
    //        Vector2? isCollided = null;

    //        var map = World.Instance.Level.Map;

    //        if (Math.Truncate(m_start.Y) == Math.Truncate(m_end.Y)
    //            && Math.Truncate(m_start.X) == Math.Truncate(m_end.X))
    //        {
    //            var material = map.GetMaterial(new Vector2(m_start.X, m_start.Y));

    //            if (material != null && material == Grass.Instance)
    //            {
    //                isCollided = new Vector2(m_start.X, m_start.Y);
    //            }
    //            else
    //            {
    //                isCollided = null;
    //            }
    //        }
    //        else if (Math.Truncate(m_start.Y) == Math.Truncate(m_end.Y))
    //        {
    //            var xStart = Math.Min(m_start.X, m_end.X);
    //            var xEnd = Math.Max(m_start.X, m_end.X);

    //            for (var x = xStart; x <= xEnd; x += 70)
    //            {
    //                var material = map.GetMaterial(new Vector2(x, m_start.Y));

    //                if (material != null && material == Grass.Instance)
    //                {
    //                    isCollided = new Vector2(x, m_start.Y);
    //                    break;
    //                }
    //                else
    //                {
    //                    isCollided = null;
    //                }
    //            }
    //        }
    //        else if (Math.Truncate(m_start.X) == Math.Truncate(m_end.X))
    //        {
    //            var yEnd = Math.Min(m_start.Y, m_end.Y);
    //            var yStart = Math.Max(m_start.Y, m_end.Y);

    //            for (var y = yStart; y >= yEnd; y -= 70)
    //            {
    //                var material = map.GetMaterial(new Vector2(m_start.X, y));

    //                if (material != null && material == Grass.Instance)
    //                {
    //                    isCollided = new Vector2(m_start.X, y);
    //                    break;
    //                }
    //                else
    //                {
    //                    isCollided = null;
    //                }
    //            }
    //        }
    //        else
    //        {
    //            var xStart = Math.Min(m_start.X, m_end.X);
    //            var xEnd = Math.Max(m_start.X, m_end.X);

    //            var yEnd = Math.Min(m_start.Y, m_end.Y);
    //            var yStart = Math.Max(m_start.Y, m_end.Y);

    //            for (var x = xStart; x <= xEnd; x += 70)
    //            {
    //                for (var y = yStart; y >= yEnd; y -= 70)
    //                {
    //                    var material = map.GetMaterial(new Vector2(x, y));

    //                    if (material != null && material == Grass.Instance)
    //                    {
    //                        isCollided = new Vector2(x, y);
    //                        break;
    //                    }
    //                    else
    //                    {
    //                        isCollided = null;
    //                    }
    //                }
    //            }
              
    //        }
    //        return isCollided;
    //    }
    //}
}
