using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie2.Components
{
    public abstract class Component : ICloneable
    {
        public Entity Entity { get; private set; }
        public Component NextComponent { get; private set; }

        public Component(Entity entity)
        {
            Entity = entity;
            NextComponent = entity.FirstComponent;
            entity.FirstComponent = this;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
