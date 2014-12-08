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

        public Cone Cone { get { return m_light; } }

        public Light(Vector2 position, float radius, Color4ub startColor, Color4ub endColor)
        {
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
