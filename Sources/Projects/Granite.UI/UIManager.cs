using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class UIManager : UIElement
    {
        private readonly Graphics m_graphics;
        private UIElement m_root;

        public UIManager()
        {
            m_graphics = new Graphics(10000);
        }

        public UIElement Root
        {
            get { return m_root; }
            set
            {
                if (m_root != value)
                {
                    if (m_root != null)
                    {
                        m_root.Parent = null;
                    }

                    m_root = value;

                    if (m_root != null)
                    {
                        m_root.Parent = this;
                    }
                }
            }
        }

        public void ProcessInputEvent(InputEventArgs e)
        {
            
        }

        public override void Render(Graphics graphics, TimeSpan elapsed)
        {
            if (m_root != null)
            {
                var bounds = m_root.Bounds;

                m_graphics.PushTransform();
                m_graphics.Translate(bounds.Position);
                m_root.Render(graphics, elapsed);
                m_graphics.PopTransform();
            }
        }

        public void Render(TimeSpan elapsed)
        {
            var size = Engine.Display.GetSize();

            m_graphics.Clear();
            m_graphics.Ortho(0, size.X, size.Y, 0);

            Render(m_graphics, elapsed);

            m_graphics.Flush();
        }

        public override IEnumerable<UIElement> GetChildren()
        {
            if (m_root != null)
            {
                yield return m_root;
            }
            else
            {
                yield break;
            }
        }
    }
}