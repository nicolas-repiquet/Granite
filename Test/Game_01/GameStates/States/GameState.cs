using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Game_01.Entities;
using Test.Game_01.Levels;

namespace Test.Game_01.GameStates
{
    public class GameState : IGameState
    {
        private World m_world;
        private DateTime m_lastInput;

        public void Init()
        {
            m_lastInput = DateTime.Now;

            m_world = new World(new Level_01());
            Update(new TimeSpan());
        }

        public void Cleanup()
        {
           
        }

        public void Pause()
        {
            
        }

        public void Resume()
        {
            
        }

        private void Input()
        {
            if ((DateTime.Now - m_lastInput).TotalMilliseconds > 100)
            {
                if (Engine.Keyboard.IsKeyPressed(Key.F1))
                {
                    StateManager.Instance.SetGameState(EGameState.MAINMENU);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.F2))
                {
                    StateManager.Instance.SetGameState(EGameState.GAME);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.F3))
                {
                    StateManager.Instance.SetGameState(EGameState.EDITOR);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.F4))
                {
                    StateManager.Instance.SetGameState(EGameState.PAUSE);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Left))
                {
                    //momentum += new Vector2(-1500, 0);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Right))
                {
                    //momentum += new Vector2(1500, 0);
                }

                m_lastInput = DateTime.Now;
            }
        }

        public void Update(TimeSpan elapsed)
        {
            m_world.Update(elapsed);

            Input();
        }

        public void Draw()
        {
            m_world.Render(Matrix4.Identity);
        }
    }
}
