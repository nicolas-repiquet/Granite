using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;

namespace Zombie.Game.Entities
{
    public class LifeComponent : Component
    {
        private double m_life;

        public bool IsAlive { get { return m_life > 0; } }
        public double Life { get { return m_life; } }

        public LifeComponent(Entity entity, int life)
            : base(entity)
        {
            m_life = life;
        }

        public void TakeDamage(double damage)
        {
            m_life -= damage;

            if (m_life < 0)
            {
                m_life = 0;
            }
        }
    }
}
