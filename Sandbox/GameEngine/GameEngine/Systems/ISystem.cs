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
    public interface ISystem : IObserver<GameObject>
    {
        void Update(TimeSpan elapsed);
    }

    public interface IRenderSystem : ISystem
    {
        void Render(Matrix4 transform);
    }
}
