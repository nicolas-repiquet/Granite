using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class FormattedText
    {
        private struct GlyphInstance
        {
            public readonly Box2 Rectangle;
            public readonly Sprite Sprite;

            public GlyphInstance(Box2 rectangle, Sprite sprite)
            {
                Rectangle = rectangle;
                Sprite = sprite;
            }
        }

        public static FormattedText Create(string text, Font font, TextAlignment alignment, SizeConstraint constraint)
        {
            if (text == null)
            {
                return new FormattedText(null, new Box2(0, 0, 0, 0), text, font, alignment, constraint);
            }
            else
            {
                var instances = new List<GlyphInstance>(text.Length);
                var x = 0f;

                foreach (var c in text)
                {
                    var glyph = font.GetGlyph(c);

                    if (glyph != null)
                    {
                        instances.Add(new GlyphInstance(new Box2(x, 0, glyph.Size.X, glyph.Size.Y), glyph.Sprite));
                        x += glyph.Size.X;
                    }
                }

                return new FormattedText(instances, new Box2(0, 0, x, font.Height), text, font, alignment, constraint);
            }
        }

        // *******************************************

        private readonly List<GlyphInstance> m_instances;
        public Box2 Bounds { get; private set; }
        public string Text { get; private set; }
        public Font Font { get; private set; }
        public TextAlignment Alignment { get; private set; }
        public SizeConstraint Constraint { get; private set; }

        private FormattedText(List<GlyphInstance> instances, Box2 bounds, string text, Font font, TextAlignment alignment, SizeConstraint constraint)
        {
            m_instances = instances;
            Bounds = bounds;
            Text = text;
            Font = font;
            Alignment = alignment;
            Constraint = constraint;
        }

        public void Draw(Graphics graphics, Color4ub color)
        {
            foreach (var instance in m_instances)
            {
                graphics.Draw(instance.Rectangle, instance.Sprite, color);
            }
        }
    }
}
