using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public abstract class ApplicationResource : IDisposable
    {
        private bool m_disposed;

        internal ApplicationResource()
        {
        }

        ~ApplicationResource()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (!m_disposed)
            {
                m_disposed = true;
                GC.SuppressFinalize(this);

                InternalDispose();
            }
        }

        public bool Disposed { get { return m_disposed; } }

        protected void CheckDisposed()
        {
            if (m_disposed)
            {
                throw new ObjectDisposedException(null);
            }
        }

        protected abstract void InternalDispose();
    }
}
