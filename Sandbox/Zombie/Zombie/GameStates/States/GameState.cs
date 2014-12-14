using Granite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zombie.Game.Entities;
using Zombie.Game.Entities.World;
using Zombie.Game.UI;

namespace Zombie.GameStates.States
{
    public class GameState : IGameState
    {
        private World m_world;
        private UIGame m_ui;
        private bool m_mouseLeftPressed;
        private bool m_keyUpPressed;
        private bool m_keyDownPressed;
        private bool m_keyLeftPressed;
        private bool m_keyRightPressed;
        private Vector2 m_mousePosition;

        public void Init()
        {
            m_mouseLeftPressed = false;
            m_keyUpPressed = false;
            m_keyDownPressed = false;
            m_keyLeftPressed = false;
            m_keyRightPressed = false;
            m_mousePosition = Vector2.Zero;
            m_world = new World();
            m_world.Initialize();
            m_ui = new UIGame();
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

            var mouseButtonWheelEvent = e as MouseWheelEventArgs;

            if (mouseButtonWheelEvent != null)
            {
                World.Instance.Camera.Zoom -= mouseButtonWheelEvent.Ticks;
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

                if (keyboardKeyDownEvent.Key == Key.Up || keyboardKeyDownEvent.Key == Key.Z)
                {
                    m_keyUpPressed = true;
                }

                if (keyboardKeyDownEvent.Key == Key.Down || keyboardKeyDownEvent.Key == Key.S)
                {
                    m_keyDownPressed = true;
                }

                if (keyboardKeyDownEvent.Key == Key.Left || keyboardKeyDownEvent.Key == Key.Q)
                {
                    m_keyLeftPressed = true;
                }

                if (keyboardKeyDownEvent.Key == Key.Right || keyboardKeyDownEvent.Key == Key.D)
                {
                    m_keyRightPressed = true;
                }

                if (keyboardKeyDownEvent.Key == Key.R)
                {
                    m_world.Player.Weapon.ReloadCharger();
                }
            }

            var keyboardKeyUpEvent = e as KeyboardKeyUpEventArgs;

            if (keyboardKeyUpEvent != null)
            {
                if (keyboardKeyUpEvent.Key == Key.Up || keyboardKeyUpEvent.Key == Key.Z)
                {
                    m_keyUpPressed = false;
                }

                if (keyboardKeyUpEvent.Key == Key.Down || keyboardKeyUpEvent.Key == Key.S)
                {
                    m_keyDownPressed = false;
                }

                if (keyboardKeyUpEvent.Key == Key.Left || keyboardKeyUpEvent.Key == Key.Q)
                {
                    m_keyLeftPressed = false;
                }

                if (keyboardKeyUpEvent.Key == Key.Right || keyboardKeyUpEvent.Key == Key.D)
                {
                    m_keyRightPressed = false;
                }
            }
        }

        public void Update(TimeSpan elapsed)
        {
            m_world.Update(elapsed);

            if (m_mouseLeftPressed)
            {
                //var target = new Vector2(
                //    m_mousePosition.X,
                //    Engine.Display.GetSize().Y-m_mousePosition.Y);
                m_world.Player.Fire(m_mousePosition);
                //Console.WriteLine("Target : " + target.ToString());
            }

            if (m_keyUpPressed)
            {
                m_world.Player.Move.Direction += new Vector2(0, 1);
            }

            if (m_keyDownPressed)
            {
                m_world.Player.Move.Direction += new Vector2(0, -1);
            }

            if (m_keyLeftPressed)
            {
                m_world.Player.Move.Direction += new Vector2(-1, 0);
            }

            if (m_keyRightPressed)
            {
                m_world.Player.Move.Direction += new Vector2(1, 0);
            }
        }

        public void Render(TimeSpan elapsed)
        {
            m_world.Render(Matrix4.Identity);

            m_ui.Render(elapsed);
        }
    }
}
