using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Test.Game_01.Maps;

namespace Test.Game_01.Entities
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

            momentum += new Vector2(0, -1000); // gravity

            momentum += Direction;

            Velocity += momentum * (float)elapsed.TotalSeconds;

            Direction = Vector2.Zero;

            if (Math.Abs(Velocity.X) > 800)
            {
                Velocity = new Vector2(Math.Sign(Velocity.X) * 800, Velocity.Y);
            }

            {
                var loss = Velocity.X * Math.Min(1f, 5f * (float)elapsed.TotalSeconds);
                Velocity = new Vector2(Velocity.X - loss, Velocity.Y);
            }

            var displacement = Velocity * (float)elapsed.TotalSeconds;
            var newLocation = m_location.Location.Translate(displacement);

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            var collision = World.Instance.Level.Map.TestCollision(newLocation, displacement);
            //sw.Stop();

            //Console.WriteLine(string.Format("TestCollision : {0}", sw.Elapsed));

            Grounded = false;

            if (collision.HasValue)
            {
                if (collision.Value.Normal.Y == 1)
                {
                    Grounded = true;
                }

                if (collision.Value.AjustedLocation.Position.Y != newLocation.Position.Y)
                {
                    Velocity = new Vector2(Velocity.X, 0);
                }

                if (collision.Value.AjustedLocation.Position.X != newLocation.Position.X)
                {
                    Velocity = new Vector2(0, Velocity.Y);
                }

                newLocation = collision.Value.AjustedLocation;
            }

            m_location.Location = newLocation;
            
        }
    }
}
