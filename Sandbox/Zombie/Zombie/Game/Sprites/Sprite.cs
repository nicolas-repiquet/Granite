using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.Game.Sprites
{
    public sealed class Sprite
    {
        public SpriteSheet SpriteSheet { get; private set; }
        public string Name { get; private set; }
        public Vector2i Size { get; private set; }
        public Box2 Coordinates { get; private set; }

        public Sprite(SpriteSheet spriteSheet, string name, Vector2i size, Box2 coordinates)
        {
            SpriteSheet = spriteSheet;
            Name = name;
            Size = size;
            Coordinates = coordinates;
        }
    }
}