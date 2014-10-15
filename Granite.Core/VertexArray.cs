using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public sealed class VertexArray : ApplicationResource
    {
        private readonly uint m_name;

        internal uint Name { get { return m_name; } }

        public VertexArray()
        {
            m_name = GL.GenVertexArray();
        }

        protected override void InternalDispose()
        {
            var name = m_name;

            Engine.ExecuteAction(() =>
            {
                GL.DeleteVertexArray(name);
            });
        }
    }
}
