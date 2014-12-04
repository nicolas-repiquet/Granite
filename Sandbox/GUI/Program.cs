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
            Engine.AddLogAppender(new ConsoleLogAppender());

            var settings = new ApplicationSettings()
            {
                DisplayStyle = DisplayStyle.ResizeableWithTitle,
                VerticalSynchronization = true
            };

            #if DEBUG
            settings.Debug = true;
            #endif

            Engine.Run(new Program(), settings);
        }

        private UIManager m_uiManager;
        private UILabel m_label;

        public override void Start()
        {
            m_uiManager = new UIManager();
            m_label = new UILabel()
            {
                Color = new Color4ub(0xFF, 0x80, 0x80, 0xFF),
                Font = InternalFonts.BoldSmallVariableWidthFont
            };
            m_uiManager.Root = m_label;

            Engine.Display.SetCursor(Cursor.IBeam);
        }

        public override void InputEvent(InputEventArgs e)
        {
            Engine.LogDebug(e.ToString());
            m_uiManager.ProcessInputEvent(e);
        }

        public override void Render(TimeSpan elapsed)
        {
            Engine.Display.SetTitle(string.Format("{0:0} FPS", Engine.Display.FramesPerSecond));

            var size = Engine.Display.GetSize();

            GL.Viewport(size);
            GL.ClearColor(0.3f, 0.3f, 0.3f, 1f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable_BLEND();
            //GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

            //m_label.Text = string.Format("Time elapsed since previous frame: {0}", elapsed.ToString());
            //m_uiManager.Render(elapsed);

            //GL.ClearColor(0.3f, 0.3f, 0.3f, 1f);
            //GL.Clear(GL.COLOR_BUFFER_BIT);

            GL.BlendFunc(GL.ONE, GL.ONE);
            //GL.BlendEquation(GL.FUNC_ADD);

            Graphics g = new Graphics();
            for (int i = 0; i < 10; i++)
            {
                g.Draw(new Box2(i * 0.03f, i * 0.03f, 0.2f, 0.2f), new Color4ub(0xFF, 0x20, 0x02, 0xFF));
            }
            g.Flush();


            GL.Finish();

            Engine.Display.Invalidate();
        }
    }
}
