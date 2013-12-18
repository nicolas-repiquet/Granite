using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Granite.Core
{
    public abstract class OpenGLContext
    {
        private const string OPENGL32 = "opengl32.dll";
        private const string KERNEL32 = "kernel32.dll";

        #region Loading
        [DllImport(OPENGL32)]
        private static extern IntPtr wglGetProcAddress(string name);

        [DllImport(KERNEL32)]
        private static extern IntPtr LoadLibrary(string name);

        [DllImport(KERNEL32)]
        private static extern IntPtr GetProcAddress(IntPtr library, string name);

        private static readonly IntPtr s_opengl32Library;

        static OpenGLContext()
        {
            s_opengl32Library = LoadLibrary(OPENGL32);
        }

        protected static IntPtr GetFunctionAddress(string name)
        {
            var address = wglGetProcAddress(name);

            if (address == IntPtr.Zero)
            {
                address = GetProcAddress(s_opengl32Library, name);
            }

            if (address == IntPtr.Zero)
            {
                Debug.WriteLine("function " + name + " not found");
            }

            return address;
        }

        protected static Delegate GetDelegateForAddress(IntPtr address, Type type)
        {
            if (address == IntPtr.Zero)
            {
                return null;
            }
            else
            {
                return Marshal.GetDelegateForFunctionPointer(address, type);
            }
        }
        #endregion

        private readonly Thread m_thread;
        private readonly IntPtr m_handle;

        public OpenGLContext(IntPtr handle)
        {
            m_handle = handle;
            m_thread = Thread.CurrentThread;
        }
    }
}
