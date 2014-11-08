using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_02
{
    public interface ITriangleInstance
    {
        Vector3 P1 { get; set; }
        Vector3 P2 { get; set; }
        Vector3 P3 { get; set; }
    }
}
