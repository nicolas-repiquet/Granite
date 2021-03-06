﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities.Components;

namespace Zombie.Game.Entities
{
    public abstract class Entity
    {
        public Component FirstComponent { get; set; }


        public IEnumerable<Component> Components
        {
            get
            {
                var component = FirstComponent;
                while (component != null)
                {
                    yield return component;
                    component = component.NextComponent;
                }
            }
        }
    }
}
