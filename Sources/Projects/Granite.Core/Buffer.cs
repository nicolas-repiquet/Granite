using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Granite.Core
{
    public enum BufferTarget : uint
    {
        Array = GL.ARRAY_BUFFER,
        CopyRead = GL.COPY_READ_BUFFER,
        CopyWrite = GL.COPY_WRITE_BUFFER,
        ElementArray = GL.ELEMENT_ARRAY_BUFFER,
        PixelPack = GL.PIXEL_PACK_BUFFER,
        PixelUnpack = GL.PIXEL_UNPACK_BUFFER,
        Texture = GL.TEXTURE_BUFFER,
        TransformFeedback = GL.TRANSFORM_FEEDBACK_BUFFER,
        Uniform = GL.UNIFORM_BUFFER
    }

    public enum BufferUsage : uint
    {
        StreamDraw = GL.STREAM_DRAW,
        StreamRead = GL.STREAM_READ,
        StreamCopy = GL.STREAM_COPY,
        StaticDraw = GL.STATIC_DRAW,
        StaticRead = GL.STATIC_READ,
        StaticCopy = GL.STATIC_COPY,
        DynamicDraw = GL.DYNAMIC_DRAW,
        DynamicRead = GL.DYNAMIC_READ,
        DynamicCopy = GL.DYNAMIC_COPY
    }

    public abstract class Buffer : ApplicationResource
    {
        internal Buffer(BufferTarget target, BufferUsage usage)
        {
            uint name;
            GL.GenBuffers(1, out name);
            Name = name;
            Target = target;
            Usage = usage;
        }

        internal uint Name { get; }
        public BufferTarget Target { get; }
        public BufferUsage Usage { get; }
        public abstract int Count { get; }
        public abstract int TypeSize { get; }

        protected override void InternalDispose()
        {
            var name = Name;

            Engine.ExecuteAction(() =>
            {
                GL.DeleteBuffers(1, ref name);
            });
        }
    }

    public sealed class Buffer<T> : Buffer where T : struct
    {
        #region VIEW
        private sealed class View<TItem> : IBufferView<TItem>
        {
            private readonly Buffer m_buffer;
            private readonly int m_size;
            private readonly uint m_type;
            private readonly int m_offset;
            private readonly int m_stride;

            public View(Buffer buffer, int size, uint type, int offset, int stride)
            {
                m_buffer = buffer;
                m_size = size;
                m_type = type;
                m_offset = offset;
                m_stride = stride;
            }

            public Buffer Buffer { get { return m_buffer; } }
            public int Size { get { return m_size; } }
            public uint Type { get { return m_type; } }
            public int Offset { get { return m_offset; } }
            public int Stride { get { return m_stride; } }
        }
        #endregion

        #region STATIC

        private static readonly ValueTypeDescriptor s_descriptor;

        static Buffer()
        {
            s_descriptor = ValueTypeDescriptor.Create(typeof(T));
        }

        private static void Inspect(Type t)
        {
            if (t.IsPrimitive)
            {

            }
            else
            {

            }
        }
        #endregion

        private int m_count;

        public Buffer(BufferTarget target, BufferUsage usage) : base(target, usage)
        {

        }

        public override int Count
        {
            get { return m_count; }
        }

        public override int TypeSize
        {
            get { return s_descriptor.Size; }
        }

        public IBufferView<T> GetView()
        {
            return new View<T>(this, s_descriptor.FlattenedCount, s_descriptor.FlattenedType, 0, 0);
        }

        public IBufferView<TItem> GetView<TItem>(string name)
        {
            var field = s_descriptor.GetField(name);

            if (field.Descriptor.Type != typeof(TItem))
            {
                throw new InvalidOperationException(string.Format(
                    "Can't convert from {0} to {1}",
                    field.Descriptor.Type.Name,
                    typeof(TItem).Name
                ));
            }
            else
            {
                return new View<TItem>(this, field.Descriptor.FlattenedCount, field.Descriptor.FlattenedType, field.Offset, s_descriptor.Size);
            }
        }

        public IBufferView<TItem> GetView<TItem>(Expression<Func<T, TItem>> field)
        {
            if (field == null)
            {
                throw new ArgumentNullException("field");
            }

            var f = s_descriptor.GetField(field.Body);

            if (f.Descriptor.Type != typeof(TItem))
            {
                throw new InvalidOperationException(string.Format(
                    "Can't convert from {0} to {1}",
                    f.Descriptor.Type.Name,
                    typeof(TItem).Name
                ));
            }
            else
            {
                return new View<TItem>(this, f.Descriptor.FlattenedCount, f.Descriptor.FlattenedType, f.Offset, s_descriptor.Size);
            }
        }

        public void Bind()
        {
            GL.BindBuffer((uint)Target, Name);
        }

        public void Unbind()
        {
            GL.BindBuffer((uint)Target, 0);
        }

        public void Clear()
        {
            GL.BufferData((uint)Target, IntPtr.Zero, IntPtr.Zero, (uint)Usage);
            m_count = 0;
        }

        public void SetData(int count)
        {
            if (count == 0)
            {
                Clear();
            }
            else
            {
                GL.BufferData((uint)Target, new IntPtr(count * TypeSize), IntPtr.Zero, (uint)Usage);
                m_count = count;
            }
        }

        public void SetData(T[] data)
        {
            if (data == null)
            {
                Clear();
            }
            else
            {
                var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

                try
                {
                    var size = TypeSize * data.Length;
                    GL.BufferData((uint)Target, new IntPtr(size), handle.AddrOfPinnedObject(), (uint)Usage);
                    m_count = data.Length;
                }
                finally
                {
                    handle.Free();
                }
            }
        }

        public void SetData(T[] data, int index, int count)
        {
#if DEBUG
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (index < 0 || index >= data.Length) throw new ArgumentException(nameof(index));
            if (count < 0 || index + count > data.Length) throw new ArgumentException(nameof(count));
#endif

            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            try
            {
                var size = TypeSize * count;
                GL.BufferData((uint)Target, new IntPtr(size), IntPtr.Add(handle.AddrOfPinnedObject(), TypeSize * index), (uint)Usage);
                m_count = count;
            }
            finally
            {
                handle.Free();
            }
        }

        public void SetSubData(T[] data, int offset, int count)
        {
            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            try
            {
                var size = TypeSize * count;
                GL.BufferSubData((uint)Target, new IntPtr(offset), new IntPtr(size), handle.AddrOfPinnedObject());
                m_count = count;
            }
            finally
            {
                handle.Free();
            }
        }

        public BufferMapping<T> Map(int count)
        {
            var size = TypeSize * count;
            //GL.BindBuffer((uint)Target, Name);
            //GL.BufferData(GL.ARRAY_BUFFER, new IntPtr(size), IntPtr.Zero, GL.STREAM_DRAW);
            var address = GL.MapBufferRange(GL.ARRAY_BUFFER, new IntPtr(0), new IntPtr(size), GL.MAP_WRITE_BIT | GL.MAP_INVALIDATE_BUFFER_BIT);

            return new BufferMapping<T>(this, address);
        }
    }


}