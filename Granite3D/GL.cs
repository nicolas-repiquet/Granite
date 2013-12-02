using System.Runtime.InteropServices;
using System;

namespace Granite3D
{
    public partial class GL
    {
        [DllImport("opengl32.dll")]
        private static extern IntPtr wglGetProcAddress(string name);

        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string name);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetProcAddress(IntPtr library, string name);

        private static readonly IntPtr s_opengl32Library;

        static GL()
        {
            s_opengl32Library = LoadLibrary("opengl32.dll");
        }

        private static IntPtr GetFunctionAddress(string name)
        {
            var address = wglGetProcAddress(name);

            if (address == IntPtr.Zero)
            {
                address = GetProcAddress(s_opengl32Library, name);
            }

            return address;
        }
    }
}
