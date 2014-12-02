using System.Runtime.InteropServices;
using System;
using System.Diagnostics;

namespace Granite.Core
{
    public static partial class GL
    {
        private const string OPENGL32 = "opengl32.dll";
        private const string KERNEL32 = "kernel32.dll";

        [DllImport(OPENGL32)]
        private static extern IntPtr wglGetProcAddress(string name);

        [DllImport(KERNEL32)]
        private static extern IntPtr LoadLibrary(string name);

        [DllImport(KERNEL32)]
        private static extern IntPtr GetProcAddress(IntPtr library, string name);

        private delegate IntPtr Delegate_CreateContextAttribsARB(IntPtr hdc, IntPtr shareContext, uint[] attribList);

        private const uint CONTEXT_MAJOR_VERSION_ARB = 0x00002091;
        private const uint CONTEXT_MINOR_VERSION_ARB = 0x00002092;
        private const uint CONTEXT_LAYER_PLANE_ARB = 0x00002093;
        private const uint CONTEXT_FLAGS_ARB = 0x00002094;
        private const uint CONTEXT_PROFILE_MASK_ARB = 0x00009126;

        private const uint CONTEXT_DEBUG_BIT_ARB = 0x00000001;
        private const uint CONTEXT_FORWARD_COMPATIBLE_BIT_ARB = 0x00000002;
        private const uint CONTEXT_CORE_PROFILE_BIT_ARB = 0x00000001;
        private const uint CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x00000002;

        private const uint ERROR_INVALID_VERSION_ARB = 0x00002095;
        private const uint ERROR_INVALID_PROFILE_ARB = 0x00002096;

        private static readonly IntPtr m_opengl32Library;
        private static IntPtr m_context;
        
        static GL()
        {
            m_opengl32Library = LoadLibrary(OPENGL32);
        }

        internal static void Initialize(Display display, int colorBits, int depthBits)
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

            int pixelFormatIndex = WinApi.ChoosePixelFormat(display.DeviceContext, ref pixelFormat);

            var result = WinApi.SetPixelFormat(display.DeviceContext, pixelFormatIndex, ref pixelFormat);

            var temporaryContext = WinApi.wglCreateContext(display.DeviceContext);
            WinApi.wglMakeCurrent(display.DeviceContext, temporaryContext);

            var wglCreateContextAttribsARB =
                (Delegate_CreateContextAttribsARB)
                Marshal.GetDelegateForFunctionPointer(
                wglGetProcAddress("wglCreateContextAttribsARB"),
                typeof(Delegate_CreateContextAttribsARB)
            );

            m_context = wglCreateContextAttribsARB(
                display.DeviceContext, IntPtr.Zero, new uint[] {
                    CONTEXT_MAJOR_VERSION_ARB, 3,
                    CONTEXT_MINOR_VERSION_ARB, 0,
                    CONTEXT_PROFILE_MASK_ARB, CONTEXT_CORE_PROFILE_BIT_ARB,
                    0
                }
            );

            WinApi.wglDeleteContext(temporaryContext);
            WinApi.wglMakeCurrent(display.DeviceContext, m_context);

            InitializeFunctions();

            m_SwapInterval = (Delegate_SwapInterval)GetFunctionDelegate("wglSwapIntervalEXT", typeof(Delegate_SwapInterval));
        }

        internal static void Uninitialize()
        {
            WinApi.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero);
            WinApi.wglDeleteContext(m_context);
            m_context = IntPtr.Zero;
            UninitializeFunctions();

            m_SwapInterval = null;
        }

        #region Extensions
        private delegate bool Delegate_SwapInterval(int interval);
        private static Delegate_SwapInterval m_SwapInterval;
        internal static bool SwapInterval(int interval)
        {
            if (m_SwapInterval != null)
            {
                return m_SwapInterval(interval);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Loading
        private static Delegate GetFunctionDelegate(string name, Type t)
        {
            var address = wglGetProcAddress(name);

            if (address == IntPtr.Zero)
            {
                address = GetProcAddress(m_opengl32Library, name);
            }

            if (address == IntPtr.Zero)
            {
                Debug.WriteLine("function " + name + " not found");
                return null;
            }
            else
            {
                return Marshal.GetDelegateForFunctionPointer(address, t);
            }
        }
        #endregion

        #region Misc
        public static void Viewport(int width, int height)
        {
            Viewport(0, 0, width, height);
        }
        public static void Viewport(Vector2i size)
        {
            Viewport(0, 0, size.X, size.Y);
        }
        #endregion

        #region Enable/Disable
        public static void Enable_DEPTH_TEST() { Enable(DEPTH_TEST); }
        public static void Disable_DEPTH_TEST() { Disable(DEPTH_TEST); }
        public static void Enable_BLEND() { Enable(BLEND); }
        public static void Disable_BLEND() { Disable(BLEND); }
        #endregion

        #region Create/Delete

        internal static uint GenTexture()
        {
            uint name;
            GenTextures(1, out name);
            return name;
        }

        internal static void GenTextures(uint[] names)
        {
            GenTextures(names.Length, names);
        }

        internal static void DeleteTexture(uint name)
        {
            DeleteTextures(1, ref name);
        }

        internal static uint GenVertexArray()
        {
            uint name;
            GenVertexArrays(1, out name);
            return name;
        }

        internal static void DeleteVertexArray(uint name)
        {
            DeleteVertexArrays(1, ref name);
        }

        #endregion

        #region Buffers
        public static void BindBuffer(uint target, Buffer buffer)
        {
            BindBuffer(target, buffer == null ? 0 : buffer.Name);
        }
        public static void BindBuffer_ARRAY_BUFFER(Buffer buffer)
        {
            BindBuffer(ARRAY_BUFFER, buffer == null ? 0 : buffer.Name);
        }
        public static void BindBuffer_ELEMENT_ARRAY_BUFFER(Buffer buffer)
        {
            BindBuffer(ELEMENT_ARRAY_BUFFER, buffer == null ? 0 : buffer.Name);
        }
        #endregion

        #region VertexArray
        public static void BindVertexArray(VertexArray vertexArray)
        {
            GL.BindVertexArray(vertexArray == null ? 0 : vertexArray.Name);
        }
        #endregion

        #region Programs / Shaders
        public static void UseProgram(Program program)
        {
            UseProgram(program == null ? 0 : program.Name);
        }
        #endregion

        #region Draw
        
        public static void DrawElements(uint mode, byte[] indices)
        {
            DrawElements(mode, indices.Length, GL.UNSIGNED_BYTE, indices);
        }
        
        public static void DrawElements(uint mode, ushort[] indices)
        {
            DrawElements(mode, indices.Length, GL.UNSIGNED_SHORT, indices);
        }
        
        public static void DrawElements(uint mode, uint[] indices)
        {
            DrawElements(mode, indices.Length, GL.UNSIGNED_INT, indices);
        }

        public static void DrawElementsBaseVertex(uint mode, byte[] indices, int basevertex)
        {
            DrawElementsBaseVertex(mode, indices.Length, GL.UNSIGNED_BYTE, indices, basevertex);
        }

        public static void DrawElementsBaseVertex(uint mode, ushort[] indices, int basevertex)
        {
            DrawElementsBaseVertex(mode, indices.Length, GL.UNSIGNED_SHORT, indices, basevertex);
        }

        public static void DrawElementsBaseVertex(uint mode, uint[] indices, int basevertex)
        {
            DrawElementsBaseVertex(mode, indices.Length, GL.UNSIGNED_INT, indices, basevertex);
        }

        #endregion
    }
}
