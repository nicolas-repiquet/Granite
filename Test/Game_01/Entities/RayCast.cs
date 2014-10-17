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

        public bool Collision()
        {
            var map = World.Instance.Level.Map;

            var material = map.GetMaterial(m_start);

            if (material == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
