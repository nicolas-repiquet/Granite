using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.Entities
{
    public class LocationComponent : Component
    {
        public Box2d Location { get; set; }

        public LocationComponent(Entity entity)
            : base(entity)
        {

        }
    }
}
