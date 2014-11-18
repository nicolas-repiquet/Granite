using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithread
{
    public class Sphere
    {
        public LocationComponent Location { get; set; }
        public float Radius { get; set; }

        public Sphere()
        {
            Location = new LocationComponent();
        }
    }
}
