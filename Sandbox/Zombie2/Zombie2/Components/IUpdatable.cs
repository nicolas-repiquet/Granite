using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie2.Components
{
    public interface IUpdatable
    {
        void Update(TimeSpan elapsed);
    }
}
