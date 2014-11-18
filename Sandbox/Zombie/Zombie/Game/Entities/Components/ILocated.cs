﻿using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Components
{
    public interface ILocated
    {
        LocationComponent Location { get; }
    }
}
