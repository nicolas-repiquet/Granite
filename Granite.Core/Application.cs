using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Granite.Core
{
    internal sealed class Application : IDisposable
    {
        private readonly Thread m_thread;
        private readonly IApplicationLogic m_logic;
        private readonly Queue<Action> m_actions;
        private readonly Display m_display;
        private DateTime m_previousFrame = DateTime.MinValue;
        private double m_framesPerSecond = 0f;

        public Application(IApplicationLogic logic, ApplicationSettings settings)
        {
            m_thread = Thread.CurrentThread;
            m_actions = new Queue<Action>();
            m_logic = logic;
            m_display = new Display(this, WindowProc, settings.DisplayStyle);
            GL.Initialize(
                m_display,
                settings.DisplayColorBits,
                settings.DisplayDepthBits
            );
        }

        public void Dispose()
        {
            GL.Uninitialize();
            m_display.Dispose();
        }

        public void Run()
        {
            Console.WriteLine("Version : {0}", Marshal.PtrToStringAnsi(GL.GetString(GL.VERSION)));
            Console.WriteLine("GLSL {0}", Marshal.PtrToStringAnsi(GL.GetString(GL.SHADING_LANGUAGE_VERSION)));
            Console.WriteLine("Vendor : {0}", Marshal.PtrToStringAnsi(GL.GetString(GL.VENDOR)));
            Console.WriteLine("Renderer : {0}", Marshal.PtrToStringAnsi(GL.GetString(GL.RENDERER)));

            Console.WriteLine("=================================");

            m_logic.Start();

            var message = new WinApi.Message();

            m_display.Show();

            while (WinApi.GetMessage(ref message, IntPtr.Zero, 0, 0))
            {
                WinApi.TranslateMessage(ref message);
                WinApi.DispatchMessage(ref message);
            }

            m_display.Hide();

            m_logic.Stop();
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
                        m_logic.KeyDown((Key)wParam.ToInt32());
                        return IntPtr.Zero;

                    case WinApi.WM_KEYUP:
                        m_logic.KeyUp((Key)wParam.ToInt32());
                        return IntPtr.Zero;

                    case WinApi.WM_LBUTTONDOWN:
                        m_logic.MouseLButtonDown(lParam.ToInt32() & 0xFFFF, (lParam.ToInt32() >> 16) & 0xFFFF);
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
            var now = DateTime.Now;
            TimeSpan elapsed;

            if (m_previousFrame == DateTime.MinValue)
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
            
            WinApi.SwapBuffers(m_display.DeviceContext);
        }

        public double FramesPerSecond { get { return m_framesPerSecond; } }
        #endregion

    }
}
