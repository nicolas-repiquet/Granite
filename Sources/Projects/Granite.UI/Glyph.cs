using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class Glyph
    {
        public Font Font { get; private set; }
        public char Character { get; private set; }
        public Vector2i Size { get; private set; }
        public Sprite Sprite { get; private set; }

        public Glyph(Font font, GlyphInfo info)
        {
            Font = font;
            Character = info.Character;
            Size = info.TextureBox.Size;
            Sprite = new Sprite(
                font.Texture,
                info.TextureBox.Position / (Vector2)font.Texture.Size,
                (info.TextureBox.Position + info.TextureBox.Size) / (Vector2)font.Texture.Size
            );
        }
    }

    public struct GlyphInfo
    {
        private readonly char m_character;
        public char Character { get { return m_character; } }
        private readonly Box2i m_textureBox;
        public Box2i TextureBox { get { return m_textureBox; } }

        public GlyphInfo(char character, Box2i textureBox)
        {
            m_character = character;
            m_textureBox = textureBox;
        }
    }
}
