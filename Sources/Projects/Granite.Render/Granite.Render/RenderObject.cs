using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Render
{
    public sealed class RenderObject
    {
        public Sprite Sprite { get; set; }
        public SpriteSequence SpriteSequence { get; set; }
        public Vector2[] Position { get; set; }
        public Vector2i Size { get; set; }
        public Color4ub Color { get; set; }
    }
}
