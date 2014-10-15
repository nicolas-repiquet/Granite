using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.Entities
{
    public sealed class Camera : Entity, IUpdatable
    {
        private readonly LocationComponent m_location;
        private readonly FollowTargetComponent m_target;
        private readonly RestrictLocationComponent m_restrictPosition;

        public Box2d Location { get { return m_location.Location; } }
        public ILocated Target { get { return m_target.Target; } set { m_target.Target = value; } }
        public Box2d Bounds { get { return m_restrictPosition.Bounds; } set { m_restrictPosition.Bounds = value; } }

        public Camera()
        {
            m_location = new LocationComponent(this);
            m_target = new FollowTargetComponent(this, m_location);
            m_restrictPosition = new RestrictLocationComponent(this, m_location);
        }

        public void SetSize(Vector2d size)
        {
            var center = m_location.Location.Center;
            m_location.Location = new Box2d(center - size / 2, size);
        }

        public void Update(TimeSpan elapsed)
        {
            m_target.Update(elapsed);
            m_restrictPosition.Update(elapsed);
        }

        public Matrix4 CreateWorldToCameraTransform()
        {
            var location = m_location.Location;

            var transform = Matrix4.Identity;

            transform *= Matrix4.Translate(-1f, -1f, 0.0f);
            transform *= Matrix4.Scale(2f / (float)location.Size.X, 2f / (float)location.Size.Y, 1f);
            transform *= Matrix4.Translate(-(int)location.Position.X, -(int)location.Position.Y, 0);

            return transform;
        }

        public Matrix4 CreateCameraToWorldTransform()
        {
            var location = m_location.Location;

            var transform = Matrix4.Identity;

            transform *= Matrix4.Translate((int)location.Position.X, (int)location.Position.Y, 0);
            transform *= Matrix4.Scale((float)location.Size.X / 2f, (float)location.Size.Y / 2f, 1f);
            transform *= Matrix4.Translate(1f, 1f, 0.0f);

            return transform;
        }
    }
}
