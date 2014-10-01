using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Game_01.Sprites
{
    public sealed class Sprite
    {
        public SpriteSheet SpriteSheet { get; private set; }
        public string Name { get; private set; }
        public Vector2i Size { get; private set; }
        public Box2d Coordinates { get; private set; }

        public Sprite(SpriteSheet spriteSheet, string name, Vector2i size, Box2d coordinates)
        {
            SpriteSheet = spriteSheet;
            Name = name;
            Size = size;
            Coordinates = coordinates;
        }
    }
}