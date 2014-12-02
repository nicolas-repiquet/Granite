using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Granite.Core
{
    internal static class WinApi
    {
        private const string USER32 = "user32.dll";
        private const string KERNEL32 = "kernel32.dll";
        private const string GDI32 = "gdi32.dll";
        private const string OPENGL32 = "opengl32.dll";

        internal const uint INFINITE = 0xFFFFFFFF;

        internal const uint WM_QUIT = 0x0012;
        internal const uint WM_CLOSE = 0x0010;
        internal const uint WM_PAINT = 0x000F;
        internal const uint WM_SIZE = 0x0005;
        internal const uint WM_KEYDOWN = 0x0100;
        internal const uint WM_KEYUP = 0x0101;
        internal const uint WM_SETFOCUS = 0x0007;
        internal const uint WM_KILLFOCUS = 0x0008;
        internal const uint WM_CHAR = 0x0102;
        internal const uint WM_USER = 0x0400;
        internal const uint WM_MOUSEMOVE = 0x0200;
        internal const uint WM_LBUTTONDOWN = 0x0201;
        internal const uint WM_LBUTTONUP = 0x0202;
        internal const uint WM_RBUTTONDOWN = 0x0204;
        internal const uint WM_RBUTTONUP = 0x0205;
        internal const uint WM_MBUTTONDOWN = 0x0207;
        internal const uint WM_MBUTTONUP = 0x0208;
        internal const uint WM_MOUSEWHEEL = 0x020A;
        internal const uint WM_XBUTTONDOWN = 0x020B;
        internal const uint WM_XBUTTONUP = 0x020C;
        internal const uint WM_MOUSELEAVE = 0x02A3;


        internal const byte PFD_TYPE_RGBA = 0;
        internal const byte PFD_TYPE_COLORINDEX = 1;

        internal const uint PFD_DOUBLEBUFFER = 0x00000001;
        internal const uint PFD_STEREO = 0x00000002;
        internal const uint PFD_DRAW_TO_WINDOW = 0x00000004;
        internal const uint PFD_DRAW_TO_BITMAP = 0x00000008;
        internal const uint PFD_SUPPORT_GDI = 0x00000010;
        internal const uint PFD_SUPPORT_OPENGL = 0x00000020;
        internal const uint PFD_GENERIC_FORMAT = 0x00000040;
        internal const uint PFD_NEED_PALETTE = 0x00000080;
        internal const uint PFD_NEED_SYSTEM_PALETTE = 0x00000100;
        internal const uint PFD_SWAP_EXCHANGE = 0x00000200;
        internal const uint PFD_SWAP_COPY = 0x00000400;
        internal const uint PFD_SWAP_LAYER_BUFFERS = 0x00000800;
        internal const uint PFD_GENERIC_ACCELERATED = 0x00001000;
        internal const uint PFD_SUPPORT_DIRECTDRAW = 0x00002000;
        internal const uint PFD_DEPTH_DONTCARE = 0x20000000;
        internal const uint PFD_DOUBLEBUFFER_DONTCARE = 0x40000000;
        internal const uint PFD_STEREO_DONTCARE = 0x80000000;

        // WindowClass
        internal const uint CS_OWNDC = 0x0020;
        internal const uint CS_HREDRAW = 0x0002;
        internal const uint CS_VREDRAW = 0x0001;

        // CreateWindowEx
        internal const uint WS_BORDER = 0x00800000U;
        internal const uint WS_CAPTION = 0x00C00000U;
        internal const uint WS_CHILD = 0x40000000U;
        internal const uint WS_CHILDWINDOW = 0x40000000U;
        internal const uint WS_CLIPCHILDREN = 0x02000000U;
        internal const uint WS_CLIPSIBLINGS = 0x04000000U;
        internal const uint WS_DISABLED = 0x08000000U;
        internal const uint WS_DLGFRAME = 0x00400000U;
        internal const uint WS_GROUP = 0x00020000U;
        internal const uint WS_HSCROLL = 0x00100000U;
        internal const uint WS_ICONIC = 0x20000000U;
        internal const uint WS_MAXIMIZE = 0x01000000U;
        internal const uint WS_MAXIMIZEBOX = 0x00010000U;
        internal const uint WS_MINIMIZE = 0x20000000U;
        internal const uint WS_MINIMIZEBOX = 0x00020000U;
        internal const uint WS_OVERLAPPED = 0x00000000U;
        internal const uint WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX);
        internal const uint WS_POPUP = 0x80000000U;
        internal const uint WS_POPUPWINDOW = (WS_POPUP | WS_BORDER | WS_SYSMENU);
        internal const uint WS_SIZEBOX = 0x00040000U;
        internal const uint WS_SYSMENU = 0x00080000U;
        internal const uint WS_TABSTOP = 0x00010000U;
        internal const uint WS_THICKFRAME = 0x00040000U;
        internal const uint WS_TILED = 0x00000000U;
        internal const uint WS_TILEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX);
        internal const uint WS_VISIBLE = 0x10000000U;
        internal const uint WS_VSCROLL = 0x00200000U;

        // ShowWindow
        internal const uint SW_FORCEMINIMIZE = 11;
        internal const uint SW_HIDE = 0;
        internal const uint SW_MAXIMIZE = 3;
        internal const uint SW_MINIMIZE = 6;
        internal const uint SW_RESTORE = 9;
        internal const uint SW_SHOW = 5;
        internal const uint SW_SHOWDEFAULT = 10;
        internal const uint SW_SHOWMAXIMIZED = 3;
        internal const uint SW_SHOWMINIMIZED = 2;
        internal const uint SW_SHOWMINNOACTIVE = 7;
        internal const uint SW_SHOWNA = 8;
        internal const uint SW_SHOWNOACTIVATE = 4;
        internal const uint SW_SHOWNORMAL = 1;

        // MsgWaitForMultipleObjects
        internal const uint QS_KEY = 0x1;
        internal const uint QS_MOUSEMOVE = 0x2;
        internal const uint QS_MOUSEBUTTON = 0x4;
        internal const uint QS_MOUSE = (QS_MOUSEMOVE | QS_MOUSEBUTTON);
        internal const uint QS_INPUT = (QS_MOUSE | QS_KEY);
        internal const uint QS_POSTMESSAGE = 0x8;
        internal const uint QS_TIMER = 0x10;
        internal const uint QS_PAINT = 0x20;
        internal const uint QS_SENDMESSAGE = 0x40;
        internal const uint QS_HOTKEY = 0x80;
        internal const uint QS_REFRESH = (QS_HOTKEY | QS_KEY | QS_MOUSEBUTTON | QS_PAINT);
        internal const uint QS_ALLEVENTS = (QS_INPUT | QS_POSTMESSAGE | QS_TIMER | QS_PAINT | QS_HOTKEY);
        internal const uint QS_ALLINPUT = (QS_SENDMESSAGE | QS_PAINT | QS_TIMER | QS_POSTMESSAGE | QS_MOUSEBUTTON | QS_MOUSEMOVE | QS_HOTKEY | QS_KEY);
        internal const uint QS_ALLPOSTMESSAGE = 0x100;
        internal const uint QS_RAWINPUT = 0x400;

        // PeekMessage
        internal const uint PM_NOREMOVE = 0x0000;
        internal const uint PM_REMOVE = 0x0001;
        internal const uint PM_NOYIELD = 0x0002;

        // LoadCursor
        internal const uint IDC_ARROW = 32512;
        internal const uint IDC_IBEAM = 32513;
        internal const uint IDC_WAIT = 32514;
        internal const uint IDC_CROSS = 32515;
        internal const uint IDC_UPARROW = 32516;
        internal const uint IDC_SIZE = 32640;
        internal const uint IDC_ICON = 32641;
        internal const uint IDC_SIZENWSE = 32642;
        internal const uint IDC_SIZENESW = 32643;
        internal const uint IDC_SIZEWE = 32644;
        internal const uint IDC_SIZENS = 32645;
        internal const uint IDC_SIZEALL = 32646;
        internal const uint IDC_NO = 32648;
        internal const uint IDC_HAND = 32649;
        internal const uint IDC_APPSTARTING = 32650;
        internal const uint IDC_HELP = 32651;

        // WM_SIZE
        internal const uint SIZE_MAXHIDE = 4;
        internal const uint SIZE_MAXIMIZED = 2;
        internal const uint SIZE_MAXSHOW = 3;
        internal const uint SIZE_MINIMIZED = 1;
        internal const uint SIZE_RESTORED = 0;

        // TrackMouseEvent
        internal const uint TME_LEAVE = 0x00000002;

        internal const int CW_USEDEFAULT = unchecked((int)0x80000000);

        internal delegate IntPtr WndProc(IntPtr windowHandle, uint messageId, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        internal struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct TrackMouseEventParameters
        {
            public uint cbSize;
            public uint dwFlags;
            public IntPtr hwndTrack;
            public uint dwHoverTime;
        };

        [StructLayout(LayoutKind.Sequential)]
        internal struct Message
        {
            public IntPtr handle;
            public uint id;
            public IntPtr wParam;
            public IntPtr lParam;
            public uint time;
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct WindowClass
        {
            public uint style;
            public IntPtr windowProcedure;
            public int classExtra;
            public int windowExtra;
            public IntPtr instance;
            public IntPtr icon;
            public IntPtr cursor;
            public IntPtr backgroundBrush;
            public string menuName;
            public string className;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct PixelFormatDescriptor
        {
            public ushort size;
            public ushort version;
            public uint flags;
            public byte pixelType;
            public byte colorBits;
            public byte redBits;
            public byte redShift;
            public byte greenBits;
            public byte greenShift;
            public byte blueBits;
            public byte blueShift;
            public byte alphaBits;
            public byte alphaShift;
            public byte accumBits;
            public byte accumRedBits;
            public byte accumGreenBits;
            public byte accumBlueBits;
            public byte accumAlphaBits;
            public byte depthBits;
            public byte stencilBits;
            public byte auxBuffers;
            public byte layerType;
            public byte reserved;
            public ushort layerMask;
            public ushort visibleMask;
            public ushort damageMask;
        }

        [DllImport(USER32)]
        internal static extern uint MsgWaitForMultipleObjects(uint count, IntPtr[] handles,
           bool waitAll, uint milliseconds, uint wakeMask);

        [DllImport(USER32)]
        internal static extern IntPtr LoadCursor(IntPtr instance, uint cursor);

        [DllImport(KERNEL32)]
        internal static extern IntPtr CreateEvent(IntPtr eventAttributes, bool manualReset,
            bool initialState, string name);

        [DllImport(KERNEL32)]
        internal static extern bool SetEvent(IntPtr handle);

        [DllImport(KERNEL32)]
        internal static extern bool ResetEvent(IntPtr handle);

        [DllImport(KERNEL32)]
        internal static extern bool CloseHandle(IntPtr handle);

        [DllImport(USER32)]
        internal static extern void PostQuitMessage(int exitCode);

        [DllImport(USER32)]
        internal static extern bool PeekMessage(ref Message message, IntPtr window, uint messageFilterMin,
           uint messageFilterMax, uint removeMessage);

        [DllImport(USER32)]
        internal static extern bool GetMessage(ref Message message, IntPtr window, uint messageFilterMin, uint messageFilterMax);

        [DllImport(USER32)]
        internal static extern bool TranslateMessage(ref Message message);

        [DllImport(USER32)]
        internal static extern bool DispatchMessage(ref Message message);

        [DllImport(USER32)]
        internal static extern ushort RegisterClass(ref WindowClass windowClass);

        [DllImport(USER32)]
        internal static extern bool GetClientRect(IntPtr windowHandle, ref Rect rect);

        [DllImport(USER32)]
        internal static extern bool TrackMouseEvent(ref TrackMouseEventParameters parameters);

        [DllImport(KERNEL32)]
        internal static extern IntPtr GetModuleHandle(string moduleName);

        [DllImport(USER32)]
        internal static extern bool UnregisterClass(string className, IntPtr instance);

        [DllImport(USER32, SetLastError=true)]
        internal static extern IntPtr CreateWindowEx(
            uint exstyle,
            string className,
            string windowName,
            uint style,
            int x,
            int y,
            int width,
            int height,
            IntPtr parent,
            IntPtr menu,
            IntPtr instance,
            IntPtr param
        );

        [DllImport(KERNEL32)]
        internal static extern IntPtr GetProcAddress(IntPtr module, string proc);

        [DllImport(KERNEL32)]
        internal static extern IntPtr LoadLibrary(string moduleName);

        [DllImport(KERNEL32)]
        internal static extern uint GetLastError();

        [DllImport(USER32)]
        internal static extern bool DestroyWindow(IntPtr windowHandle);

        [DllImport(USER32)]
        internal static extern IntPtr DefWindowProc(IntPtr windowHandle, uint messageId, IntPtr wParam, IntPtr lParam);

        [DllImport(USER32)]
        internal static extern bool ShowWindow(IntPtr windowHandle, uint command);

        [DllImport(USER32)]
        internal static extern IntPtr GetDC(IntPtr windowHandle);

        [DllImport(USER32)]
        internal static extern int ReleaseDC(IntPtr windowHandle, IntPtr deviceContextHandle);

        [DllImport(USER32)]
        internal static extern bool ValidateRect(IntPtr windowHandle, IntPtr rect);

        [DllImport(USER32)]
        internal static extern bool InvalidateRect(IntPtr windowHandle, IntPtr rect, bool erase);

        [DllImport(USER32)]
        internal static extern bool SetWindowText(IntPtr windowHandle, string text);

        [DllImport(GDI32)]
        internal static extern int ChoosePixelFormat(IntPtr deviceContextHandle, ref PixelFormatDescriptor pixelFormatDescriptor);

        [DllImport(GDI32)]
        internal static extern bool SetPixelFormat(IntPtr deviceContextHandle, int pixelFormatIndex, ref PixelFormatDescriptor pixelFormatDescriptor);

        [DllImport(OPENGL32)]
        internal static extern IntPtr wglCreateContext(IntPtr deviceContextHandle);

        [DllImport(OPENGL32)]
        internal static extern bool wglMakeCurrent(IntPtr deviceContextHandle, IntPtr openglContextHandle);

        [DllImport(OPENGL32)]
        internal static extern IntPtr wglGetCurrentContext();

        [DllImport(OPENGL32)]
        internal static extern IntPtr wglGetCurrentDC();

        [DllImport(OPENGL32)]
        internal static extern IntPtr wglGetProcAddress(byte[] proc);

        [DllImport(OPENGL32)]
        internal static extern IntPtr wglDeleteContext(IntPtr openglContextHandle);

        [DllImport(GDI32)]
        internal static extern bool SwapBuffers(IntPtr deviceContextHandle);

        [DllImport(USER32)]
        internal static extern IntPtr SendMessage(IntPtr windowHandle, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport(USER32)]
        internal static extern bool PostMessage(IntPtr windowHandle, uint msg, IntPtr wParam, IntPtr lParam);

    }
}
