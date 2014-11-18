using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Components
{
    public class RestrictLocationComponent : Component, IUpdatable
    {
        private readonly LocationComponent m_location;
        public Box2 Bounds { get; set; }

        public RestrictLocationComponent(Entity entity, LocationComponent location)
            : base(entity)
        {
            m_location = location;
        }

        public void Update(TimeSpan elapsed)
        {
            var x = m_location.Position.X;
            var y = m_location.Position.Y;
            var width = Math.Min(Bounds.Size.X, Bounds.Size.X);
            var height = Math.Min(Bounds.Size.Y, Bounds.Size.Y);

            if (x < Bounds.MinX)
            {
                x = Bounds.MinX;
            }
            else if (x > Bounds.MaxX - width)
            {
                x = Bounds.MaxX - width;
            }

            if (y < Bounds.MinY)
            {
                y = Bounds.MinY;
            }
            else if (y > Bounds.MaxY - height)
            {
                y = Bounds.MaxY - height;
            }

            Bounds = new Box2(x, y, width, height);
        }
    }
}
