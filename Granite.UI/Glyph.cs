using Granite3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class Glyph
    {
        private readonly Vector2i m_size;
        private readonly Texture2D m_texture;
        private readonly Box2 m_textureCoordinates;

        public Glyph(Vector2i size, Texture2D texture, Box2 textureCoordinates)
        {
            m_size = size;
            m_texture = texture;
            m_textureCoordinates = textureCoordinates;
        }
    }
}
