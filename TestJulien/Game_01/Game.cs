﻿using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Entities;
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
                DisplayStyle = DisplayStyle.FixedWithTitle
            });
        }


        private World m_world;
        private HashSet<Key> m_keys;

        public override void Start()
        {
            m_keys = new HashSet<Key>();
            m_world = new World(new Level_01());
        }

        int x = 0;
        int y = 0;

        public override void KeyDown(Key key)
        {
            m_keys.Add(key);
        }

        public override void KeyUp(Key key)
        {
            m_keys.Remove(key);
        }

        private void Update(TimeSpan elapsed)
        {
            if (m_keys.Contains(Key.Right))
            {
                x += 5;
            }
            if (m_keys.Contains(Key.Left))
            {
                x -= 5;
            }
            if (m_keys.Contains(Key.Up))
            {
                y += 5;
            }
            if (m_keys.Contains(Key.Down))
            {
                y -= 5;
            }

            //m_world.Player.SetPosition(new Vector2d(x, y));
        }

        private DateTime? m_previousFrame;

        public override void Render()
        {
            try
            {
                var now = DateTime.Now;
                TimeSpan elapsed;
                if (m_previousFrame.HasValue)
                {
                    elapsed = now - m_previousFrame.Value;
                }
                else
                {
                    elapsed = TimeSpan.Zero;
                }
                m_previousFrame = now;

                Update(elapsed);
                m_world.Update(elapsed);

                var size = Engine.Display.GetSize();

                GL.Viewport(size);
                GL.ClearColor(0.6f, 0.8f, 1.0f, 1.0f);
                //GL.ClearColor(1f, 0.0f, 0.0f, 1.0f);
                GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
                GL.Enable_BLEND();
                GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

                m_world.Render(Matrix4.Identity);

                Engine.Display.Invalidate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + ", " + e.StackTrace);
            }
        }
    }
}