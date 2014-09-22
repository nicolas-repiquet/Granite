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

        private static IntPtr m_opengl32Library;

        public static void Initialize()
        {
            m_opengl32Library = LoadLibrary(OPENGL32);

            using (var window = new Window())
            {
                window.SetPixelFormat();

                var temporaryContext = WinApi.wglCreateContext(window.DeviceContext);
                WinApi.wglMakeCurrent(window.DeviceContext, temporaryContext);

                var wglCreateContextAttribsARB =
                    (Delegate_CreateContextAttribsARB)
                    Marshal.GetDelegateForFunctionPointer(
                    wglGetProcAddress("wglCreateContextAttribsARB"),
                    typeof(Delegate_CreateContextAttribsARB)
                );

                var finalContext = wglCreateContextAttribsARB(
                    window.DeviceContext, IntPtr.Zero, new uint[] {
                        CONTEXT_MAJOR_VERSION_ARB, 3,
                        CONTEXT_MINOR_VERSION_ARB, 0,
                        CONTEXT_PROFILE_MASK_ARB, CONTEXT_CORE_PROFILE_BIT_ARB,
                        0
                    }
                );

                WinApi.wglMakeCurrent(window.DeviceContext, finalContext);
                WinApi.wglDeleteContext(temporaryContext);

                InitializeFunctions();

                WinApi.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero);
            }
        }

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

        #region Programs / Shaders
        public static void UseProgram(Program program)
        {
            UseProgram(program == null ? 0 : program.Name);
        }
        #endregion
    }
}
