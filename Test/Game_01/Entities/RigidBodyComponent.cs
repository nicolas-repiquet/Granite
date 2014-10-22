using Granite.Core;
using System;
using System.Collections.Generic;
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

            if (Engine.Keyboard.IsKeyPressed(Key.Left))
            {
                momentum += new Vector2(-1500, 0);
            }

            if (Engine.Keyboard.IsKeyPressed(Key.Right))
            {
                momentum += new Vector2(1500, 0);
            }

            Velocity += momentum * (float)elapsed.TotalSeconds;

            if (Math.Abs(Velocity.X) > 800)
            {
                Velocity = new Vector2(Math.Sign(Velocity.X) * 800, Velocity.Y);
            }

            {
                var loss = Velocity.X * Math.Min(1f, 5f * (float)elapsed.TotalSeconds);
                Velocity = new Vector2(Velocity.X - loss, Velocity.Y);
            }

            Vector2 newTargetPosition = m_location.Location.Position + Velocity * (float)elapsed.TotalSeconds;

            var cadran = Map.Cadran(m_location.Location.Position, newTargetPosition);

            var skin = 0.2f;

            var result = new List<Tuple<float?, float?, double, double>>();


            Vector2 newPosition = new Vector2(m_location.Location.Position.X + skin, m_location.Location.Position.Y + skin) + Velocity * (float)elapsed.TotalSeconds;
            var r1 = new RayCast(new Vector2(m_location.Location.Position.X + skin, m_location.Location.Position.Y + skin),
                newPosition,
                new Vector2(0, 0));
            result.Add(r1.Collision2());

            newPosition = new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - skin, m_location.Location.Position.Y + skin) + Velocity * (float)elapsed.TotalSeconds;
            var r2 = new RayCast(new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - skin, m_location.Location.Position.Y + skin),
                newPosition,
                new Vector2(m_location.Location.Size.X, 0));
            result.Add(r2.Collision2());

            newPosition = new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - skin, m_location.Location.Position.Y + m_location.Location.Size.Y - skin) + Velocity * (float)elapsed.TotalSeconds;
            var r3 = new RayCast(
                new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - skin, m_location.Location.Position.Y + m_location.Location.Size.Y - skin),
                newPosition,
                new Vector2(m_location.Location.Size.X, m_location.Location.Size.Y));
            result.Add(r3.Collision2());

            newPosition = new Vector2(m_location.Location.Position.X + skin, m_location.Location.Position.Y + m_location.Location.Size.Y - skin) + Velocity * (float)elapsed.TotalSeconds;
            var r4 = new RayCast(
                new Vector2(m_location.Location.Position.X + skin, m_location.Location.Position.Y + m_location.Location.Size.Y - skin),
                newPosition,
                new Vector2(0, m_location.Location.Size.Y));
            result.Add(r4.Collision2());

            float? collisionX = null;
            float? collisionY = null;

            //On parcours tous les ray pour trouve les collisions les plus proches
            foreach (var item in result)
            {
                if (item.Item3 != -1.0 && item.Item1.HasValue && (collisionX == null || item.Item1.Value < collisionX))
                {
                    collisionX = item.Item1.Value;
                }

                if (item.Item4 != -1.0 && item.Item2.HasValue && (collisionY == null || item.Item2.Value < collisionY))
                {
                    collisionY = item.Item2.Value;
                }
            }

            //S'il y a une collision
            if (collisionX.HasValue || collisionY.HasValue)
            {
                Velocity = new Vector2(
                    collisionX.HasValue ? 0f : Velocity.X,
                    collisionY.HasValue ? 0f : Velocity.Y);

                Grounded = collisionY <= m_location.Location.Position.Y;

                m_location.Location = new Box2(
                    new Vector2(
                        collisionX.HasValue ? collisionX.Value : newTargetPosition.X,
                        collisionY.HasValue ? collisionY.Value : newTargetPosition.Y
                        ),
                    m_location.Location.Size);
            }
            else
            {
                m_location.Location = new Box2(newTargetPosition, m_location.Location.Size);
                Grounded = false;
            }
        }

        //private void TestCollision(TimeSpan elapsed)
        //{
        //    var momentum = new Vector2();

        //    momentum += new Vector2(0, -1000); // gravity

        //    if (Engine.Keyboard.IsKeyPressed(Key.Left))
        //    {
        //        momentum += new Vector2(-1500, 0);
        //    }

        //    if (Engine.Keyboard.IsKeyPressed(Key.Right))
        //    {
        //        momentum += new Vector2(1500, 0);
        //    }

        //    Velocity += momentum * (float)elapsed.TotalSeconds;

        //    if (Math.Abs(Velocity.X) > 800)
        //    {
        //        Velocity = new Vector2(Math.Sign(Velocity.X) * 800, Velocity.Y);
        //    }

        //    {
        //        var loss = Velocity.X * Math.Min(1f, 5f * (float)elapsed.TotalSeconds);
        //        Velocity = new Vector2(Velocity.X - loss, Velocity.Y);
        //    }

        //    Vector2 newTargetPosition = m_location.Location.Position + Velocity * (float)elapsed.TotalSeconds;

        //    var cadran = Map.Cadran(m_location.Location.Position, newTargetPosition);

        //    var skin = 0f;

        //    var result = new List<Tuple<Vector2?, Vector2, double, Guid>>();

        //    //On fait 2 raycast par coté
        //    if (cadran.X < 0)
        //    {
        //        Vector2 newPosition = new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + skin) + new Vector2(Velocity.X, 0) * (float)elapsed.TotalSeconds;
        //        var r1 = new RayCast(new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + skin),
        //            newPosition, 
        //            new Vector2(0, 0));
        //        result.Add(r1.Collision2());

        //        newPosition = new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + m_location.Location.Size.Y - skin) + new Vector2(Velocity.X, 0) * (float)elapsed.TotalSeconds;
        //        var r2 = new RayCast(new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + m_location.Location.Size.Y - skin),
        //            newPosition, 
        //            new Vector2(0, 0));
        //        result.Add(r2.Collision2());
        //    }

        //    if (cadran.X > 0)
        //    {
        //        Vector2 newPosition = new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - 0.1f, m_location.Location.Position.Y + skin) + new Vector2(Velocity.X, 0) * (float)elapsed.TotalSeconds;
        //        var r1 = new RayCast(new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - 0.1f, m_location.Location.Position.Y + skin),
        //            newPosition, 
        //            new Vector2(0, 0));
        //        result.Add(r1.Collision2());

        //        newPosition = new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - 0.1f, m_location.Location.Position.Y + m_location.Location.Size.Y - skin) + new Vector2(Velocity.X, 0) * (float)elapsed.TotalSeconds;
        //        var r2 = new RayCast(new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - 0.1f, m_location.Location.Position.Y + m_location.Location.Size.Y - skin),
        //            newPosition,
        //            new Vector2(0, 0));
        //        result.Add(r2.Collision2());
        //    }

        //    if (cadran.Y > 0)
        //    {
        //        Vector2 newPosition = new Vector2(m_location.Location.Position.X + skin, m_location.Location.Position.Y + m_location.Location.Size.Y - 0.1f) + new Vector2(0, Velocity.Y) * (float)elapsed.TotalSeconds;
        //        var r1 = new RayCast(
        //            new Vector2(m_location.Location.Position.X + skin, m_location.Location.Position.Y + m_location.Location.Size.Y - 0.1f),
        //            newPosition,
        //            new Vector2(0, 0));
        //        result.Add(r1.Collision2());

        //        newPosition = new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - skin, m_location.Location.Position.Y + m_location.Location.Size.Y - 0.1f) + new Vector2(0, Velocity.Y) * (float)elapsed.TotalSeconds;
        //        var r2 = new RayCast(
        //            new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - skin, m_location.Location.Position.Y + m_location.Location.Size.Y - 0.1f),
        //            newPosition, 
        //            new Vector2(0, 0));
        //        result.Add(r2.Collision2());
        //    }

        //    if (cadran.Y < 0)
        //    {
        //        Vector2 newPosition = new Vector2(m_location.Location.Position.X + skin, m_location.Location.Position.Y) + new Vector2(0, Velocity.Y) * (float)elapsed.TotalSeconds;
        //        var r1 = new RayCast(
        //            new Vector2(m_location.Location.Position.X + skin, m_location.Location.Position.Y),
        //            newPosition, 
        //            new Vector2(0, 0));
        //        result.Add(r1.Collision2());

        //        newPosition = new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - skin, m_location.Location.Position.Y) + new Vector2(0, Velocity.Y) * (float)elapsed.TotalSeconds;
        //        var r2 = new RayCast(
        //            new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - skin, m_location.Location.Position.Y),
        //            newPosition,  
        //            new Vector2(0, 0));
        //        result.Add(r2.Collision2());
        //    }

        //    Tuple<Vector2?, Vector2, double, Guid> v = null;
        //    var collision = Vector2.Zero;

        //    //On parcours tous les ray pour trouve les collisions les plus proches
        //    foreach (var item in result)
        //    {
        //        if (item.Item3 != -1.0 && (item.Item2.X != 0 || item.Item2.Y != 0))
        //        {
        //            v = item;

        //            if (item.Item2.X == 1 && (collision.X == 0 || collision.X > item.Item1.Value.X))
        //            {
        //                collision = new Vector2(item.Item1.Value.X, collision.Y);
        //            }
        //            else if (item.Item2.X == -1 && collision.X < item.Item1.Value.X)
        //            {
        //                collision = new Vector2(item.Item1.Value.X, collision.Y);
        //            }
        //            if (item.Item2.Y == 1 && (collision.Y == 0 ||collision.Y > item.Item1.Value.Y))
        //            {
        //                collision = new Vector2(collision.X, item.Item1.Value.Y);
        //            }
        //            else if (item.Item2.Y == -1 && collision.Y < item.Item1.Value.Y)
        //            {
        //                collision = new Vector2(collision.X, item.Item1.Value.Y);
        //            }
        //        }
        //    }

        //    //S'il y a une collision
        //    if (collision != Vector2.Zero)
        //    {
        //        Velocity = new Vector2(
        //            collision.X != 0f ? 0f : Velocity.X,
        //            collision.Y != 0f ? 0f : Velocity.Y);
                
        //        Grounded = collision.Y <= m_location.Location.Position.Y;

        //        m_location.Location = new Box2(
        //            new Vector2(
        //                collision.X != 0f ? collision.X : newTargetPosition.X,
        //                collision.Y != 0f ? collision.Y : newTargetPosition.Y
        //                ),
        //            m_location.Location.Size);
        //    }
        //    else
        //    {
        //        m_location.Location = new Box2(newTargetPosition, m_location.Location.Size);
        //        Grounded = false;
        //    }
        //}

        //private void TestCollision(TimeSpan elapsed)
        //{
        //    var momentum = new Vector2();

        //    momentum += new Vector2(0, -1000); // gravity

        //    if (Engine.Keyboard.IsKeyPressed(Key.Left))
        //    {
        //        //if (Grounded)
        //        //{
        //            momentum += new Vector2(-1500, 0);
        //        //}
        //        //else
        //        //{
        //        //    momentum += new Vector2(-600, 0);
        //        //}
        //    }

        //    if (Engine.Keyboard.IsKeyPressed(Key.Right))
        //    {
        //        //if (Grounded)
        //        //{
        //            momentum += new Vector2(1500, 0);
        //        //}
        //        //else
        //        //{
        //        //    momentum += new Vector2(600, 0);
        //        //}
        //    }

        //    Velocity += momentum * (float)elapsed.TotalSeconds;

        //    if (Math.Abs(Velocity.X) > 800)
        //    {
        //        Velocity = new Vector2(Math.Sign(Velocity.X) * 800, Velocity.Y);
        //    }

        //    //if (Grounded)
        //    {
        //        var loss = Velocity.X * Math.Min(1f, 5f * (float)elapsed.TotalSeconds);
        //        Velocity = new Vector2(Velocity.X - loss, Velocity.Y);
        //    }

        //    var newPosition = m_location.Location.Position + Velocity * (float)elapsed.TotalSeconds;

        //    //En fonction de la vélocité, on utilise 3 raycast pour tester les collisions
        //    if (Velocity.Y != 0)
        //    {
        //        if (Velocity.Y < 0)
        //        {
        //            var rayLeft = new RayCast(
        //                new Vector2(m_location.Location.Position.X + 10, m_location.Location.Position.Y),
        //                new Vector2(newPosition.X + 10, newPosition.Y));

        //            var rayCenter = new RayCast(
        //                new Vector2(m_location.Location.Position.X + (m_location.Location.Size.X / 2f), m_location.Location.Position.Y),
        //                new Vector2(newPosition.X + (m_location.Location.Size.X / 2f), newPosition.Y));

        //            var rayRight = new RayCast(
        //                new Vector2(m_location.Location.Position.X + m_location.Location.Size.X - 10, m_location.Location.Position.Y),
        //                new Vector2(newPosition.X + m_location.Location.Size.X - 10, newPosition.Y));

        //            if (!rayLeft.Collision() && !rayCenter.Collision() && !rayRight.Collision())
        //            {
        //                Grounded = false;
        //                Console.WriteLine("Not Grounded !");
        //            }
        //            else
        //            {
        //                Grounded = true;
        //                Console.WriteLine("Grounded !");
        //            }
        //        }
        //        //else
        //        //{
        //        //    Grounded = false;
        //        //}
        //    }

        //    if (Velocity.X != 0)
        //    {
        //        if (Velocity.X < 0)
        //        {
        //            var rayTop = new RayCast(
        //                new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + m_location.Location.Size.Y),
        //                new Vector2(newPosition.X, newPosition.Y + m_location.Location.Size.Y));

        //            var rayCenter = new RayCast(
        //                new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + (m_location.Location.Size.Y / 2f)),
        //                new Vector2(newPosition.X, newPosition.Y + (m_location.Location.Size.Y / 2f)));

        //            var rayBottom = new RayCast(
        //                new Vector2(m_location.Location.Position.X, m_location.Location.Position.Y + 10f),
        //                new Vector2(newPosition.X, newPosition.Y + 10f));

        //            var rayTopColl = rayTop.Collision();
        //            var rayCenterColl = rayCenter.Collision();
        //            var rayBottomColl = rayBottom.Collision();

        //            if (rayTopColl == null && rayCenterColl == null && rayBottomColl == null)
        //            {
        //                BlockedLeft = false;
        //            }
        //            else
        //            {
        //                BlockedLeft = true;
        //            }
        //        }
        //        else
        //        {
        //            var rayTop = new RayCast(
        //                 new Vector2(m_location.Location.Position.X + m_location.Location.Size.X, m_location.Location.Position.Y + m_location.Location.Size.Y),
        //                 new Vector2(newPosition.X, newPosition.Y + m_location.Location.Size.Y));

        //            var rayCenter = new RayCast(
        //                new Vector2(m_location.Location.Position.X + m_location.Location.Size.X, m_location.Location.Position.Y + (m_location.Location.Size.Y / 2f)),
        //                new Vector2(newPosition.X + m_location.Location.Size.X, newPosition.Y + (m_location.Location.Size.Y / 2f)));

        //            var rayBottom = new RayCast(
        //                new Vector2(m_location.Location.Position.X + m_location.Location.Size.X, m_location.Location.Position.Y + 10f),
        //                new Vector2(newPosition.X + m_location.Location.Size.X, newPosition.Y + 10f));

        //            if (!rayTop.Collision() && !rayCenter.Collision() && !rayBottom.Collision())
        //            {
        //                BlockedRight = false;
        //            }
        //            else
        //            {
        //                BlockedRight = true;
        //            }
        //        }
        //    }

        //    var x = 0f;
        //    var y = 0f;

        //    if (!Grounded || (Grounded && Velocity.Y > 0))
        //    {
        //        y = Velocity.Y;
        //    }

        //    if (BlockedLeft && BlockedRight)
        //    {
        //        x = 0f;
        //    }
        //    else if (BlockedLeft && !BlockedRight && Velocity.X > 0)
        //    {
        //        x = Velocity.X;
        //    }
        //    else if (!BlockedLeft && BlockedRight && Velocity.X < 0)
        //    {
        //        x = Velocity.X;
        //    }
        //    else if (!BlockedLeft && !BlockedRight && Velocity.X != 0)
        //    {
        //        x = Velocity.X;
        //    }

        //    Velocity = new Vector2(x, y);

        //    newPosition = m_location.Location.Position + Velocity * (float)elapsed.TotalSeconds;
        //    m_location.Location = new Box2(newPosition, m_location.Location.Size);
        //}

    }
}
