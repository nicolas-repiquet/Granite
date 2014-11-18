using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;
using Zombie.Game.Entities.Tools;

namespace Zombie.Game.Entities.Weapons
{
    public class Bullet : Entity
    {
        #region Properties
        private Weapon m_weapon;
        private LocationComponent m_location;
        private MoveComponent m_move;
        private Point m_point;
        #endregion

        #region Accessors
        public Point Point { get { return m_point; } }
        #endregion

        #region Constructor
        public Bullet(Vector2 position, Vector2 direction, double speed, float radius = 2)
        {
            m_location = new LocationComponent(this);
            m_location.SetPosition(position);

            m_move = new MoveComponent(this)
            {
                Direction = direction,
                Speed = speed,
            };

            m_point = new Point()
                {
                    Center = new Vector3(position.X, position.Y, 0),
                    Color = new Vector4(1, 1, 0, 1),
                    Radius = radius
                };
        }
        #endregion

        #region Methods
        public void Update(TimeSpan elapsed)
        {
            var newPos = m_location.Position + m_move.Direction * (float)elapsed.TotalSeconds * (float)m_move.Speed;
            m_location.SetPosition(newPos);

            m_point.Center = new Vector3(newPos.X, newPos.Y, 0);
        }
        #endregion
    }
}
