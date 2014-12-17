using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public abstract class InputEventArgs : EventArgs
    {
        public bool Handled { get; set; }
    }

    #region Mouse
    public enum MouseButton
    {
        Left,
        Middle,
        Right,
        Aux1,
        Aux2
    }

    public abstract class MouseEventArgs : InputEventArgs
    {

    }

    public sealed class MouseEnterEventArgs : MouseEventArgs
    {
        public override string ToString()
        {
            return string.Format("Mouse enter");
        }
    }

    public sealed class MouseLeaveEventArgs : MouseEventArgs
    {
        public override string ToString()
        {
            return string.Format("Mouse leave");
        }
    }

    public sealed class MouseButtonDownEventArgs : MouseEventArgs
    {
        public MouseButton Button { get; private set; }
        public Vector2 Position { get; private set; }
        public MouseButtonDownEventArgs(MouseButton button, Vector2 position)
        {
            Button = button;
            Position = position;
        }

        public override string ToString()
        {
            return string.Format("Mouse button down, button={0}, position={1},{2}", Button, Position.X, Position.Y);
        }
    }

    public sealed class MouseButtonUpEventArgs : MouseEventArgs
    {
        public MouseButton Button { get; private set; }
        public Vector2 Position { get; private set; }
        public MouseButtonUpEventArgs(MouseButton button, Vector2 position)
        {
            Button = button;
            Position = position;
        }

        public override string ToString()
        {
            return string.Format("Mouse button up, button={0}, position={1},{2}", Button, Position.X, Position.Y);
        }
    }

    public sealed class MouseMoveEventArgs : MouseEventArgs
    {
        public Vector2 Position { get; private set; }
        public MouseMoveEventArgs(Vector2 position)
        {
            Position = position;
        }

        public override string ToString()
        {
            return string.Format("Mouse move, position={0},{1}", Position.X, Position.Y);
        }
    }

    public sealed class MouseWheelEventArgs : MouseEventArgs
    {
        public float Ticks { get; private set; }
        public Vector2 Position { get; private set; }
        public MouseWheelEventArgs(float ticks, Vector2 position)
        {
            Ticks = ticks;
            Position = position;
        }

        public override string ToString()
        {
            return string.Format("Mouse wheel, ticks={0}, position={1},{2}", Ticks, Position.X, Position.Y);
        }
    }
    #endregion

    #region Keyboard
    public class KeyboardEventArgs : InputEventArgs
    {

    }

    public class KeyboardKeyDownEventArgs : KeyboardEventArgs
    {
        public Key Key { get; private set; }
        public KeyboardKeyDownEventArgs(Key key)
        {
            Key = key;
        }

        public override string ToString()
        {
            return string.Format("Keyboard key down, key={0}", Key);
        }
    }

    public class KeyboardKeyUpEventArgs : KeyboardEventArgs
    {
        public Key Key { get; private set; }
        public KeyboardKeyUpEventArgs(Key key)
        {
            Key = key;
        }

        public override string ToString()
        {
            return string.Format("Keyboard key up, key={0}", Key);
        }
    }

    public class CharacterEventArgs : InputEventArgs
    {
        public char Value { get; private set; }
        public CharacterEventArgs(char value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return string.Format("Character, value='{0}'", Value);
        }
    }
    #endregion

}
