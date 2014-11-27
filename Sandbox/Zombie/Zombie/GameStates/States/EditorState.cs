using Granite.Core;
using Granite.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zombie.GameStates.States
{
    public class EditorState : IGameState
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


            if (Engine.Keyboard.IsKeyPressed(Key.F4))
            {
                StateManager.Instance.SetGameState(EGameState.PAUSE);
            }

        }

        public void Update(TimeSpan elapsed)
        {

        }

        public void Draw()
        {
            var size = Engine.Display.GetSize();

            m_g.Clear();
            m_g.Translate(new Vector2(-1, 1));
            m_g.Scale(new Vector2(2f / size.X, -2f / size.Y));

            m_g.Draw(
                new Vector2(size.X / 2, size.Y / 2),
                InternalFonts.RegularBigVariableWidthFont,
                "Editeur",
                new Color4ub(0xFF, 0x00, 0x00, 0xFF)
            );
            m_g.Flush();
        }
    }
}
