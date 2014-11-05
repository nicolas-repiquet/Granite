using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_02
{
    public class LocationComponent : Component
    {
        public Box3 Location { get; set; }
        public Vector3 Direction { get; set; }

        public LocationComponent(Entity entity)
            : base(entity)
        {

        }
    }
}
