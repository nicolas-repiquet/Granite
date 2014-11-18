using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Entities.Tools
{
    public interface ISegmentInstance
    {
        Vector3 P1 { get; set; }
        Vector3 P2 { get; set; }
    }
}
