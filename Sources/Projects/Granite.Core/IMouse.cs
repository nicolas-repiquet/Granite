using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite.Core
{
    public interface IMouse
    {
        bool IsButtonPressed(MouseButton button);
    }
}