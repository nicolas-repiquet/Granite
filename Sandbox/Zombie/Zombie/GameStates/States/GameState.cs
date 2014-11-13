using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities;

namespace Zombie.GameStates.States
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
                    m_world.Player.RigidBody.Direction += new Vector2(-30000, 0);
                }

                if (Engine.Keyboard.IsKeyPressed(Key.Right))
                {
                    m_world.Player.RigidBody.Direction += new Vector2(30000, 0);
                }

                if (m_world.Player.RigidBody.Grounded && Engine.Keyboard.IsKeyPressed(Key.Up))
                {
                    m_world.Player.RigidBody.Velocity += new Vector2(0, 550);
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
