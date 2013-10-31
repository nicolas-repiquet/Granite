using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite3D
{
    public interface IEngineLogic
    {
        void OnStart(Engine engine);
        void OnStop(Engine engine);
    }
}
