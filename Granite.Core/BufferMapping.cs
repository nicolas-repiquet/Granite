using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite.Core
{
    public sealed class BufferMapping<T> : IDisposable where T : struct
    {
        private readonly Buffer<T> m_buffer;
        private readonly IntPtr m_address;

        internal BufferMapping(Buffer<T> buffer, IntPtr address)
        {
            m_buffer = buffer;
            m_address = address;
        }

        public IntPtr Address { get { return m_address; } }

        public void Dispose()
        {
            GL.BindBuffer_ARRAY_BUFFER(m_buffer);
            GL.UnmapBuffer(GL.ARRAY_BUFFER);
        }
    }
}
