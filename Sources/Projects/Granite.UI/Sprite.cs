using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class Sprite
    {
        public Texture2D Texture { get; private set; }
        public Vector2 TextureCoordinates0 { get; private set; }
        public Vector2 TextureCoordinates1 { get; private set; }

        public Sprite(Texture2D texture, Vector2 textureCoordinates0, Vector2 textureCoordinates1)
        {
            Texture = texture;
            TextureCoordinates0 = textureCoordinates0;
            TextureCoordinates1 = textureCoordinates1;
        }
    }
}
