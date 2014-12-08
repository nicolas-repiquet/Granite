using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;

namespace Zombie.Game.Entities.Tools
{
    public sealed class Camera : Entity, IUpdatable
    {
        private readonly LocationComponent m_location;
        private readonly FollowTargetComponent m_target;
        private readonly RestrictLocationComponent m_restrictPosition;

        private Box2 m_box;
        private double m_zoom;

        public LocationComponent Location { get { return m_location; } }
        public Box2 Box { get { return new Box2(m_location.Position - (m_box.Size * (float)m_zoom)/2, m_box.Size * (float)m_zoom); } }
        public ILocated Target { get { return m_target.Target; } set { m_target.Target = value; } }
        public Box2 Bounds { get { return m_restrictPosition.Bounds; } set { m_restrictPosition.Bounds = value; } }
        public double Zoom { get { return m_zoom; } 
            set {
                if (value >= 1)
                {
                    m_zoom = value;
                    World.World.Instance.Map.CameraHasChanged();
                }
            } 
        }

        public Camera()
        {
            m_location = new LocationComponent(this);
            m_target = new FollowTargetComponent(this, m_location);
            m_restrictPosition = new RestrictLocationComponent(this, m_location);
            m_zoom = 1.0;
        }

        public void SetSize(Vector2 size)
        {
            var center = m_location.Position;
            m_box = new Box2(center - size / 2, size);
        }

        public void Update(TimeSpan elapsed)
        {
            m_target.Update(elapsed);
            m_restrictPosition.Update(elapsed);
        }

        public Matrix4 CreateWorldToCameraTransform()
        {
            var transform = Matrix4.Identity;

            transform *= Matrix4.Translate(-1f, -1f, 0.0f);
            transform *= Matrix4.Scale(2f / (float)Box.Size.X, 2f / (float)Box.Size.Y, 1f);
            transform *= Matrix4.Translate(-(int)m_location.Position.X + Box.Size.X / 2, -(int)m_location.Position.Y + Box.Size.Y / 2, 0);

            return transform;
        }

        public Matrix4 CreateCameraToWorldTransform()
        {
            var transform = Matrix4.Identity;

            transform *= Matrix4.Translate((int)m_location.Position.X, (int)m_location.Position.Y, 0);
            transform *= Matrix4.Scale((float)m_box.Size.X / 2f, (float)m_box.Size.Y / 2f, 1f);
            transform *= Matrix4.Translate(1f, 1f, 0.0f);

            return transform;
        }
    }
}
