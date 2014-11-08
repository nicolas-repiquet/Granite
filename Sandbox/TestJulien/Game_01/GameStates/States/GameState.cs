using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestJulien.Game_01.Entities;

namespace TestJulien.Game_01.GameStates
{
    public class GameState : IGameState
    {
        private World m_world;
        private DateTime m_lastInput;

        public void Init()
        {
            m_lastInput = DateTime.Now;

            m_world = new World();
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

                if (Engine.Keyboard.IsKeyPressed(Key.F4))
                {
                    StateManager.Instance.SetGameState(EGameState.PAUSE);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Left))
                {
                   m_world.PlayerDestination.SetPosition(
                       new Vector2(m_world.PlayerDestination.Location.Position.X - 20, 
                       m_world.PlayerDestination.Location.Position.Y));
                   m_world.PlayerFinal.SetPosition(m_world.PlayerDestination.Location.Position);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Right))
                {
                    m_world.PlayerDestination.SetPosition(
                       new Vector2(m_world.PlayerDestination.Location.Position.X + 20,
                       m_world.PlayerDestination.Location.Position.Y));
                    m_world.PlayerFinal.SetPosition(m_world.PlayerDestination.Location.Position);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Down))
                {
                    m_world.PlayerDestination.SetPosition(
                       new Vector2(m_world.PlayerDestination.Location.Position.X,
                       m_world.PlayerDestination.Location.Position.Y - 20));
                    m_world.PlayerFinal.SetPosition(m_world.PlayerDestination.Location.Position);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Up))
                {
                    m_world.PlayerDestination.SetPosition(
                       new Vector2(m_world.PlayerDestination.Location.Position.X,
                       m_world.PlayerDestination.Location.Position.Y + 20));
                    m_world.PlayerFinal.SetPosition(m_world.PlayerDestination.Location.Position);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Space))
                {
                    m_world.Player.SetPosition(m_world.PlayerFinal.Location.Position);
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
