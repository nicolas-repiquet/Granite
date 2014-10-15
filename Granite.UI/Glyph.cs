using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class Glyph
    {
        private readonly Font m_font;
        private readonly Vector2i m_size;
        private readonly Box2 m_textureCoordinates;

        public Glyph(Font font, Vector2i size, Box2 textureCoordinates)
        {
            m_font = font;
            m_size = size;
            m_textureCoordinates = textureCoordinates;
        }
    }

    public struct GlyphPosition
    {
        private readonly char m_character;
        public char Character { get { return m_character; } }
        private readonly Box2i m_position;
        public Box2i Position { get { return m_position; } }

        public GlyphPosition(char character, Box2i position)
        {
            m_character = character;
            m_position = position;
        }
    }
}
