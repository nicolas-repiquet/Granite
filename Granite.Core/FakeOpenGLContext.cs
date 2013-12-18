using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    internal class FakeOpenGLContext : OpenGLContext
    {

        internal const uint CONTEXT_MAJOR_VERSION_ARB = 0x00002091;
        internal const uint CONTEXT_MINOR_VERSION_ARB = 0x00002092;
        internal const uint CONTEXT_LAYER_PLANE_ARB   = 0x00002093;
        internal const uint CONTEXT_FLAGS_ARB         = 0x00002094;
        internal const uint CONTEXT_PROFILE_MASK_ARB  = 0x00009126;

        internal const uint CONTEXT_DEBUG_BIT_ARB     = 0x00000001;
        internal const uint CONTEXT_FORWARD_COMPATIBLE_BIT_ARB    = 0x00000002;
        internal const uint CONTEXT_CORE_PROFILE_BIT_ARB          = 0x00000001;
        internal const uint CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x00000002;

        internal const uint ERROR_INVALID_VERSION_ARB = 0x00002095;
        internal const uint ERROR_INVALID_PROFILE_ARB = 0x00002096;

        private delegate IntPtr Delegate_CreateContextAttribsARB(IntPtr hdc, IntPtr shareContext, uint[] attribList);

        private readonly Delegate_CreateContextAttribsARB m_CreateContextAttribsARB;

        internal FakeOpenGLContext(IntPtr handle)
            : base(handle)
        {
            var CreateContextAttribsARB = GetFunctionAddress("wglCreateContextAttribsARB");
            m_CreateContextAttribsARB = (Delegate_CreateContextAttribsARB)GetDelegateForAddress(CreateContextAttribsARB, typeof(Delegate_CreateContextAttribsARB));
        }

        internal IntPtr CreateContextAttribsARB(IntPtr hdc, IntPtr shareContext, uint[] attribList)
        {
            return m_CreateContextAttribsARB(hdc, shareContext, attribList);
        }
    }
}
