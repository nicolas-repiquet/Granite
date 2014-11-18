using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithread
{
    public class SphereState
    {
        public Sphere Sphere { get; set; }
        public bool HasMoved { get; set; }

        public SphereState()
        {
            HasMoved = false;
        }
    }
}
