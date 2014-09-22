using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite.Core
{
    internal class Window : EngineResource
    {
        private readonly IntPtr m_instance;
        private readonly WinApi.WndProc m_windowProc;
        private readonly string m_className;
        private readonly IntPtr m_handle;
        private readonly IntPtr m_deviceContext;

        public Window()
        {
            m_instance = WinApi.GetModuleHandle(null);

            m_windowProc = new WinApi.WndProc(WindowProc);
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

            m_handle = WinApi.CreateWindowEx(
                0,
                m_className,
                "",
                WinApi.WS_OVERLAPPEDWINDOW,
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

        protected virtual IntPtr WindowProc(IntPtr handle, uint messageId, IntPtr wParam, IntPtr lParam)
        {
            return WinApi.DefWindowProc(handle, messageId, wParam, lParam);
        }

        public void SetPixelFormat(int colorBits = 24, int depthBits = 16)
        {
            WinApi.PixelFormatDescriptor pixelFormat = new WinApi.PixelFormatDescriptor()
            {
                size = (ushort)Marshal.SizeOf(typeof(WinApi.PixelFormatDescriptor)),
                version = 1,
                flags = WinApi.PFD_DRAW_TO_WINDOW | WinApi.PFD_SUPPORT_OPENGL | WinApi.PFD_DOUBLEBUFFER,
                pixelType = WinApi.PFD_TYPE_RGBA,
                colorBits = (byte)colorBits,
                depthBits = (byte)depthBits
            };

            int pixelFormatIndex = WinApi.ChoosePixelFormat(m_deviceContext, ref pixelFormat);

            var result = WinApi.SetPixelFormat(m_deviceContext, pixelFormatIndex, ref pixelFormat);
        }
    }
}
