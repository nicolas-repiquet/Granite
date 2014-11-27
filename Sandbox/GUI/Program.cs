﻿using Granite.Core;
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

        private UIManager m_uiManager;

        public override void Start()
        {
            m_uiManager = new UIManager();
        }

        public override void InputEvent(InputEventArgs e)
        {
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
            GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

            m_uiManager.Render(elapsed);

            GL.Finish();

            Engine.Display.Invalidate();
        }
    }
}
