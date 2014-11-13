using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Entities.Components
{
    public class LocationComponent : Component
    {
        public Box2 Location { get; set; }

        public LocationComponent(Entity entity)
            : base(entity)
        {

        }
    }
}
