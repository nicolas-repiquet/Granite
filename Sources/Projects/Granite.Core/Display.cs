using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Granite.Core
{
    internal class Display : ApplicationResource, IDisplay
    {
        private readonly Application m_application;
        private readonly IntPtr m_instance;
        private readonly WinApi.WndProc m_windowProc;
        private readonly string m_className;
        private readonly IntPtr m_handle;
        private readonly IntPtr m_deviceContext;

        public Display(Application application, WinApi.WndProc proc, DisplayStyle style)
        {
            m_application = application;
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

        public void SetTitle(string title)
        {
            WinApi.SetWindowText(m_handle, title);
        }

        public void SetCursor(Cursor cursor)
        {
            if (cursor == Cursor.None)
            {
                WinApi.SetCursor(IntPtr.Zero);
                WinApi.SetClassLong(m_handle, WinApi.GCL_HCURSOR, 0);
            }
            else
            {
                var c = WinApi.LoadCursor(IntPtr.Zero, (uint)cursor);
                WinApi.SetCursor(c);
                WinApi.SetClassLong(m_handle, WinApi.GCL_HCURSOR, (uint)c);
            }
        }

        public double FramesPerSecond { get { return m_application.FramesPerSecond; } }
    }
}
