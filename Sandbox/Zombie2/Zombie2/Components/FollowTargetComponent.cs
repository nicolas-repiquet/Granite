using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie2.Components
{
    public sealed class FollowTargetComponent : Component, IUpdatable
    {
        private readonly LocationComponent m_location;

        public ILocated Target { get; set; }

        public FollowTargetComponent(Entity entity, LocationComponent location)
            : base(entity)
        {
            m_location = location;
        }

        public void Update(TimeSpan elapsed)
        {
            if (Target != null)
            {
                var targetPoint = Target.Location.Position;
                var currentPoint = m_location.Position;
                var displacement = (targetPoint - currentPoint);
                var distance = displacement.Length;

                if (distance > 1)
                {

                    displacement = displacement.Normalize() * distance;

                    m_location.SetPosition(m_location.Position + displacement);
                }
            }
        }
    }
}
