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
        private bool m_mouseLeftPressed;
        private Vector2 m_mousePosition;

        public void Init()
        {
            m_mouseLeftPressed = false;
            m_mousePosition = Vector2.Zero;
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

        public void Input(InputEventArgs e)
        {
            var mouseButtonDownEvent = e as MouseButtonDownEventArgs;

            if (mouseButtonDownEvent != null)
            {
                if (mouseButtonDownEvent.Button == MouseButton.Left)
                {
                    m_mouseLeftPressed = true;
                    m_mousePosition = mouseButtonDownEvent.Position;
                }

                if (mouseButtonDownEvent.Button == MouseButton.Right)
                {
                    m_world.Player.NextWeapon();
                }
            }

            var mouseButtonUpEvent = e as MouseButtonUpEventArgs;

            if (mouseButtonUpEvent != null)
            {
                if (mouseButtonUpEvent.Button == MouseButton.Left)
                {
                    m_mouseLeftPressed = false;
                }
            }

            var mouseMoveEvent = e as MouseMoveEventArgs;

            if (mouseMoveEvent != null)
            {
                m_mousePosition = mouseMoveEvent.Position;
            }

            var keyboardKeyDownEvent = e as KeyboardKeyDownEventArgs;

            if (keyboardKeyDownEvent != null)
            {
                if (keyboardKeyDownEvent.Key == Key.F1)
                {
                    StateManager.Instance.SetGameState(EGameState.MAINMENU);
                }

                if (keyboardKeyDownEvent.Key == Key.F4)
                {
                    StateManager.Instance.SetGameState(EGameState.PAUSE);
                }

                if (keyboardKeyDownEvent.Key == Key.Up)
                {
                    m_world.Player.RigidBody.Direction += new Vector2(0, 30);
                }

                if (keyboardKeyDownEvent.Key == Key.Down)
                {
                    m_world.Player.RigidBody.Direction += new Vector2(0, -30);
                }

                if (keyboardKeyDownEvent.Key == Key.Left)
                {
                    m_world.Player.RigidBody.Direction += new Vector2(-30, 0);
                }

                if (keyboardKeyDownEvent.Key == Key.Right)
                {
                    m_world.Player.RigidBody.Direction += new Vector2(30, 0);
                }

                if (keyboardKeyDownEvent.Key == Key.R)
                {
                    m_world.Player.Weapon.ReloadCharger();
                }
            }
        }

        public void Update(TimeSpan elapsed)
        {
            m_world.Update(elapsed);

            if (m_mouseLeftPressed)
            {
                var target = new Vector2(
                    m_mousePosition.X,
                    Engine.Display.GetSize().Y-m_mousePosition.Y);
                m_world.Player.Fire(target);
                Console.WriteLine("Target : " + target.ToString());
            }
        }

        public void Draw()
        {
            m_world.Render(Matrix4.Identity);
        }
    }
}
