using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Components
{
    public sealed class RigidBodyComponent : Component, IUpdatable
    {
        private readonly LocationComponent m_location;

        public RigidBodyComponent(Entity entity, LocationComponent location)
            : base(entity)
        {
            m_location = location;
            Velocity = new Vector2(0, 0);
        }

        public Vector2 Direction { get; set; }
        public double Mass { get; set; }
        public Vector2 Velocity { get; set; }
        public bool Grounded { get; set; }
        public bool BlockedLeft { get; set; }
        public bool BlockedRight { get; set; }

        public void Update(TimeSpan elapsed)
        {
            
            TestCollision(elapsed);
            
        }

        private void TestCollision(TimeSpan elapsed)
        {
            var momentum = new Vector2();

            momentum += Direction;

            Velocity += momentum * (float)elapsed.TotalSeconds;

            Direction = Vector2.Zero;

            if (Math.Abs(Velocity.X) > 100)
            {
                Velocity = new Vector2(Math.Sign(Velocity.X) * 100, Velocity.Y);
            }

            var lossX = Velocity.X * Math.Min(1f, 5f * (float)elapsed.TotalSeconds);
            var lossY = Velocity.Y * Math.Min(1f, 5f * (float)elapsed.TotalSeconds);
            Velocity = new Vector2(Velocity.X - lossX, Velocity.Y - lossY);

            var displacement = Velocity * (float)elapsed.TotalSeconds;
            var newLocation = m_location.Position + displacement;

            m_location.SetPosition(newLocation);
            
        }
    }
}
