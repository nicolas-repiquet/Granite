using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Entities.Components
{
    public interface IUpdatable
    {
        void Update(TimeSpan elapsed);
    }
}
