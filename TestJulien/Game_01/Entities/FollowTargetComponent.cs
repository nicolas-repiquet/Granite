using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.Entities
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

                // TODO: use elapsed... but how ?
                var distance = (targetPoint - currentPoint) * 0.1f;

                m_location.Location = m_location.Location.Translate(distance);
            }
        }
    }
}
