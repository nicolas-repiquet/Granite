using Granite.Core;
using Granite.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.GameStates.States
{
    public class PauseState : IGameState
    {
        private DateTime m_lastInput;
        private readonly Graphics m_g = new Graphics();

        public void Init()
        {
            m_lastInput = DateTime.Now;
            
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

                m_lastInput = DateTime.Now;
            }
        }

        public void Update(TimeSpan elapsed)
        {
            Input();
        }

        public void Draw()
        {
            m_g.FillRectangle(new Box2i(100, 100, 100, 100),
                new Color4ub(0xFF, 0x00, 0x00, 0xFF));

            m_g.Flush();
        }
    }
}
