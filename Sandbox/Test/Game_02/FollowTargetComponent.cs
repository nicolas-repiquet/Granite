using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_02
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
                var targetPoint = Target.Location.Center;
                var currentPoint = m_location.Location.Center;
                m_location.Direction = (targetPoint - currentPoint).Normalize();

            }
        }
    }
}
