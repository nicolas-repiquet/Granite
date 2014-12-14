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
        private readonly Graphics m_g = new Graphics();

        public void Init()
        {

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


        public void Input(InputEventArgs e)
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

        }

        public void Update(TimeSpan elapsed)
        {
     
        }

        public void Render(TimeSpan elapsed)
        {
            var size = Engine.Display.GetSize();

            m_g.Clear();
            m_g.Translate(new Vector2(-1, 1));
            m_g.Scale(new Vector2(2f / size.X, -2f / size.Y));

            m_g.Draw(
                new Vector2(size.X / 2, size.Y / 2),
                InternalFonts.RegularBigVariableWidthFont,
                "Pause",
                new Color4ub(0xFF, 0x00, 0x00, 0xFF)
            );
            m_g.Flush();
        }
    }
}
