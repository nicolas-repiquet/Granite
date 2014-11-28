using GameEngine.Components;
using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Systems
{
    public interface ISystem : IObserver<Component>
    {

    }

    public interface IUpdateSystem
    {
        void Update(TimeSpan elapsed);
    }

    public interface IRenderSystem
    {
        void Render(Matrix4 transform);
    }
}
