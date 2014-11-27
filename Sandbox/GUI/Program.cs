using Granite.Core;
using Granite.UI;
using GUI.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUI
{
    public class Program : ApplicationLogicBase
    {
        public static void Main(string[] args)
        {
            Engine.Run(new Program(), new ApplicationSettings()
            {
                DisplayStyle = DisplayStyle.ResizeableWithTitle
            });
        }

        private Theme_01 m_theme;
        private Graphics m_graphics;

        public override void Start()
        {
            m_graphics = new Graphics(10000);
            m_theme = Theme_01.Instance;
        }

        public override void Render(TimeSpan elapsed)
        {
            Engine.Display.SetTitle(string.Format("{0:0} FPS", Engine.Display.FramesPerSecond));

            var size = Engine.Display.GetSize();

            GL.Viewport(size);
            GL.ClearColor(0.3f, 0.3f, 0.3f, 1f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable_BLEND();
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

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
                new Box2(300f, 300f, 180f, 180f),
                m_theme.Texture,
                new Vector2(0, 0),
                new Vector2(1, 1)
            );

            m_graphics.Draw(
                new Vector2(100f, 500f),
                InternalFonts.RegularSmallVariableWidthFont,
                "Est-ce que ça va s'afficher bordel !!"
            );

            m_graphics.Flush();

            GL.Finish();

            Engine.Display.Invalidate();
        }
    }
}
