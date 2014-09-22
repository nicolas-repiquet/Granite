using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite.Core
{
    public sealed class Texture2D : EngineResource
    {
        private readonly uint m_name;

        internal Texture2D()
            : base()
        {
            m_name = GL.GenTexture();
        }

        internal uint Name { get { return m_name; } }

        public void SetData<T>(int width, int height, T[] data) where T : struct
        {
            var descriptor = ValueTypeDescriptor.Create(typeof(T));
            uint format;

            if (descriptor.FlattenedCount == 1)
            {
                format = GL.RED;
            }
            else if (descriptor.FlattenedCount == 3)
            {
                format = GL.RGB;
            }
            else if (descriptor.FlattenedCount == 4)
            {
                format = GL.RGBA;
            }
            else
            {
                throw new ArgumentException("data");
            }

            GL.BindTexture(GL.TEXTURE_2D, m_name);

            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MIN_FILTER, (int)GL.NEAREST);
            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MAG_FILTER, (int)GL.NEAREST);
            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_WRAP_S, (int)GL.CLAMP_TO_EDGE);
            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_WRAP_T, (int)GL.CLAMP_TO_EDGE);

            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            try
            {
                GL.TexImage2D(
                    GL.TEXTURE_2D,
                    0,
                    (int)format,
                    width,
                    height,
                    0,
                    format,
                    descriptor.FlattenedType,
                    handle.AddrOfPinnedObject()
                );
            }
            finally
            {
                handle.Free();
            }

            GL.BindTexture(GL.TEXTURE_2D, 0);
        }

        protected override void InternalDispose()
        {
            var name = m_name;

            Engine.ExecuteAction(() =>
            {
                GL.DeleteTexture(name);
            });    
        }
    }
}
