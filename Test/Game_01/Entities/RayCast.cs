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
        private readonly Guid m_id;
        public readonly Vector2 m_start;
        public readonly Vector2 m_end;
        public readonly Vector2 m_indices;

        public RayCast(Vector2 start, Vector2 end, Vector2 indices)
        {
            m_start = start;
            m_end = end;
            m_indices = indices;
            m_id = Guid.NewGuid();
        }

        public Tuple<Vector2?, Vector2, double, Guid> Collision2()
        {
            var map = World.Instance.Level.Map;

            Tuple<Vector2?, Vector2> result = map.Move(m_start, m_end);

            var distance = -1.0;
            Vector2? v = null;

            if (result.Item1.HasValue)
            {
                v = new Vector2(
                    result.Item1.Value.X + m_indices.X * Map.CELL_SIZE,
                    result.Item1.Value.Y + m_indices.Y * Map.CELL_SIZE);

                distance = Math.Sqrt(Math.Pow(v.Value.X - m_start.X, 2) + Math.Pow(v.Value.Y - m_start.Y, 2));
            }

            return new Tuple<Vector2?, Vector2, double, Guid>(result.Item1, result.Item2, distance, this.m_id);
        }

        public Guid Id
        {
            get
            {
                return m_id;
            }
        }

        public Vector2? Collision()
        {
            Vector2? isCollided = null;

            var map = World.Instance.Level.Map;

            if (Math.Truncate(m_start.Y) == Math.Truncate(m_end.Y)
                && Math.Truncate(m_start.X) == Math.Truncate(m_end.X))
            {
                var material = map.GetMaterial(new Vector2(m_start.X, m_start.Y));

                if (material != null && material == Grass.Instance)
                {
                    isCollided = new Vector2(m_start.X, m_start.Y);
                }
                else
                {
                    isCollided = null;
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
                        isCollided = new Vector2(x, m_start.Y);
                        break;
                    }
                    else
                    {
                        isCollided = null;
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
                        isCollided = new Vector2(m_start.X, y);
                        break;
                    }
                    else
                    {
                        isCollided = null;
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
                            isCollided = new Vector2(x, y);
                            break;
                        }
                        else
                        {
                            isCollided = null;
                        }
                    }
                }
              
            }
            return isCollided;
        }
    }
}
