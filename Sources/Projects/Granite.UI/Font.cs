using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class Font
    {
        private readonly Texture2D m_texture;
        private readonly Dictionary<char, Glyph> m_glyphs;

        public Font(Texture2D texture, IEnumerable<GlyphPosition> glyphs)
        {
            m_texture = texture;
            m_glyphs = new Dictionary<char, Glyph>();

            foreach (var glyph in glyphs)
            {
                m_glyphs[glyph.Character] = new Glyph(
                    this,
                    glyph.Position.Size,
                    new Box2(
                        glyph.Position.Position.X / m_texture.Size.X,
                        glyph.Position.Position.Y / m_texture.Size.Y,
                        glyph.Position.Size.X / m_texture.Size.X,
                        glyph.Position.Size.Y / m_texture.Size.Y
                    )
                );
            }
        }
    }
}
