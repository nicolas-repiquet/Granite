using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Tools;

namespace Zombie.Game.Entities.Zones
{
    public class Light
    {
        private Cone m_light;
        private Vector2 m_position;

        public Vector2 Position { get { return m_position; } }

        public Cone Cone { get { return m_light; } }

        public Light(Vector2 position, float radius, Color4ub startColor, Color4ub endColor)
        {
            m_position = position;
            m_light = new Cone(
                position,
                radius,
                (float)Math.PI * 2f,
                startColor,
                endColor,
                0
                );
        }
    }
}
