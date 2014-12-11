using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Granite.Core
{
    public class Texture2D : ApplicationResource
    {
        private readonly uint m_name;
        private Vector2i m_size;

        public Texture2D()
        {
            m_name = GL.GenTexture();
        }

        internal uint Name { get { return m_name; } }

        public Vector2i Size { get { return m_size; } }


        public void SetData<T>(int width, int height, T[] data) where T : struct
        {
            m_size = new Vector2i(width, height);

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
            //GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MIN_FILTER, (int)GL.LINEAR);
            //GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MAG_FILTER, (int)GL.LINEAR);
            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_WRAP_S, (int)GL.CLAMP_TO_EDGE);
            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_WRAP_T, (int)GL.CLAMP_TO_EDGE);

            if (data == null)
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
                    IntPtr.Zero
                );
            }
            else
            {
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

        public static Texture2D Load(Stream stream)
        {
            var bitmap = new Bitmap(stream);
            var texture = new Texture2D();

            texture.m_size = new Vector2i(bitmap.Width, bitmap.Height);

            var data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            GL.BindTexture(GL.TEXTURE_2D, texture.Name);

            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MIN_FILTER, (int)GL.NEAREST);
            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MAG_FILTER, (int)GL.NEAREST);
            //GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MIN_FILTER, (int)GL.LINEAR);
            //GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_MAG_FILTER, (int)GL.LINEAR);
            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_WRAP_S, (int)GL.CLAMP_TO_EDGE);
            GL.TexParameteri(GL.TEXTURE_2D, GL.TEXTURE_WRAP_T, (int)GL.CLAMP_TO_EDGE);

            GL.TexImage2D(GL.TEXTURE_2D, 0, (int)GL.RGBA8, bitmap.Width, bitmap.Height, 0, GL.BGRA, GL.UNSIGNED_BYTE, data.Scan0);

            GL.BindTexture(GL.TEXTURE_2D, 0);

            bitmap.UnlockBits(data);

            return texture;
        }

    }
}
