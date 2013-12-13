using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Granite3D
{
    public sealed class Display : EngineResource
    {
        private readonly IDisplayLogic m_logic;

        private readonly string m_className;
        private readonly ushort m_classAtom;
        private readonly WinApi.WndProc m_wndProc;
        private readonly IntPtr m_windowHandle;
        private readonly IntPtr m_deviceContextHandle;

        private int m_width;
        private int m_height;
        private DateTime m_lastRender;

        internal Display(Engine engine, IDisplayLogic logic)
            : base(engine)
        {
            m_logic = logic;
            m_lastRender = DateTime.Now;

            m_wndProc = new WinApi.WndProc(OnMessage);
            IntPtr wndProc = Marshal.GetFunctionPointerForDelegate(m_wndProc);
            m_className = string.Format("class_{0:N}", Guid.NewGuid());

            WinApi.WindowClass windowClass = new WinApi.WindowClass()
            {
                style = WinApi.CS_OWNDC | WinApi.CS_HREDRAW | WinApi.CS_VREDRAW,
                instance = WinApi.GetModuleHandle(null),
                className = m_className,
                windowProcedure = wndProc,
                cursor = WinApi.LoadCursor(IntPtr.Zero, WinApi.IDC_ARROW)
            };

            m_classAtom = WinApi.RegisterClass(ref windowClass);

            m_windowHandle = WinApi.CreateWindowEx(
                0,
                m_className,
                null,
                WinApi.WS_OVERLAPPEDWINDOW,
                100,
                100,
                640,
                480,
                IntPtr.Zero,
                IntPtr.Zero,
                WinApi.GetModuleHandle(null),
                IntPtr.Zero
            );

            m_deviceContextHandle = WinApi.GetDC(m_windowHandle);

            WinApi.PixelFormatDescriptor pixelFormat = new WinApi.PixelFormatDescriptor()
            {
                size = (ushort)Marshal.SizeOf(typeof(WinApi.PixelFormatDescriptor)),
                version = 1,
                flags = WinApi.PFD_DRAW_TO_WINDOW | WinApi.PFD_SUPPORT_OPENGL | WinApi.PFD_DOUBLEBUFFER,
                pixelType = WinApi.PFD_TYPE_RGBA,
                colorBits = 24,
                depthBits = 16
            };

            int pixelFormatIndex = WinApi.ChoosePixelFormat(m_deviceContextHandle, ref pixelFormat);

            var result = WinApi.SetPixelFormat(m_deviceContextHandle, pixelFormatIndex, ref pixelFormat);

            result.ToString();
        }

        public int Width { get { return m_width; } }
        public int Height { get { return m_height; } }

        private IntPtr OnMessage(IntPtr windowHandle, uint messageId, IntPtr wParam, IntPtr lParam)
        {
            switch (messageId)
            {
                case WinApi.WM_MOUSEMOVE:
                    {
                        int v = lParam.ToInt32();
                        if (m_logic != null)
                        {
                            m_logic.OnMouseMove(this, v & 0xFFFF, (v >> 16) & 0xFFFF);
                        }
                    }
                    return IntPtr.Zero;

                case WinApi.WM_CLOSE:
                    {
                        if (m_logic != null)
                        {
                            m_logic.OnCloseCommand(this);
                        }
                    }
                    return IntPtr.Zero;

                case WinApi.WM_PAINT:
                    {
                        Render();
                    }
                    return IntPtr.Zero;

                case WinApi.WM_SIZE:
                    {
                        int v = lParam.ToInt32();

                        m_width = v & 0xFFFF;
                        m_height = (v >> 16) & 0xFFFF;

                        Engine.Gl.Viewport(0, 0, m_width, m_height);
                    }
                    return IntPtr.Zero;

                case WinApi.WM_KEYDOWN:
                    {
                        var key = (Keys)wParam.ToInt32();
                        if (m_logic != null)
                        {
                            m_logic.OnKeyDown(key);
                        }
                    }
                    return IntPtr.Zero;

                case WinApi.WM_KEYUP:
                    {
                        var key = (Keys)wParam.ToInt32();
                        if (m_logic != null)
                        {
                            m_logic.OnKeyUp(key);
                        }
                    }
                    return IntPtr.Zero;

                case WinApi.WM_SETFOCUS:
                    {
                        if (m_logic != null)
                        {
                            m_logic.OnGainFocus();
                        }
                    }
                    return IntPtr.Zero;

                case WinApi.WM_KILLFOCUS:
                    {
                        if (m_logic != null)
                        {
                            m_logic.OnLostFocus();
                        }
                    }
                    return IntPtr.Zero;

                case WinApi.WM_CHAR:
                    {
                        if (m_logic != null)
                        {
                            m_logic.OnChar((char)wParam.ToInt32());
                        }
                    }
                    return IntPtr.Zero;

                default:
                    return WinApi.DefWindowProc(windowHandle, messageId, wParam, lParam);
            }
        }


        private void Render()
        {
            var now = DateTime.Now;
            var elapsed = now - m_lastRender;

            if (elapsed.TotalMilliseconds >= 10)
            {
                m_lastRender = now;

                WinApi.ValidateRect(m_windowHandle, IntPtr.Zero);
                IntPtr currentOpenglContext = WinApi.wglGetCurrentContext();
                IntPtr currentDeviceContext = WinApi.wglGetCurrentDC();

                WinApi.wglMakeCurrent(m_deviceContextHandle, Engine.OpenglContext);

                try
                {
                    // Draw
                    Engine.Gl.ClearColor(0.5f, 0.5f, 0.55f, 1.0f);
                    //Engine.Gl.glClearDepth(0.0);
                    Engine.Gl.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);

                    Engine.Gl.Enable_DEPTH_TEST();
                    //Engine.Gl.glDepthFunc(GL.GREATER);
                    Engine.Gl.Enable_BLEND();
                    Engine.Gl.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

                    m_logic.Render(this, new Graphics(Engine), elapsed);

                    WinApi.SwapBuffers(m_deviceContextHandle);
                }
                finally
                {
                    WinApi.wglMakeCurrent(currentDeviceContext, currentOpenglContext);
                }
            }
            else
            {
                Thread.Sleep((int)(10 - elapsed.TotalMilliseconds));
            }
        }

        internal IntPtr DeviceContextHandle { get { return m_deviceContextHandle; } }

        public void Show()
        { 
            WinApi.ShowWindow(m_windowHandle, WinApi.SW_SHOW);
        }

        public void Hide()
        {
            WinApi.ShowWindow(m_windowHandle, WinApi.SW_HIDE);
        }

        public void Invalidate()
        {
            WinApi.InvalidateRect(m_windowHandle, IntPtr.Zero, false);
        }

        protected override void InternalDispose()
        {
            IntPtr deviceContextHandle = m_deviceContextHandle;
            IntPtr windowHandle = m_windowHandle;
            string className = m_className;
                
            Engine.ExecuteAction(() =>
            {
                WinApi.ReleaseDC(windowHandle, deviceContextHandle);
                WinApi.DestroyWindow(windowHandle);
                WinApi.UnregisterClass(className, WinApi.GetModuleHandle(null));
            });
        }
    }
}
