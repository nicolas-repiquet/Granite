using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.Sprites
{
    public interface ISpriteInstance
    {
        Sprite Sprite { get; set; }
        Vector2 Position { get; set; }
        Vector2 Size { get; set; }
    }
}
