using GameEngine.Components;
using GameEngine.Entities;
using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Systems
{
    public interface ISystem
    {
        bool Start();
        bool Update(TimeSpan elapsed, Matrix4 transform);
        bool End();
    }
}
