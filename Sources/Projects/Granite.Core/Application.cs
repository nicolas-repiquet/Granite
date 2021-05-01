using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Granite.Core
{
    internal sealed class Application : IKeyboard, IMouse, IDisposable
    {
        private readonly Thread m_thread;
        private readonly IApplicationLogic m_logic;
        private readonly Queue<Action> m_actions;
        private readonly Display m_display;
        private readonly ApplicationSynchronizationContext m_synchronizationContext;
        private readonly Stopwatch m_stopwatch;
        private TimeSpan m_previousFrame = TimeSpan.MinValue;
        private double m_framesPerSecond = 0f;
        private bool m_isMouseInWindow = false;
        private bool[] m_keys;
        private HashSet<MouseButton> m_pressedButtons;

        public Application(IApplicationLogic logic, ApplicationSettings settings)
        {
            m_keys = new bool[0xFF];
            m_pressedButtons = new HashSet<MouseButton>();
            m_thread = Thread.CurrentThread;
            m_actions = new Queue<Action>();
            m_logic = logic;
            m_display = new Display(this, WindowProc, settings.DisplayStyle);
            GL.Initialize(
                m_display,
                settings.DisplayColorBits,
                settings.DisplayDepthBits,
                settings.Debug
            );
            GL.SwapInterval(settings.VerticalSynchronization ? 1 : 0);
            m_synchronizationContext = new ApplicationSynchronizationContext(m_display.Handle);
            m_stopwatch = new Stopwatch();
        }

        public void Dispose()
        {
            GL.Uninitialize();
            m_display.Dispose();
        }

        public void Run()
        {

            var oldContext = SynchronizationContext.Current;
            SynchronizationContext.SetSynchronizationContext(m_synchronizationContext);

            try
            {
                m_logic.Start();

                var message = new WinApi.Message();

                m_display.Show();

                m_stopwatch.Start();

                while (WinApi.GetMessage(ref message, IntPtr.Zero, 0, 0))
                {
                    if (message.id == WinApi.WM_USER)
                    {
                        m_synchronizationContext.ExecuteAction();
                    }
                    else
                    {
                        WinApi.TranslateMessage(ref message);
                        WinApi.DispatchMessage(ref message);
                    }
                }

                m_display.Hide();

                m_logic.Stop();
            }
            finally
            {
                SynchronizationContext.SetSynchronizationContext(oldContext);
            }
        }

        public void Stop()
        {
            WinApi.PostQuitMessage(0);
        }

        public void ExecuteAction(Action action)
        {
            if (action != null)
            {
                m_actions.Enqueue(action);
                // TODO Send message
            }
        }

        public IDisplay Display { get { return m_display; } }


        #region Display
        private Vector2 GetMousePosition(IntPtr window, IntPtr lParam)
        {
            WinApi.Rect r = new WinApi.Rect();
            WinApi.GetClientRect(window, ref r);
            return new Vector2(
                ((short)(lParam.ToInt32() & 0xFFFF) / (float)r.right) * 2f - 1f,
                (((short)((lParam.ToInt32() >> 16) & 0xFFFF) / (float)r.bottom) * 2f - 1f) * -1f
            );
        }

        private IntPtr WindowProc(IntPtr handle, uint messageId, IntPtr wParam, IntPtr lParam)
        {
            try
            {
                switch (messageId)
                {
                    case WinApi.WM_CLOSE:
                        m_logic.CloseRequest();
                        return IntPtr.Zero;

                    case WinApi.WM_PAINT:
                        Render();
                        return IntPtr.Zero;

                    case WinApi.WM_KEYDOWN:
                        {
                            var key = (Key)wParam.ToInt32();
                            if (m_keys[(int)key] == false)
                            {
                                m_keys[(int)key] = true;
                                m_logic.InputEvent(new KeyboardKeyDownEventArgs(key));
                            }
                        }
                        return IntPtr.Zero;

                    case WinApi.WM_KEYUP:
                        {
                            var key = (Key)wParam.ToInt32();
                            m_keys[(int)key] = false;
                            m_logic.InputEvent(new KeyboardKeyUpEventArgs(key));
                        }
                        return IntPtr.Zero;

                    case WinApi.WM_KILLFOCUS:
                        {
                            for (int i = 0; i < m_keys.Length; i++)
                            {
                                if (m_keys[i])
                                {
                                    m_keys[i] = false;
                                    m_logic.InputEvent(new KeyboardKeyUpEventArgs((Key)i));
                                }
                            }
                        }
                        return IntPtr.Zero;

                    case WinApi.WM_LBUTTONDOWN:
                        OnMousedDown(MouseButton.Left, GetMousePosition(handle, lParam));
                        return IntPtr.Zero;

                    case WinApi.WM_LBUTTONUP:
                        OnMouseUp(MouseButton.Left, GetMousePosition(handle, lParam));
                        return IntPtr.Zero;

                    case WinApi.WM_RBUTTONDOWN:
                        OnMousedDown(MouseButton.Right, GetMousePosition(handle, lParam));
                        return IntPtr.Zero;

                    case WinApi.WM_RBUTTONUP:
                        OnMouseUp(MouseButton.Right, GetMousePosition(handle, lParam));
                        return IntPtr.Zero;

                    case WinApi.WM_MBUTTONDOWN:
                        OnMousedDown(MouseButton.Middle, GetMousePosition(handle, lParam));
                        return IntPtr.Zero;

                    case WinApi.WM_MBUTTONUP:
                        OnMouseUp(MouseButton.Middle, GetMousePosition(handle, lParam));
                        return IntPtr.Zero;

                    case WinApi.WM_XBUTTONDOWN:
                        {
                            var button = ((wParam.ToInt32() >> 16) & 0xFFFF) == 1 ? MouseButton.Aux1 : MouseButton.Aux2;
                            OnMousedDown(button, GetMousePosition(handle, lParam));
                        }
                        return IntPtr.Zero;

                    case WinApi.WM_XBUTTONUP:
                        {
                            var button = ((wParam.ToInt32() >> 16) & 0xFFFF) == 1 ? MouseButton.Aux1 : MouseButton.Aux2;
                            OnMouseUp(button, GetMousePosition(handle, lParam));
                        }
                        return IntPtr.Zero;

                    case WinApi.WM_MOUSEMOVE:
                        if (!m_isMouseInWindow)
                        {
                            m_isMouseInWindow = true;

                            var cursor = WinApi.GetClassLong(handle, WinApi.GCL_HCURSOR);

                            if (cursor == 0)
                            {
                                WinApi.SetCursor(IntPtr.Zero);
                            }

                            WinApi.TrackMouseEventParameters p = new WinApi.TrackMouseEventParameters();
                            p.cbSize = (uint)Marshal.SizeOf(typeof(WinApi.TrackMouseEventParameters));
                            p.dwFlags = WinApi.TME_LEAVE;
                            p.hwndTrack = handle;
                            WinApi.TrackMouseEvent(ref p);
                            m_logic.InputEvent(new MouseEnterEventArgs());
                        }
                        m_logic.InputEvent(new MouseMoveEventArgs(GetMousePosition(handle, lParam)));
                        return IntPtr.Zero;

                    case WinApi.WM_MOUSELEAVE:
                        m_isMouseInWindow = false;
                        m_logic.InputEvent(new MouseLeaveEventArgs());
                        return IntPtr.Zero;

                    case WinApi.WM_MOUSEWHEEL:
                        {
                            var ticks = (short)((wParam.ToInt32() >> 16) & 0xFFFF);
                            m_logic.InputEvent(new MouseWheelEventArgs(ticks / 120f, GetMousePosition(handle, lParam)));
                        }
                        return IntPtr.Zero;

                    case WinApi.WM_CHAR:
                        {
                            var c = (char)(wParam.ToInt32() & 0xFFFF);
                            m_logic.InputEvent(new CharacterEventArgs(c));
                        }
                        return IntPtr.Zero;

                    default:
                        return WinApi.DefWindowProc(handle, messageId, wParam, lParam);

                }
            }
            catch (Exception ex)
            {
                Engine.LogError("Unhandled exception", ex);
                m_logic.UnhandledException(ex);
                return WinApi.DefWindowProc(handle, messageId, wParam, lParam);
            }
        }

        private void OnMousedDown(MouseButton button, Vector2 position)
        {
            WinApi.SetCapture(m_display.Handle);
            m_pressedButtons.Add(button);
            m_logic.InputEvent(new MouseButtonDownEventArgs(button, position));
        }

        private void OnMouseUp(MouseButton button, Vector2 position)
        {
            WinApi.ReleaseCapture();
            m_pressedButtons.Remove(button);
            m_logic.InputEvent(new MouseButtonUpEventArgs(button, position));
        }

        private void Render()
        {
            var now = m_stopwatch.Elapsed;
            TimeSpan elapsed;

            if (m_previousFrame == TimeSpan.MinValue)
            {
                elapsed = TimeSpan.Zero;
            }
            else
            {
                elapsed = now - m_previousFrame;
            }

            m_previousFrame = now;

            if (elapsed != TimeSpan.Zero)
            {
                m_framesPerSecond = m_framesPerSecond * 0.95 + (1 / elapsed.TotalSeconds) * 0.05;
            }

            WinApi.ValidateRect(m_display.Handle, IntPtr.Zero);

            m_logic.Render(elapsed);

            var result = WinApi.SwapBuffers(m_display.DeviceContext);

            if (!result)
            {
                var error = WinApi.GetLastError();
                Console.WriteLine("Error : " + error);
            }
        }

        public double FramesPerSecond { get { return m_framesPerSecond; } }
        #endregion

        #region Keyboard
        public bool IsKeyPressed(Key key)
        {
            return m_keys[(int)key];
        }
        #endregion

        #region Mouse
        public bool IsButtonPressed(MouseButton button)
        {
            return m_pressedButtons.Contains(button);
        }
        #endregion

    }
}