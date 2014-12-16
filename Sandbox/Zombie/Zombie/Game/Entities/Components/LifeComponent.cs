using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Effects;

namespace Zombie.Game.Entities
{
    public class LifeComponent : Component
    {
        private double m_life;
        private bool m_hasTakenDamage;

        public bool IsAlive { get { return m_life > 0; } }
        public double Life { get { return m_life; } }
        public bool HasTakenDamage
        { 
            get {
                return m_hasTakenDamage; 
            } 
        }

        public LifeComponent(Entity entity, int life)
            : base(entity)
        {
            m_life = life;
            m_hasTakenDamage = false;
        }

        public void TakeDamage(double damage)
        {
            m_life -= damage;

            if (m_life < 0)
            {
                m_life = 0;
            }

            m_hasTakenDamage = true;
        }

        public void InstantDeath()
        {
            m_life = 0;
        }

        public void DamageProcessed()
        {
            m_hasTakenDamage = false;
        }
    }
}
