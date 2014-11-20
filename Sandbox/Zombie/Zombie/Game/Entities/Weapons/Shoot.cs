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
        public Shoot(Vector2 position, Vector2 direction, Vector4 startColor, Vector4 endColor, float angle = 2, float radius = 2)
        {
            m_location = new LocationComponent(this);
            m_location.SetPosition(position);

            m_cone = new Cone(
                new Vector3(position.X, position.Y, 0),
                radius,
                angle,
                startColor,
                endColor,
                (float)Math.Atan2(direction.Y, direction.X) - (angle /2)
                );

            m_lifeTimeTotal = 1;
            m_lifeTime = m_lifeTimeTotal;
        }
        #endregion

        #region Methods
        public void Update(TimeSpan elapsed)
        {
            m_cone.Center = new Vector3(m_location.Position.X, m_location.Position.Y, 0);

            m_lifeTime -= elapsed.TotalSeconds;

            //Pourcentage du temps de vie passée
            var percent = m_lifeTime / m_lifeTimeTotal / 100;
            m_cone.StartColor = new Vector4(m_cone.StartColor.X, m_cone.StartColor.Y, m_cone.StartColor.Z, m_cone.StartColor.W - (float)percent);

            //if (m_cone.StartColor.W < 0.2f)
            //{
                m_cone.EndColor = new Vector4(m_cone.EndColor.X, m_cone.EndColor.Y, m_cone.EndColor.Z, m_cone.EndColor.W - (float)(percent /2));
            //}
        }

        public void SetWeapon(Weapon weapon)
        {
            m_weapon = weapon;
        }

        public void SetPosition(Vector2 position)
        {
            m_location.SetPosition(position);
            m_cone.Center = new Vector3(position.X, position.Y, 0);
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
