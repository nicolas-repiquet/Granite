using Granite.Core;
using Granite.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Zombie.GameStates;

namespace Zombie
{
    public class EntryPoint : ApplicationLogicBase
    {
        private double m_time60fps = 1000 / 60;
        private Stopwatch m_updateWatch;
        private Stopwatch m_renderWatch;
        private Stopwatch m_otherWatch;

        public static void Main(string[] args)
        {
            Engine.Run(new EntryPoint(), new ApplicationSettings()
            {
                DisplayStyle = DisplayStyle.ResizeableWithTitle,
            });
        }

        public override void InputEvent(InputEventArgs e)
        {
            StateManager.Instance.Input(e);
        }

        public override void Start()
        {
            m_updateWatch = new Stopwatch();
            m_renderWatch = new Stopwatch();
        }

        public override void Render(TimeSpan elapsed)
        {
            m_updateWatch.Reset();
            m_renderWatch.Reset();

            Engine.Display.Invalidate();

            m_updateWatch.Start(); 
            StateManager.Instance.Update(elapsed);
            m_updateWatch.Stop();

            var size = Engine.Display.GetSize();

            GL.Viewport(size);
            GL.ClearColor(0.6f, 0.8f, 1.0f, 1.0f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable_BLEND();
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

            m_renderWatch.Start();
            StateManager.Instance.Render(elapsed);
            m_renderWatch.Stop();


            Engine.Display.SetTitle(
                string.Format("{0:0} FPS, Update {1}%, Render {2}%",
                    Engine.Display.FramesPerSecond,
                    (m_updateWatch.ElapsedMilliseconds / m_time60fps) * 100,
                    (m_renderWatch.ElapsedMilliseconds / m_time60fps) * 100
                )
            );
        }
    }
}
