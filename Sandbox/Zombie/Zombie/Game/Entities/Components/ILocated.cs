using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Entities.Components
{
    public interface ILocated
    {
        Box2 Location { get; }
    }
}
