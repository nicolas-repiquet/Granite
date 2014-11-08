using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.Entities
{
    public interface IRenderable
    {
        void Render(Matrix4 transform);
    }
}
