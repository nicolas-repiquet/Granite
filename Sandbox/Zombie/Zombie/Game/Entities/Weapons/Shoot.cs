using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Tools;

namespace Zombie.Game.Entities.Weapons
{
    public class Shoot : Entity, ICloneable
    {
        #region Properties
        private Weapon m_weapon;
        private LocationComponent m_location;
        private Cone m_cone;
        private double m_lifeTime;
        private double m_lifeTimeTotal;
        #endregion

        #region Accessors
        public Cone Cone { get { return m_cone; } }
        public double LifeTime { get { return m_lifeTime; } }
        public Weapon Weapon { get { return m_weapon; } }
        #endregion

        #region Constructor
        public Shoot(Vector2 position, Vector2 direction, Color4ub startColor, Color4ub endColor, float angle = 2, float radius = 2)
        {
            m_location = new LocationComponent(this);
            m_location.SetPosition(position);

            m_cone = new Cone(
                position,
                radius,
                angle,
                startColor,
                endColor,
                (float)((Math.Atan2(direction.Y, direction.X) + Math.PI*2) - (angle / 2.0) - Math.PI*2)
                );

            m_lifeTimeTotal = 0.2;
            m_lifeTime = m_lifeTimeTotal;
        }
        #endregion

        #region Methods
        public void Update(TimeSpan elapsed)
        {
            m_cone.Center = m_location.Position;

            m_lifeTime -= elapsed.TotalSeconds;

            //Pourcentage du temps de vie passée
            var percent = m_lifeTime / m_lifeTimeTotal / 100;
            m_cone.StartColor = new Color4ub(m_cone.StartColor.R, m_cone.StartColor.G, m_cone.StartColor.B, (byte)(m_cone.StartColor.A - ((float)percent * 255f)));

            //if (m_cone.StartColor.W < 0.2f)
            //{
            m_cone.EndColor = new Color4ub(m_cone.EndColor.R, m_cone.EndColor.G, m_cone.EndColor.B, (byte)(m_cone.EndColor.A - ((float)(percent / 2f)*255f)));
            //}
        }

        public void SetWeapon(Weapon weapon)
        {
            m_weapon = weapon;
        }

        public void SetPosition(Vector2 position)
        {
            m_location.SetPosition(position);
            m_cone.Center = position;
        }

        public void SetDirection(Vector2 direction)
        {
            m_cone.StartAngle = (float)Math.Atan2(direction.Y, direction.X) - (m_cone.Angle / 2);
        }

        public object Clone()
        {
            var clone = (Shoot)this.MemberwiseClone();
            clone.m_cone = (Cone)m_cone.Clone();
            return (object)clone;
        }
        #endregion
    }
}
