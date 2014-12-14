using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Particle.Renderer
{
    public interface ISpriteInstance
    {
        Sprite Sprite { get; set; }
        Vector2 Position { get; set; }
        Vector2 Size { get; set; }
        Color4ub Color { get; set; }
        float Angle { get; set; }
        float Progress { get; set; }
    }
}
