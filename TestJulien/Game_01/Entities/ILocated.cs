﻿using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJulien.Game_01.Entities
{
    public interface ILocated
    {
        Box2 Location { get; }
    }
}
