using Granite.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Zombie2
{
    public class EntryPoint : ApplicationLogicBase
    {
        private World m_world;
        private double m_time60fps = 1000 / 60;
        private Stopwatch m_updateWatch;
        private Stopwatch m_renderWatch;
        private Stopwatch m_otherWatch;
        
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
            m_updateWatch = new Stopwatch();
            m_renderWatch = new Stopwatch();
            m_otherWatch = new Stopwatch();
        }

        public override void Render(TimeSpan elapsed)
        {
            m_updateWatch.Reset();
            m_renderWatch.Reset();
            m_otherWatch.Reset();

            Engine.Display.Invalidate();

            m_updateWatch.Start(); 
            m_world.Update(elapsed);
            m_updateWatch.Stop();

           
            var size = Engine.Display.GetSize();

            GL.Viewport(size);
            GL.ClearColor(0.6f, 0.8f, 1.0f, 1.0f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable_BLEND();
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);
            
            m_renderWatch.Start();
            m_world.Render(elapsed, Matrix4.Identity);
            m_renderWatch.Stop();

            m_otherWatch.Start();
            //GL.Finish();
            m_otherWatch.Stop();

            Engine.Display.SetTitle(
                string.Format("{0:0} FPS, Update {1}%, Render {2}%, Other {3}%",
                    Engine.Display.FramesPerSecond,
                    (m_updateWatch.ElapsedMilliseconds / m_time60fps) * 100,
                    (m_renderWatch.ElapsedMilliseconds / m_time60fps) * 100,
                    (m_otherWatch.ElapsedMilliseconds / m_time60fps) * 100
                )
            );
        }
    }
}
