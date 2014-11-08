using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_02
{
    public abstract class Component
    {
        public Entity Entity { get; private set; }
        public Component NextComponent { get; private set; }

        public Component(Entity entity)
        {
            Entity = entity;
            NextComponent = entity.FirstComponent;
            entity.FirstComponent = this;
        }
    }
}
