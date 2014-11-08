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
                var displacement = (targetPoint - currentPoint);
                var distance = displacement.Length;

                if (distance > 3)
                {
                    var speed = Math.Min(1, distance / 1000);
                    distance = Math.Min(distance, speed * 5000 * (float)elapsed.TotalSeconds);

                    displacement = displacement.Normalize() * distance;

                    m_location.Location = m_location.Location.Translate(displacement);
                }
            }
        }
    }
}
