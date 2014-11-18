using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Components
{
    public class MoveComponent : Component
    {
        public Vector2 Direction { get; set; }
        public double Speed { get; set; }

        public MoveComponent(Entity entity)
            : base(entity)
        {

        }
    }
}
