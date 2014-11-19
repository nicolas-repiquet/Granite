using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Components
{
    public class MoveComponent : Component
    {
        private readonly LocationComponent m_location;
        private Vector2 m_newLocation;

        public Vector2 Direction { get; set; }
        public Vector2 LastDirection { get; set; }
        public double Speed { get; set; }
        public Vector2 NewLocation { get { return m_newLocation; } }

        public MoveComponent(Entity entity, LocationComponent location)
            : base(entity)
        {
            m_location = location;
            m_newLocation = Vector2.Zero;
            Direction = Vector2.Zero;
            Speed = 100;
        }

        public void Update(TimeSpan elapsed)
        {
            if (Direction != Vector2.Zero)
            {
                m_newLocation = m_location.Position + (Direction.Normalize() * (float)Speed) * (float)elapsed.TotalSeconds;
                m_location.SetPosition(m_newLocation);
                LastDirection = Direction;
                Direction = Vector2.Zero;
            }
        }
    }
}
