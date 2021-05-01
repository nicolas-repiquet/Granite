using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temple3D
{
    public struct Segment3
    {
        public Segment3(Vector3 p0, Vector3 p1)
        {
            P0 = p0;
            P1 = p1;
        }

        public Vector3 P0 { get; }
        public Vector3 P1 { get; }
    }
}
