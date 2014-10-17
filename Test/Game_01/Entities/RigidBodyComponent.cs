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
            Velocity = new Vector2(0, 0);
        }


        public double Mass { get; set; }
        public Vector2 Velocity { get; set; }
        public bool Grounded { get; set; }
        public bool BlockedLeft { get; set; }
        public bool BlockedRight { get; set; }

        public void Update(TimeSpan elapsed)
        {
            //Velocity += new Vector2(0, -300) * (float)elapsed.TotalSeconds;

            //var p = m_location.Location.Position + Velocity * (float)elapsed.TotalSeconds;

            //if (p.Y <= 0)
            //{
            //    p = new Vector2(p.X, 0);
            //    Velocity = new Vector2(Velocity.X, -Velocity.Y);
            //}

            //m_location.Location = new Box2(p, m_location.Location.Size);

            TestCollision(elapsed);
        }

        private void TestCollision(TimeSpan elapsed)
        {
            Velocity += new Vector2(0, -300) * (float)elapsed.TotalSeconds;

            //En fonction de la vélocité, on utilise 3 raycast pour tester les collisions
            if (Velocity.Y != 0)
            {
                if (Velocity.Y < 0)
                {
                    var rayLeft = new RayCast(
                        new Vector2(m_location.Location.Position.X + 10, m_location.Location.Position.Y),
                        new Vector2(0, -1));

                    var rayCenter = new RayCast(
                        new Vector2(m_location.Location.Position.X + (m_location.Location.Size.X / 2f), m_location.Location.Position.Y),
                        new Vector2(0, -1));

                    var rayRight = new RayCast(
                        new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - 10, m_location.Location.Position.Y),
                        new Vector2(0, -1));

                    if (!rayLeft.Collision() && !rayCenter.Collision() && !rayRight.Collision())
                    {
                        Grounded = false;
                    }
                    else
                    {
                        Grounded = true;
                    }
                }
                else
                {
                    Grounded = false;
                }
            }

            if (Velocity.X != 0)
            {
                if (Velocity.X < 0)
                {
                    var rayTop = new RayCast(
                        new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + m_location.Location.Size.Y),
                        new Vector2(-1, 0));

                    var rayCenter = new RayCast(
                        new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + (m_location.Location.Size.Y / 2f)),
                        new Vector2(-1, 0));

                    var rayBottom = new RayCast(
                        new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + 10f),
                        new Vector2(-1, 0));

                    if (!rayTop.Collision() && !rayCenter.Collision() && !rayBottom.Collision())
                    {
                        BlockedLeft = false;
                    }
                    else
                    {
                        BlockedLeft = true;
                    }
                }
                else
                {
                    var rayTop = new RayCast(
                         new Vector2(m_location.Location.Position.X + m_location.Location.Size.X, m_location.Location.Position.Y + m_location.Location.Size.Y),
                         new Vector2(1, 0));

                    var rayCenter = new RayCast(
                        new Vector2(m_location.Location.Position.X + m_location.Location.Size.X, m_location.Location.Position.Y + (m_location.Location.Size.Y / 2f)),
                        new Vector2(1, 0));

                    var rayBottom = new RayCast(
                        new Vector2(m_location.Location.Position.X + m_location.Location.Size.X, m_location.Location.Position.Y + 10f),
                        new Vector2(1, 0));

                    if (!rayTop.Collision() && !rayCenter.Collision() && !rayBottom.Collision())
                    {
                        BlockedRight = false;
                    }
                    else
                    {
                        BlockedRight = true;
                    }
                }
            }

            var x = 0f;
            var y = 0f;

            if (!Grounded || (Grounded && Velocity.Y > 0))
            {
                y = Velocity.Y;
            }

            if (BlockedLeft && BlockedRight)
            {
                x = 0f;
            }
            else if (BlockedLeft && !BlockedRight && Velocity.X > 0)
            {
                x = Velocity.X;
            }
            else if (!BlockedLeft && BlockedRight && Velocity.X < 0)
            {
                x = Velocity.X;
            }
            else if (!BlockedLeft && !BlockedRight && Velocity.X != 0)
            {
                x = Velocity.X;
            }

            Velocity = new Vector2(x, y);

            var newPosition = m_location.Location.Position + Velocity * (float)elapsed.TotalSeconds;
            m_location.Location = new Box2(newPosition, m_location.Location.Size);
        }

        private void TestCollision2(TimeSpan elapsed)
        {
            Velocity += new Vector2(0, -300) * (float)elapsed.TotalSeconds;

            var newPosition = m_location.Location.Position + Velocity * (float)elapsed.TotalSeconds;

            //En fonction de la vélocité, on utilise 3 raycast pour tester les collisions
            if (Velocity.Y != 0)
            {
                if (Velocity.Y < 0)
                {
                    var rayLeft = new RayCast(
                        new Vector2(m_location.Location.Position.X + 10, m_location.Location.Position.Y),
                        new Vector2(newPosition.X + 10, newPosition.Y));

                    var rayCenter = new RayCast(
                        new Vector2(m_location.Location.Position.X + (m_location.Location.Size.X / 2f), m_location.Location.Position.Y),
                        new Vector2(newPosition.X + (m_location.Location.Size.X / 2f), newPosition.Y));

                    var rayRight = new RayCast(
                        new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - 10, m_location.Location.Position.Y),
                        new Vector2(newPosition.X + m_location.Location.Size.X - 10, newPosition.Y));

                    if (!rayLeft.Collision() && !rayCenter.Collision() && !rayRight.Collision())
                    {
                        Grounded = false;
                    }
                    else
                    {
                        Grounded = true;
                    }
                }
                else
                {
                    Grounded = false;
                }
            }

            if (Velocity.X != 0)
            {
                if (Velocity.X < 0)
                {
                    var rayTop = new RayCast(
                        new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + m_location.Location.Size.Y),
                        new Vector2(newPosition.X, newPosition.Y + m_location.Location.Size.Y));

                    var rayCenter = new RayCast(
                        new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + (m_location.Location.Size.Y / 2f)),
                        new Vector2(newPosition.X, newPosition.Y + (m_location.Location.Size.Y / 2f)));

                    var rayBottom = new RayCast(
                        new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + 10f),
                        new Vector2(newPosition.X, newPosition.Y + 10f));

                    if (!rayTop.Collision() && !rayCenter.Collision() && !rayBottom.Collision())
                    {
                        BlockedLeft = false;
                    }
                    else
                    {
                        BlockedLeft = true;
                    }
                }
                else
                {
                    var rayTop = new RayCast(
                         new Vector2(m_location.Location.Position.X + m_location.Location.Size.X, m_location.Location.Position.Y + m_location.Location.Size.Y),
                         new Vector2(newPosition.X + m_location.Location.Size.X, newPosition.Y + m_location.Location.Size.Y));

                    var rayCenter = new RayCast(
                        new Vector2(m_location.Location.Position.X + m_location.Location.Size.X, m_location.Location.Position.Y + (m_location.Location.Size.Y / 2f)),
                        new Vector2(newPosition.X + m_location.Location.Size.X, newPosition.Y + (m_location.Location.Size.Y / 2f)));

                    var rayBottom = new RayCast(
                        new Vector2(m_location.Location.Position.X + m_location.Location.Size.X, m_location.Location.Position.Y + 10f),
                        new Vector2(newPosition.X + m_location.Location.Size.X, newPosition.Y + 10f));

                    if (!rayTop.Collision() && !rayCenter.Collision() && !rayBottom.Collision())
                    {
                        BlockedRight = false;
                    }
                    else
                    {
                        BlockedRight = true;
                    }
                }
            }

            var x = 0f;
            var y = 0f;

            if (!Grounded || (Grounded && Velocity.Y > 0))
            {
                y = Velocity.Y;
            }

            if (BlockedLeft && BlockedRight)
            {
                x = 0f;
            }
            else if (BlockedLeft && !BlockedRight && Velocity.X > 0)
            {
                x = Velocity.X;
            }
            else if (!BlockedLeft && BlockedRight && Velocity.X < 0)
            {
                x = Velocity.X;
            }
            else if (!BlockedLeft && !BlockedRight && Velocity.X != 0)
            {
                x = Velocity.X;
            }

            Velocity = new Vector2(x, y);

            var newPosition = m_location.Location.Position + Velocity * (float)elapsed.TotalSeconds;
            m_location.Location = new Box2(newPosition, m_location.Location.Size);
        }
    }
}
