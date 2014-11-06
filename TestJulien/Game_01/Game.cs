using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TestJulien.Game_01.Entities;
using TestJulien.Game_01.GameStates;
using TestJulien.Game_01.Levels;
using TestJulien.Game_01.Maps;
using TestJulien.Game_01.Sprites;

namespace TestJulien.Game_01
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
            //Console.WriteLine(e);
        }

        public override void Start()
        {
            
        }

        public override void Render(TimeSpan elapsed)
        {
            Engine.Display.Invalidate();

            Engine.Display.SetTitle(string.Format("{0:0} FPS", Engine.Display.FramesPerSecond));

            StateManager.Instance.Update(elapsed);

            var size = Engine.Display.GetSize();

            GL.Viewport(size);
            GL.ClearColor(0.6f, 0.8f, 1.0f, 1.0f);
            GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            GL.Enable_BLEND();
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

            StateManager.Instance.Draw();

            GL.Finish();
        }
    }
}
