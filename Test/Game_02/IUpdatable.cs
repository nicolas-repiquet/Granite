using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_02
{
    public interface IUpdatable
    {
        void Update(TimeSpan elapsed);
    }
}
