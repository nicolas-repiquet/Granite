﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public abstract class InputEventArgs : EventArgs
    {

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

    }

    public sealed class MouseLeaveEventArgs : MouseEventArgs
    {

    }

    public sealed class MouseButtonDownEventArgs : MouseEventArgs
    {
        public MouseButton Button { get; private set; }
        public Vector2i Position { get; private set; }
        public MouseButtonDownEventArgs(MouseButton button, Vector2i position)
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
        public Vector2i Position { get; private set; }
        public MouseButtonUpEventArgs(MouseButton button, Vector2i position)
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
        public Vector2i Position { get; private set; }
        public MouseMoveEventArgs(Vector2i position)
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
        public Vector2i Position { get; private set; }
        public MouseWheelEventArgs(float ticks, Vector2i position)
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
    #endregion

}