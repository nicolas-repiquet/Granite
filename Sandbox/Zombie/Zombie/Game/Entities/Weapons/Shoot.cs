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
        private MoveComponent m_move;
        private Cone m_cone;
        private double m_lifeTime;
        #endregion

        #region Accessors
        public Cone Cone { get { return m_cone; } }
        public double LifeTime { get { return m_lifeTime; } }
        #endregion

        #region Constructor
        public Shoot(Vector2 position, Vector2 direction, Vector4 startColor, Vector4 endColor, float angle = 2, float radius = 2)
        {
            m_location = new LocationComponent(this);
            m_location.SetPosition(position);

            m_move = new MoveComponent(this)
            {
                Direction = direction,
                Speed = 0
            };

            m_cone = new Cone(
                new Vector3(position.X, position.Y, 0),
                radius,
                angle,
                startColor,
                endColor,
                (float)Math.Atan2(direction.Y, direction.X) - (angle /2)
                );

            m_lifeTime = 0.5;
        }
        #endregion

        #region Methods
        public void Update(TimeSpan elapsed)
        {
            var newPos = m_location.Position + m_move.Direction * (float)elapsed.TotalSeconds * (float)m_move.Speed;
            m_location.SetPosition(newPos);

            m_cone.Center = new Vector3(newPos.X, newPos.Y, 0);

            m_lifeTime -= elapsed.TotalSeconds;
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
            m_move.Direction = direction;
            m_cone.StartAngle = (float)Math.Atan2(direction.Y, direction.X) - (m_cone.Angle / 2);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        #endregion
    }
}
