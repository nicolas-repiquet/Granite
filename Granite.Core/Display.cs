using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Granite.Core
{
    internal class Display : ApplicationResource, IDisplay
    {
        private readonly IntPtr m_instance;
        private readonly WinApi.WndProc m_windowProc;
        private readonly string m_className;
        private readonly IntPtr m_handle;
        private readonly IntPtr m_deviceContext;

        public Display(WinApi.WndProc proc, DisplayStyle style)
        {
            m_instance = WinApi.GetModuleHandle(null);

            m_windowProc = new WinApi.WndProc(proc);
            m_className = "GRANITE_" + Guid.NewGuid().ToString("N");

            WinApi.WindowClass wc = new WinApi.WindowClass()
            {
                style = WinApi.CS_OWNDC | WinApi.CS_VREDRAW | WinApi.CS_HREDRAW,
                windowProcedure = Marshal.GetFunctionPointerForDelegate(m_windowProc),
                instance = m_instance,
                cursor = WinApi.LoadCursor(IntPtr.Zero, WinApi.IDC_ARROW),
                className = m_className
            };

            WinApi.RegisterClass(ref wc);

		    uint s = WinApi.WS_POPUP;

            switch (style)
            {
                case DisplayStyle.Fixed:
                    s = WinApi.WS_BORDER;
                    break;
                case DisplayStyle.FixedWithTitle:
                    s = WinApi.WS_CAPTION | WinApi.WS_SYSMENU;
                    break;
                case DisplayStyle.Resizeable:
                    s = WinApi.WS_POPUP | WinApi.WS_THICKFRAME;
                    break;
                case DisplayStyle.ResizeableWithTitle:
                    s |= WinApi.WS_CAPTION | WinApi.WS_SYSMENU | WinApi.WS_THICKFRAME | WinApi.WS_MINIMIZEBOX | WinApi.WS_MAXIMIZEBOX;
                    break;
            }

            m_handle = WinApi.CreateWindowEx(
                0,
                m_className,
                "",
                s,
                0, 0, 800, 600,
                IntPtr.Zero, IntPtr.Zero,
                m_instance, IntPtr.Zero
            );

            m_deviceContext = WinApi.GetDC(m_handle);
        }

        protected override void InternalDispose()
        {
            WinApi.ReleaseDC(m_handle, m_deviceContext);
            WinApi.DestroyWindow(m_handle);
            WinApi.UnregisterClass(m_className, m_instance);
        }

        public IntPtr Handle { get { return m_handle; } }
        public IntPtr DeviceContext { get { return m_deviceContext; } }

        public void Show()
        {
            WinApi.ShowWindow(m_handle, WinApi.SW_SHOW);
        }

        public void Hide()
        {
            WinApi.ShowWindow(m_handle, WinApi.SW_HIDE);
        }

        public void Invalidate()
        {
            WinApi.InvalidateRect(m_handle, IntPtr.Zero, false);
        }

        public Vector2i GetSize()
        {
            var r = new WinApi.Rect();
            WinApi.GetClientRect(m_handle, ref r);
            return new Vector2i(r.right, r.bottom);
        }
    }
    //public sealed class Display
    //{


    //    //    private IntPtr OnMessage(IntPtr windowHandle, uint messageId, IntPtr wParam, IntPtr lParam)
    //    //    {
    //    //        switch (messageId)
    //    //        {
    //    //            case WinApi.WM_MOUSEMOVE:
    //    //                {
    //    //                    int v = lParam.ToInt32();
    //    //                    if (m_logic != null)
    //    //                    {
    //    //                        m_logic.OnMouseMove(m_display, v & 0xFFFF, (v >> 16) & 0xFFFF);
    //    //                    }
    //    //                }
    //    //                return IntPtr.Zero;

    //    //            case WinApi.WM_CLOSE:
    //    //                {
    //    //                    if (m_logic != null)
    //    //                    {
    //    //                        m_logic.OnCloseCommand(m_display);
    //    //                    }
    //    //                }
    //    //                return IntPtr.Zero;

    //    //            case WinApi.WM_PAINT:
    //    //                {

    //    //                }
    //    //                return IntPtr.Zero;

    //    //            case WinApi.WM_SIZE:
    //    //                {

    //    //                }
    //    //                return IntPtr.Zero;

    //    //            case WinApi.WM_KEYDOWN:
    //    //                {
    //    //                    var key = (Keys)wParam.ToInt32();
    //    //                    if (m_logic != null)
    //    //                    {
    //    //                        m_logic.OnKeyDown(key);
    //    //                    }
    //    //                }
    //    //                return IntPtr.Zero;

    //    //            case WinApi.WM_KEYUP:
    //    //                {
    //    //                    var key = (Keys)wParam.ToInt32();
    //    //                    if (m_logic != null)
    //    //                    {
    //    //                        m_logic.OnKeyUp(key);
    //    //                    }
    //    //                }
    //    //                return IntPtr.Zero;

    //    //            case WinApi.WM_SETFOCUS:
    //    //                {
    //    //                    if (m_logic != null)
    //    //                    {
    //    //                        m_logic.OnGainFocus();
    //    //                    }
    //    //                }
    //    //                return IntPtr.Zero;

    //    //            case WinApi.WM_KILLFOCUS:
    //    //                {
    //    //                    if (m_logic != null)
    //    //                    {
    //    //                        m_logic.OnLostFocus();
    //    //                    }
    //    //                }
    //    //                return IntPtr.Zero;

    //    //            case WinApi.WM_CHAR:
    //    //                {
    //    //                    if (m_logic != null)
    //    //                    {
    //    //                        m_logic.OnChar((char)wParam.ToInt32());
    //    //                    }
    //    //                }
    //    //                return IntPtr.Zero;

    //    //            default:
    //    //                return WinApi.DefWindowProc(windowHandle, messageId, wParam, lParam);
    //    //        }
    //    //    }

    //    //}

    //    private readonly IDisplayLogic m_logic;

    //    internal Display(IDisplayLogic logic)
    //    {
    //        m_logic = logic;
    //        GL.PrepareWindow(this);
    //    }

    //    private IntPtr OnMessage(IntPtr windowHandle, uint messageId, IntPtr wParam, IntPtr lParam)
    //    {
    //        switch (messageId)
    //        {
    //            case WinApi.WM_MOUSEMOVE:
    //                {
    //                    int v = lParam.ToInt32();
    //                    if (m_logic != null)
    //                    {
    //                        m_logic.OnMouseMove(this, v & 0xFFFF, (v >> 16) & 0xFFFF);
    //                    }
    //                }
    //                return IntPtr.Zero;

    //            case WinApi.WM_CLOSE:
    //                {
    //                    if (m_logic != null)
    //                    {
    //                        m_logic.OnCloseCommand(this);
    //                    }
    //                }
    //                return IntPtr.Zero;

    //            case WinApi.WM_PAINT:
    //                {
    //                    Render();
    //                }
    //                return IntPtr.Zero;

    //            case WinApi.WM_SIZE:
    //                {
    //                    int v = lParam.ToInt32();

    //                    //m_width = v & 0xFFFF;
    //                    //m_height = (v >> 16) & 0xFFFF;

    //                    //GL.Viewport(0, 0, m_width, m_height);
    //                }
    //                return IntPtr.Zero;

    //            case WinApi.WM_KEYDOWN:
    //                {
    //                    var key = (Keys)wParam.ToInt32();
    //                    if (m_logic != null)
    //                    {
    //                        m_logic.OnKeyDown(key);
    //                    }
    //                }
    //                return IntPtr.Zero;

    //            case WinApi.WM_KEYUP:
    //                {
    //                    var key = (Keys)wParam.ToInt32();
    //                    if (m_logic != null)
    //                    {
    //                        m_logic.OnKeyUp(key);
    //                    }
    //                }
    //                return IntPtr.Zero;

    //            case WinApi.WM_SETFOCUS:
    //                {
    //                    if (m_logic != null)
    //                    {
    //                        m_logic.OnGainFocus();
    //                    }
    //                }
    //                return IntPtr.Zero;

    //            case WinApi.WM_KILLFOCUS:
    //                {
    //                    if (m_logic != null)
    //                    {
    //                        m_logic.OnLostFocus();
    //                    }
    //                }
    //                return IntPtr.Zero;

    //            case WinApi.WM_CHAR:
    //                {
    //                    if (m_logic != null)
    //                    {
    //                        m_logic.OnChar((char)wParam.ToInt32());
    //                    }
    //                }
    //                return IntPtr.Zero;

    //            default:
    //                return WinApi.DefWindowProc(windowHandle, messageId, wParam, lParam);
    //        }
    //    }

    //    private void Render()
    //    {
    //        //var now = DateTime.Now;
    //        //var elapsed = now - m_lastRender;

    //        //if (elapsed.TotalMilliseconds >= 10)
    //        //{
    //        //    m_lastRender = now;

    //        //    WinApi.ValidateRect(m_windowHandle, IntPtr.Zero);
    //        //    IntPtr currentOpenglContext = WinApi.wglGetCurrentContext();
    //        //    IntPtr currentDeviceContext = WinApi.wglGetCurrentDC();

    //        //    WinApi.wglMakeCurrent(m_deviceContextHandle, Engine.OpenglContext);

    //        //    try
    //        //    {
    //        //        // Draw
    //        //        GL.ClearColor(0.5f, 0.5f, 0.55f, 1.0f);
    //        //        //GL.glClearDepth(0.0);
    //        //        GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);

    //        //        GL.Enable_DEPTH_TEST();
    //        //        //GL.glDepthFunc(GL.GREATER);
    //        //        GL.Enable_BLEND();
    //        //        GL.BlendFunc(GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA);

    //        //        m_logic.Render(this, new Graphics(), elapsed);

    //        //        WinApi.SwapBuffers(m_deviceContextHandle);
    //        //    }
    //        //    finally
    //        //    {
    //        //        WinApi.wglMakeCurrent(currentDeviceContext, currentOpenglContext);
    //        //    }
    //        //}
    //        //else
    //        //{
    //        //    Thread.Sleep((int)(10 - elapsed.TotalMilliseconds));
    //        //}
    //    }

    //    public Vector2i GetSize()
    //    {
    //        return m_window.GetSize();
    //    }

    //    public void Show()
    //    {
    //        m_window.Show();
    //    }

    //    public void Hide()
    //    {
    //        m_window.Hide();
    //    }

    //    public void Invalidate()
    //    {
    //        m_window.Invalidate();
    //    }

    //}
}
