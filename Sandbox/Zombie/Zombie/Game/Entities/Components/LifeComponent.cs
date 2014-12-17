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
        private double m_lifeTotal;
        private BloodType? m_hasTakenDamage;

        public bool IsAlive { get { return m_life > 0; } }
        public double Life { get { return m_life; } }
        public BloodType? HasTakenDamage
        { 
            get {
                return m_hasTakenDamage; 
            } 
        }

        public LifeComponent(Entity entity, int life)
            : base(entity)
        {
            m_lifeTotal = life;
            m_life = m_lifeTotal;
            m_hasTakenDamage = null;
        }

        public void TakeDamage(double damage)
        {
            m_life -= damage;

            if (m_life < 0)
            {
                m_life = 0;
                m_hasTakenDamage = BloodType.D;
            }
            else
            {
                var percent = damage / m_lifeTotal;
                if (percent < 0.5)
                {
                    m_hasTakenDamage = BloodType.B;
                }
                else
                {
                    m_hasTakenDamage = BloodType.A;
                }
            }
        }

        public void InstantDeath()
        {
            m_life = 0;
        }

        public void DamageProcessed()
        {
            m_hasTakenDamage = null;
        }
    }
}
