using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Entities.Components
{
    public interface IRenderable
    {
        void Render(Matrix4 transform);
    }
}
