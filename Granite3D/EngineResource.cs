using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite3D
{
    public abstract class EngineResource : IDisposable
    {
        private readonly Engine m_engine;
        private bool m_disposed;

        internal EngineResource(Engine engine)
        {
            m_engine = engine;
        }

        ~EngineResource()
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

        public Engine Engine { get { return m_engine; } }
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
