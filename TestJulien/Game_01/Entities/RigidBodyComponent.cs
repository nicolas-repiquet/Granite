using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.Entities
{
    public sealed class RigidBodyComponent : Component, IUpdatable
    {
        private readonly LocationComponent m_location;

        public RigidBodyComponent(Entity entity, LocationComponent location)
            : base(entity)
        {
            m_location = location;
            Velocity = new Vector2d(200, 0);
        }


        public double Mass { get; set; }
        public Vector2d Velocity { get; set; }

        public void Update(TimeSpan elapsed)
        {
            Velocity += new Vector2d(0, -300) * elapsed.TotalSeconds;

            var p = m_location.Location.Position + Velocity * elapsed.TotalSeconds;

            if (p.Y <= 0)
            {
                p = new Vector2d(p.X, 0);
                Velocity = new Vector2d(Velocity.X, -Velocity.Y);
            }

            m_location.Location = new Box2d(p, m_location.Location.Size);
        }
    }
}
