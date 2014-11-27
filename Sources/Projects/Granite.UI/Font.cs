using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class Font
    {
        public Texture2D Texture { get; private set; }
        private readonly Dictionary<char, Glyph> m_glyphs;

        public Font(Texture2D texture, IEnumerable<GlyphInfo> glyphs)
        {
            Texture = texture;
            m_glyphs = new Dictionary<char, Glyph>();

            foreach (var glyph in glyphs)
            {
                m_glyphs[glyph.Character] = new Glyph(this, glyph);
            }
        }

        public Glyph GetGlyph(char character)
        {
            Glyph glyph;

            if (m_glyphs.TryGetValue(character, out glyph))
            {
                return glyph;
            }
            else
            {
                return null;
            }
        }
    }
}