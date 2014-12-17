using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class UILabel : UIElement
    {
        public UILabel()
        {
            Color = new Color4ub(0x00, 0x00, 0x00, 0xFF);
        }

        private string m_text;
        public string Text {
            get { return m_text; }
            set
            {
                if (m_text != value)
                {
                    m_text = value;
                    m_formatedText = null;
                }
            }
        }

        private TextAlignment m_alignment;
        public TextAlignment Alignment
        {
            get { return m_alignment; }
            set
            {
                if (m_alignment != value)
                {
                    m_alignment = value;
                    m_formatedText = null;
                }
            }
        }

        private Font m_font;
        public Font Font
        {
            get { return m_font; }
            set
            {
                if (m_font != value)
                {
                    m_font = value;
                    m_formatedText = null;
                }
            }
        }

        public Color4ub Color { get; set; }

        private FormattedText m_formatedText;

        public override IEnumerable<UIElement> GetChildren()
        {
            return Enumerable.Empty<UIElement>();
        }

        public override void Render(Graphics graphics, TimeSpan elapsed)
        {
            if (!string.IsNullOrWhiteSpace(Text))
            {
                if (m_formatedText == null)
                {
                    m_formatedText = FormattedText.Create(
                        Text,
                        Font ?? InternalFonts.RegularSmallVariableWidthFont,
                        Alignment,
                        new SizeConstraint(0, 0)
                    );
                }

                m_formatedText.Draw(graphics, Color);
            }
        }
    }
}