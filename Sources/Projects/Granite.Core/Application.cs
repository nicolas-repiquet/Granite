using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Granite.Core
{
    internal sealed class Application : IKeyboard, IDisposable
    {
        private readonly Thread m_thread;
        private readonly IApplicationLogic m_logic;
        private readonly Queue<Action> m_actions;
        private readonly Display m_display;
        private readonly ApplicationSynchronizationContext m_synchronizationContext;
        private readonly Stopwatch m_stopwatch;
        private TimeSpan m_previousFrame = TimeSpan.MinValue;
        private double m_framesPerSecond = 0f;
        private bool[] m_keys;

        public Application(IApplicationLogic logic, ApplicationSettings settings)
        {
            m_keys = new bool[0xFF];
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
        private Vector2i GetMousePosition(IntPtr lParam)
        {
            return new Vector2i(
                (short)(lParam.ToInt32() & 0xFFFF),
                (short)((lParam.ToInt32() >> 16) & 0xFFFF)
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
                                m_logic.KeyDown(key);
                                m_logic.InputEvent(new KeyboardKeyDownEventArgs(key));
                            }
                        }
                        return IntPtr.Zero;

                    case WinApi.WM_KEYUP:
                        {
                            var key = (Key)wParam.ToInt32();
                            m_keys[(int)key] = false ;
                            m_logic.KeyUp(key);
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
                        {
                            int x = lParam.ToInt32() & 0xFFFF;
                            int y = (lParam.ToInt32() >> 16) & 0xFFFF;
                            m_logic.MouseLButtonDown(x, y);
                            m_logic.InputEvent(new MouseButtonDownEventArgs(MouseButton.Left, GetMousePosition(lParam)));
                        }
                        return IntPtr.Zero;

                    case WinApi.WM_LBUTTONUP:
                        m_logic.InputEvent(new MouseButtonUpEventArgs(MouseButton.Left, GetMousePosition(lParam)));
                        return IntPtr.Zero;

                    case WinApi.WM_RBUTTONDOWN:
                        m_logic.InputEvent(new MouseButtonDownEventArgs(MouseButton.Right, GetMousePosition(lParam)));
                        return IntPtr.Zero;

                    case WinApi.WM_RBUTTONUP:
                        m_logic.InputEvent(new MouseButtonUpEventArgs(MouseButton.Right, GetMousePosition(lParam)));
                        return IntPtr.Zero;

                    case WinApi.WM_MBUTTONDOWN:
                        m_logic.InputEvent(new MouseButtonDownEventArgs(MouseButton.Middle, GetMousePosition(lParam)));
                        return IntPtr.Zero;

                    case WinApi.WM_MBUTTONUP:
                        m_logic.InputEvent(new MouseButtonUpEventArgs(MouseButton.Middle, GetMousePosition(lParam)));
                        return IntPtr.Zero;

                    case WinApi.WM_XBUTTONDOWN:
                        {
                            var button = (wParam.ToInt32() >> 16) & 0xFFFF;
                            m_logic.InputEvent(new MouseButtonDownEventArgs(
                                button == 1 ? MouseButton.Aux1 : MouseButton.Aux2, 
                                GetMousePosition(lParam)
                            ));
                        }
                        return IntPtr.Zero;

                    case WinApi.WM_XBUTTONUP:
                        {
                            var button = (wParam.ToInt32() >> 16) & 0xFFFF;
                            m_logic.InputEvent(new MouseButtonUpEventArgs(
                                button == 1 ? MouseButton.Aux1 : MouseButton.Aux2,
                                GetMousePosition(lParam)
                            ));
                        }
                        return IntPtr.Zero;

                    case WinApi.WM_MOUSEMOVE:
                        m_logic.InputEvent(new MouseMoveEventArgs(GetMousePosition(lParam)));
                        return IntPtr.Zero;

                    case WinApi.WM_MOUSEWHEEL:
                        {
                            var ticks = (short)((wParam.ToInt32() >> 16) & 0xFFFF);
                            m_logic.InputEvent(new MouseWheelEventArgs(ticks / 120f, GetMousePosition(lParam)));
                        }
                        return IntPtr.Zero;

                    default:
                        return WinApi.DefWindowProc(handle, messageId, wParam, lParam);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                return WinApi.DefWindowProc(handle, messageId, wParam, lParam);
            }
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

    }
}
