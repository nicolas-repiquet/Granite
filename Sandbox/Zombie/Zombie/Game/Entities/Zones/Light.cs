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
        private Cone2 m_light;

        public Cone2 Cone { get { return m_light; } }

        public Light(Vector3 position, float radius, Vector4 startColor, Vector4 endColor)
        {
            m_light = new Cone2(
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
