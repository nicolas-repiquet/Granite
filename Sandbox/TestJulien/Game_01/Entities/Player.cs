using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJulien.Game_01.Entities
{
    public class Player : Entity, ILocated, IUpdatable, IRenderable
    {
        public Triangle[] Triangles { get; set; }

        private readonly LocationComponent m_location;
        private readonly RigidBodyComponent m_rigidBody;

        public Box2 Location { get { return m_location.Location; } }
        public RigidBodyComponent RigidBody { get { return m_rigidBody; } }

        public Player()
        {
            m_location = new LocationComponent(this);
            m_rigidBody = new RigidBodyComponent(this, m_location);

        }


        public void SetPosition(Vector2 position)
        {
            m_location.Location = new Box2(position, new Vector2(32, 32));
        }

        public void Update(TimeSpan elapsed)
        {
            m_rigidBody.Update(elapsed);

           
        }

        public void Render(Matrix4 transform)
        {
            
        }

        public Triangle[] ToTriangles()
        {
            Triangles = new Triangle[2];

            var color = new Vector4(0, 1, 0, 1);

            Triangles[0] = new Triangle()
            {
                P1 = new Vector3(Location.MinX, Location.MinY, 0),
                P2 = new Vector3(Location.MaxX, Location.MinY, 0),
                P3 = new Vector3(Location.MaxX, Location.MaxY, 0),
                Color = color
            };

            Triangles[1] = new Triangle()
            {
                P1 = new Vector3(Location.MinX, Location.MinY, 0),
                P2 = new Vector3(Location.MaxX, Location.MaxY, 0),
                P3 = new Vector3(Location.MinX, Location.MaxY, 0),
                Color = color
            };

            return Triangles;
        }
    }
}
