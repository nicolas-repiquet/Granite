using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.UI
{
    public sealed class UIManager
    {
        private readonly Graphics m_graphics;

        public UIManager()
        {
            m_graphics = new Graphics(10000);
        }

        public void ProcessInputEvent(InputEventArgs e)
        {

        }

        public void Render(TimeSpan elapsed)
        {
            var size = Engine.Display.GetSize();

            m_graphics.Clear();
            m_graphics.Translate(new Vector2(-1, 1));
            m_graphics.Scale(new Vector2(2f / size.X, -2f / size.Y));

            m_graphics.Draw(
                new Box2(100f, 100f, 180f, 180f),
                new Color4ub(0xFF, 0x00, 0xFF, 0xFF)
            );

            m_graphics.Draw(
                new Box2(300f, 100f, 180f, 180f),
                new Color4ub(0xFF, 0xFF, 0x00, 0xFF)
            );

            m_graphics.Draw(
                new Box2(100f, 300f, 180f, 180f),
                new Color4ub(0x00, 0xFF, 0xFF, 0xFF)
            );

            m_graphics.Draw(
                new Vector2(100f, 500f),
                InternalFonts.RegularSmallVariableWidthFont,
                "Est-ce que ça va s'afficher bordel !!"
            );

            m_graphics.Flush();
        }
    }
}