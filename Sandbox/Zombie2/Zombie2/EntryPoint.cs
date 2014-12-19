using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie2
{
    public class EntryPoint : ApplicationLogicBase
    {
        private World m_world;
        
        public static void Main(string[] args)
        {
            Engine.AddLogAppender(new ConsoleLogAppender());

            Engine.Run(new EntryPoint(), new ApplicationSettings()
            {
                DisplayStyle = DisplayStyle.ResizeableWithTitle,
            });
        }

        public override void InputEvent(InputEventArgs e)
        {
            
        }

        public override void Start()
        {
            m_world = new World();
        }

        public override void Render(TimeSpan elapsed)
        {
            Engine.Display.Invalidate();

            Engine.Display.SetTitle(string.Format("{0:0} FPS", Engine.Display.FramesPerSecond));

            m_world.Update(elapsed);

            var size = Engine.Display.GetSize();

            GL.Viewport(size);
            GL.ClearColor(0.6f, 0.8f, 1.0f, 1.0f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable_BLEND();
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

            m_world.Render(elapsed, Matrix4.Identity);

            GL.Finish();
        }
    }
}
