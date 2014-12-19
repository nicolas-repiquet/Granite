using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie2.Components
{
    public class LocationComponent : Component
    {
        public Vector2 m_previousPosition;
        public Vector2 m_position;

        public Vector2 PreviousPosition { get { return m_previousPosition; } }
        public Vector2 Position { get { return m_position; } }

        public LocationComponent(Entity entity)
            : base(entity)
        {

        }

        public void SetPosition(Vector2 position)
        {
            m_previousPosition = m_position;
            m_position = position;
        }
    }
}
