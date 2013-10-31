using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite3D
{
    public sealed class Texture2D : EngineResource
    {
        private readonly uint m_name;

        internal Texture2D(Engine engine)
            : base(engine)
        {
            uint name;
            Engine.Gl.glGenTextures(1, out name);
            m_name = name;
        }

        internal uint Name { get { return m_name; } }

        public void SetData<T>(int width, int height, T[] data) where T : struct
        {
            var descriptor = ValueTypeDescriptor.Create(typeof(T));
            uint format;

            if (descriptor.FlattenedCount == 3)
            {
                format = GlApi.GL_RGB;
            }
            else if (descriptor.FlattenedCount == 4)
            {
                format = GlApi.GL_RGBA;
            }
            else
            {
                throw new ArgumentException("data");
            }

            Engine.Gl.glBindTexture(GlApi.GL_TEXTURE_2D, m_name);

            Engine.Gl.glTexParameteri(GlApi.GL_TEXTURE_2D, GlApi.GL_TEXTURE_MIN_FILTER, (int)GlApi.GL_NEAREST);
            Engine.Gl.glTexParameteri(GlApi.GL_TEXTURE_2D, GlApi.GL_TEXTURE_MAG_FILTER, (int)GlApi.GL_NEAREST);
            Engine.Gl.glTexParameteri(GlApi.GL_TEXTURE_2D, GlApi.GL_TEXTURE_WRAP_S, (int)GlApi.GL_CLAMP_TO_EDGE);
            Engine.Gl.glTexParameteri(GlApi.GL_TEXTURE_2D, GlApi.GL_TEXTURE_WRAP_T, (int)GlApi.GL_CLAMP_TO_EDGE);

            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            try
            {
                Engine.Gl.glTexImage2D(
                    GlApi.GL_TEXTURE_2D,
                    0,
                    (int)format,
                    width,
                    height,
                    0,
                    format,
                    descriptor.FlattenedType,
                    handle.AddrOfPinnedObject()
                );
                Engine.Gl.CheckError();
            }
            finally
            {
                handle.Free();
            }

            Engine.Gl.glBindTexture(GlApi.GL_TEXTURE_2D, 0);
        }

        protected override void InternalDispose()
        {
            var name = m_name;

            Engine.ExecuteAction(() =>
            {
                Engine.Gl.glDeleteTextures(1, out name);
            });    
        }
    }
}
