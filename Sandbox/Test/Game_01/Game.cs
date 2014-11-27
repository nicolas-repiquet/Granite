using Granite.Core;
using Granite.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Test.Game_01.Entities;
using Test.Game_01.GameStates;
using Test.Game_01.Levels;
using Test.Game_01.Maps;
using Test.Game_01.Sprites;

namespace Test.Game_01
{
    public class Game : ApplicationLogicBase
    {
        public static void Main(string[] args)
        {
            Engine.Run(new Game(), new ApplicationSettings()
            {
                DisplayStyle = DisplayStyle.ResizeableWithTitle
            });
        }

        public override void InputEvent(InputEventArgs e)
        {
            Console.WriteLine(e);
        }

        public override void Start()
        {
            
        }

        private Graphics m_g;


        public override void Render(TimeSpan elapsed)
        {
            if (m_g == null)
            {
                m_g = new Graphics();
            }

            Engine.Display.Invalidate();

            Engine.Display.SetTitle(string.Format("{0:0} FPS", Engine.Display.FramesPerSecond));

            //StateManager.Instance.Update(elapsed);

            var size = Engine.Display.GetSize();

            GL.Viewport(size);
            GL.ClearColor(0.6f, 0.8f, 1.0f, 1.0f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable_BLEND();
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

            //StateManager.Instance.Draw();

            m_g.FillRectangle(new Box2i(100, 100, 100, 100),
                new Color4ub(0xFF, 0xFF, 0x00, 0xFF));

            m_g.Flush();

            GL.Finish();
        }
    }
}
